using Notes.Core.Budget;
using Notes.Repos;
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
        private BudgetService budgetService;

        public Savings()
        {
            InitializeComponent();
            db = new DbHelper();

            int userId = UserState.getInstance().id;
            var regularBudgetRepo = new RegularBudgetXamppRepo();
            var singularBudgetRepo = new SingularBudgetXamppRepo();

            budgetService = new BudgetService(userId, regularBudgetRepo, singularBudgetRepo);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            var summary = budgetService.getSummary();
            
            foreach (var item in summary)
            {
                int rowIndex = dataGridView.Rows.Add();
                var row = dataGridView.Rows[rowIndex];
                row.Cells["month"].Value = item.month;
                row.Cells["income"].Value = item.income;
                row.Cells["expense"].Value = item.expense;
                row.Cells["diff"].Value = item.diff;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new NotesList().Show();
            this.Hide();
        }
    }
}
