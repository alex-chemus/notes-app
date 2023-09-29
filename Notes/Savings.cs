using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Savings : Form
    {
        private DbHelper db;

        public Savings()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int getTodaysRecords(int dayNumber, bool isIncome)
        {
            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;
            DateTime date = new DateTime(year, month, dayNumber);

            string cashRecordsQuery = $"SELECT SUM(amount) as 'amount' " +
                $"FROM cashBook WHERE " +
                $"recordDate = '{date.ToString("yyyy-MM-dd")}' " +
                $"AND isIncome = {isIncome};";

            try
            {
                DataRow record = db.getSignelRecord(cashRecordsQuery);
                int amount;
                Int32.TryParse(record["amount"].ToString(), out amount);
                return amount;
            }
            catch
            {
                return 0;
            }
        }

        private void insertDataGridRow(int dayNumber, Int64 income, Int64 expense)
        {
            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;
            DateTime date = new DateTime(year, month, dayNumber);

            int rowIndex = dataGridView.Rows.Add();
            var row = dataGridView.Rows[rowIndex];
            row.Cells["date"].Value = date.ToString("dd.MM.yyyy");
            row.Cells["income"].Value = income.ToString();
            row.Cells["expense"].Value = expense.ToString();
            row.Cells["diff"].Value = (income - expense).ToString();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int dayNumber = 1; dayNumber <= daysInMonth; dayNumber++)
            {
                Int64 income = getTodaysRecords(dayNumber, true);
                Int64 expense = getTodaysRecords(dayNumber, false);

                if (income != 0 || expense != 0) insertDataGridRow(dayNumber, income, expense);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new NotesList().Show();
            this.Hide();
        }
    }
}
