using Notes.Repos;
using Notes.Core.Budget;
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
    public partial class BudgetForm : Form
    {
        private DbHelper db;
        private RegularBudgetXamppRepo regularBudgetRepo;
        private SingularBudgetXamppRepo singularBudgetRepo;

        public BudgetForm()
        {
            db = new DbHelper();
            regularBudgetRepo = new RegularBudgetXamppRepo();
            singularBudgetRepo = new SingularBudgetXamppRepo();
            InitializeComponent();
        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            string query = "select * from Periods";
            DataTable result = db.getRecords(query);
            var periods = new List<ComboItem>();
            foreach (DataRow row in result.Rows)
            {
                periods.Add(new ComboItem((int)row["id"], (string)row["title"]));
            }
            periodCombo.DataSource = periods;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(amountTextBox.Text);
            bool isIncome = incomeRadio.Checked;
            bool isRegular = regularRadio.Checked;
            int selectedIndex = periodCombo.SelectedIndex;
            ComboItem period = periodCombo.Items[selectedIndex] as ComboItem;
            DateTime date = dateTimePicker1.Value;

            if (isRegular)
            {
                int userId = UserState.getInstance().id;
                regularBudgetRepo.addItem(userId, new RegularBudgetCreationDto
                {
                    period = period.getId(),
                    amount = amount,
                    isIncome = isIncome,
                    userId = userId
                });
            }
            else
            {
                int userId = UserState.getInstance().id;
                singularBudgetRepo.addItem(userId, new SingularBudgetCreationDto
                {
                    creationDate = date,
                    amount = amount,
                    isIncome = isIncome,
                    userId = userId
                });
            }

            MessageBox.Show("Добавлено");
            amountTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new NotesList().Show();
            Hide();
        }
    }
}
