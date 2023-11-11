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
using Notes.Core.Goals;
using Notes.Views.Budget;
using Notes.Repos.Xampp;

namespace Notes;

public partial class BudgetView : Form
{
    private int userId;
    private BudgetService budgetService;
    private GoalsService goalsSerivce;

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

        goalsSerivce = new GoalsService(budgetService, new GoalsXamppRepo());

        InitializeComponent();
        fillDataGridView();

        initGoals();

        setLayoutTheme();
    }

    private void initGoals()
    {
        int id = UserState.getInstance().id;
        try
        {
            var goal = goalsSerivce.getGoal(id);
            goalNameLabel.Text += goal.name;
            goalAmountLabel.Text += goal.amount.ToString();
            goalDeadlineLabel.Text += goal.deadline.ToString("dd-MM-yyyy");
            goalReachedLabel.Text += goal.reached.ToString();
            goalRemainderLabel.Text += goal.remainder.ToString();
            goalTrendLabel.Text += goal.trend.ToString("MM-yyyy");
        }
        catch
        {
            goalViewPanel.Hide();
            goalFormPanel.Show();
        }
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

    private void createGoalButton_Click(object sender, EventArgs e)
    {
        string goalName = goalNameTextbox.Text;
        int goalAmount = Int32.Parse(goalAmountTextbox.Text);
        DateTime goalDeadline = goalDeadlineDatepicker.Value;
        int id = UserState.getInstance().id;

        try
        {
            goalsSerivce.addGoal(new CreateGoalDto
            {
                name = goalName,
                amount = goalAmount,
                deadline = goalDeadline,
                id = id,
            });
        }
        catch
        {
            MessageBox.Show("Ошибка создания цели");
        }
    }

    private void setLayoutTheme()
    {
        var theme = ColorModeState.getInstance();

        this.BackColor = theme.bgPrimary;
        this.colorModeButton.ForeColor = theme.textPrimary;
        this.amountBudgetLabel.ForeColor = theme.textSecondary;
        this.amountTextBox.BackColor = theme.bgSecondary;
        this.amountTextBox.ForeColor = theme.textSecondary;
        this.incomeGroup.ForeColor = theme.textSecondary;
        this.periodBox.ForeColor = theme.textSecondary;
        this.periodTitle.ForeColor = theme.textSecondary;
        this.dateTitle.ForeColor = theme.textSecondary;
        this.periodCombo.BackColor = theme.bgSecondary;
        this.periodCombo.ForeColor = theme.textSecondary;
        this.dataGridView.BackgroundColor = theme.bgSecondary;
        this.goalTitle.ForeColor = theme.textPrimary;
        this.goalFormTitle.ForeColor = theme.textPrimary;
        this.goalNameLabel.ForeColor = theme.textSecondary;
        this.goalDeadlineLabel.ForeColor = theme.textSecondary;
        this.goalAmountLabel.ForeColor = theme.textSecondary;
        this.goalReachedLabel.ForeColor = theme.textSecondary;
        this.goalRemainderLabel.ForeColor = theme.textSecondary;
        this.goalTrendLabel.ForeColor = theme.textSecondary;
        this.goalFormName.ForeColor = theme.textSecondary;
        this.goalFormAmount.ForeColor = theme.textSecondary;
        this.goalFormDeadline.ForeColor = theme.textSecondary;
        this.goalNameTextbox.ForeColor = theme.textSecondary;
        this.goalNameTextbox.BackColor = theme.bgSecondary;
        this.goalAmountTextbox.ForeColor = theme.textSecondary;
        this.goalAmountTextbox.BackColor = theme.bgSecondary;
        this.goalDeadlineDatepicker.CalendarForeColor = theme.textSecondary;
        this.goalDeadlineDatepicker.CalendarMonthBackground = theme.bgSecondary;
    }

    private void colorModeButton_Click(object sender, EventArgs e)
    {
        var colorMode = ColorModeState.getInstance();

        colorMode.setColorMode(colorMode.mode == "dark" ? "light" : "dark");

        setLayoutTheme();
    }
}
