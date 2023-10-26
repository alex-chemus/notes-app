namespace Notes.Core.Budget;

enum Period
{
    Month,
    Quarter,
    Year
}

interface IRegularBudgetItem
{
    public int id { get; set; }
    public Period period { get; set; }
    public int amount { get; set; }
    public bool isIncome { get; set; }
    public int userId { get; set; }
}

interface ISingularBudgetItem
{
    public int id { get; set; }
    public int amount { get; set; }
    public bool isIncome { get; set; }
    public DateTime creationDate { get; set; }
    public int userId { get; set; }
}

record RegularBudgetCreationDto
{
    public Period period { get; init; }
    public int amount { get; init; }
    public bool isIncome { get; init; }
    public int userId { get; init; }

}

class RegularBudgetItem : IRegularBudgetItem
{
    public int id { get; set; }
    public Period period { get; set; }
    public int amount { get; set; }
    public bool isIncome { get; set; }
    public int userId { get; set; }
}

record SingularBudgetCreationDto
{
    public int amount { get; init; }
    public bool isIncome { get; init; }
    public DateTime creationDate { get; set; }
    public int userId { get; init; }
}

record GetPeriodDto
{
    public Period id { get; init; }
    public string title { get; init; }
}

interface IRegularBudgetRepo
{
    public void addItem(int userId, RegularBudgetCreationDto budgetItem);
    public List<IRegularBudgetItem> getExpenses(int userId);
    public List<IRegularBudgetItem> getIncomes(int userId);
}

interface ISingularBudgetRepo
{
    public void addItem(int userId, SingularBudgetCreationDto budgetItem);
    public int getMonthExpense(int userId, int month);
    public int getMonthIncome(int userId, int month);
}

interface IPeriodRepo
{
    public List<GetPeriodDto> getAllPeriods();
}
