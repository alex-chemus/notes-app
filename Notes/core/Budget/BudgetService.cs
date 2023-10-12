namespace Notes.Core.Budget;

record MonthBudgetSummaryDto
{
    public int month { get; init; }
    public int income { get; init; }
    public int expense { get; init; }
    public int diff { get; init; }
}

internal class BudgetService
{
    private int userId;
    private IRegularBudgetRepo regularBudgetRepo;
    private ISingularBudgetRepo singularBudgetRepo;

    public BudgetService(int userId, IRegularBudgetRepo regularBudgetRepo, ISingularBudgetRepo singularBudgetRepo)
    {
        this.userId = userId;
        this.regularBudgetRepo = regularBudgetRepo;
        this.singularBudgetRepo = singularBudgetRepo;
    }

    public void addRegularBudgetItem(RegularBudgetCreationDto dto) => regularBudgetRepo.addItem(userId, dto);

    public void addSingularBudgetItem(SingularBudgetCreationDto dto) => singularBudgetRepo.addItem(userId, dto);

    private int getMonthRegularIncome(int month)
    {
        int amount = 0;
        var incomes = regularBudgetRepo.getIncomes(userId);
        foreach (var income in incomes)
        {
            switch (income.period)
            {
                case Period.Month:
                    amount += income.amount;
                    break;
                case Period.Quarter:
                    if (month == 3 || month == 6 || month == 9 || month == 12) amount += income.amount;
                    break;
                case Period.Year:
                    if (month == 12) amount += income.amount;
                    break;
            }
        }
        return amount;
    }

    private int getMonthRegularExpense(int month)
    {
        int amount = 0;
        var expenses = regularBudgetRepo.getExpenses(userId);
        foreach (var expense in expenses)
        {
            switch (expense.period)
            {
                case Period.Month:
                    amount += expense.amount;
                    break;
                case Period.Quarter:
                    if (month == 3 || month == 6 || month == 9 || month == 12) amount += expense.amount;
                    break;
                case Period.Year:
                    if (month == 12) amount += expense.amount;
                    break;
            }
        }
        return amount;
    }

    private MonthBudgetSummaryDto getMonthSummary(int month)
    {
        int income = singularBudgetRepo.getMonthIncome(userId, month) + getMonthRegularIncome(month);
        int expense = singularBudgetRepo.getMonthExpense(userId, month) + getMonthRegularExpense(month);
        return new MonthBudgetSummaryDto
        {
            month = month,
            income = income,
            expense = expense,
            diff = income - expense
        };
    }

    public List<MonthBudgetSummaryDto> getSummary()
    {
        var monthBudgetSummary = new List<MonthBudgetSummaryDto>();
        for (int i = 1; i <= 12; i++)
            monthBudgetSummary.Add(getMonthSummary(i));
        return monthBudgetSummary;
    }
}