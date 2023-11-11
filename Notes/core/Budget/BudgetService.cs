namespace Notes.Core.Budget;

record MonthBudgetSummaryDto
{
    public int month { get; init; }
    public int income { get; init; }
    public int expense { get; init; }
    public int diff { get; init; }
}

record AggregatedSummaryDto
{
    public int month { get; init; }
    public int summary { get; init; }
}

internal class BudgetService
{
    // injectable
    public int userId;
    public IRegularBudgetRepo regularBudgetRepo;
    public ISingularBudgetRepo singularBudgetRepo;
    public IPeriodRepo periodRepo;

    private List<IRegularBudgetItem> regularExpenses;
    private List<IRegularBudgetItem> regularIncomes;

    public void addRegularBudgetItem(RegularBudgetCreationDto dto) => regularBudgetRepo.addItem(userId, dto);

    public void addSingularBudgetItem(SingularBudgetCreationDto dto) => singularBudgetRepo.addItem(userId, dto);

    public List<GetPeriodDto> getAllPeriods() => periodRepo.getAllPeriods();

    private int getMonthRegularIncome(int month)
    {
        int amount = 0;
        if (regularIncomes == null) regularIncomes = regularBudgetRepo.getIncomes(userId);
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
        if (regularExpenses == null) regularExpenses = regularBudgetRepo.getExpenses(userId);
        foreach (var expense in regularExpenses)
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

    public List<AggregatedSummaryDto> getAggregatedSummary()
    {
        var aggregatedSummary = new List<AggregatedSummaryDto>();

        var summary = getSummary();

        int remainder = 0;

        foreach (var monthSummary in summary)
        {
            remainder += monthSummary.diff;
            aggregatedSummary.Add(new AggregatedSummaryDto
            {
                month = monthSummary.month,
                summary = remainder
            });
        }

        return aggregatedSummary;
    }
}