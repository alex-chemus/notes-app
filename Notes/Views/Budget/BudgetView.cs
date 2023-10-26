using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Notes.Repos;
using Notes.Core.Budget;
using Notes.Views.Budget;
using Notes.Repos.Xampp;

namespace Notes;

public partial class BudgetView : Form
{
    private int userId;
    private BudgetService budgetService;

    public BudgetView()
    {
        userId = UserState.getInstance().id;

        budgetService = new BudgetService
        {
            userId = userId,
            regularBudgetRepo = new RegularBudgetXamppRepo(),
            singularBudgetRepo = new SingularBudgetXamppRepo(),
            periodRepo = new PeriodXamppRepo()
        };

        InitializeComponent();
        fillDataGridView();
    }

    private string getMonthName(int n)
    {
        switch (n)
        {
            case 1: return "Январь";
            case 2: return "Феварль";
            case 3: return "Март";
            case 4: return "Апрель";
            case 5: return "Май";
            case 6: return "Июнь";
            case 7: return "Июль";
            case 8: return "Август";
            case 9: return "Сентябрь";
            case 10: return "Октябрь";
            case 11: return "Ноябрь";
            case 12: return "Декабрь";
            default: return "";
        }
    }
    private void fillDataGridView()
    {
        dataGridView.Rows.Clear();

        var summary = budgetService.getSummary();

        foreach (var item in summary)
        {
            int rowIndex = dataGridView.Rows.Add();
            var row = dataGridView.Rows[rowIndex];
            row.Cells["month"].Value = getMonthName(item.month);
            row.Cells["income"].Value = item.income;
            row.Cells["expense"].Value = item.expense;
            row.Cells["diff"].Value = item.diff;
        }
    }

    private void BudgetForm_Load(object sender, EventArgs e)
    {
        var periods = new List<ComboItem>();

        foreach (var period in budgetService.getAllPeriods())
        {
            periods.Add(new ComboItem((int)period.id, period.title));
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
            budgetService.addRegularBudgetItem(new RegularBudgetCreationDto
            {
                period = period.getId(),
                amount = amount,
                isIncome = isIncome,
                userId = userId
            });
        }
        else
        {
            budgetService.addSingularBudgetItem(new SingularBudgetCreationDto
            {
                creationDate = date,
                amount = amount,
                isIncome = isIncome,
                userId = userId
            });
        }

        MessageBox.Show("Добавлено");
        amountTextBox.Text = "";

        fillDataGridView();
    }

    private void notesButton_Click(object sender, EventArgs e)
    {
        new NotesView().Show();
        Hide();
    }
}
