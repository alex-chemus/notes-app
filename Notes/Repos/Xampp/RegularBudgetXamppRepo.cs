using MySql.Data.MySqlClient;
using System.Data;
using Notes.Core.Budget;

namespace Notes.Repos;

class RegularBudgetXamppRepo : IRegularBudgetRepo
{
    private string connectParams = "datasource=127.0.0.1;port=3306;username=root;password=;database=karandash;";
    private MySqlConnection connection;

    public RegularBudgetXamppRepo()
    {
        connection = new MySqlConnection(connectParams);
    }
    public void addItem(int userId, RegularBudgetCreationDto dto)
    {
        connection.Open();
        string query = $"insert into RegularBudget (" +
            $"amount, isIncome, period, userId" +
            $") values (" +
            $"{dto.amount}, {dto.isIncome}, {(int)dto.period}, {dto.userId})";
        var command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }

    public List<IRegularBudgetItem> getExpenses(int userId)
    {
        connection.Open();
        string query = $"select * from RegularBudget where isIncome = False";
        var adapter = new MySqlDataAdapter(new MySqlCommand(query, connection));
        var ds = new DataSet();
        adapter.Fill(ds);

        var expenses = new List<IRegularBudgetItem>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            expenses.Add(new RegularBudgetItem
            {
                amount = (int)row["amount"],
                id = (int)row["id"],
                isIncome = (bool)row["isIncome"],
                period = (Period)row["period"],
                userId = (int)row["userId"]
            });
        }

        connection.Close();

        return expenses;
    }

    public List<IRegularBudgetItem> getIncomes(int userId)
    {
        connection.Open();
        string query = $"select * from RegularBudget where isIncome = True";
        var adapter = new MySqlDataAdapter(new MySqlCommand(query, connection));
        var ds = new DataSet();
        adapter.Fill(ds);

        var incomes = new List<IRegularBudgetItem>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            incomes.Add(new RegularBudgetItem
            {
                amount = (int)row["amount"],
                id = (int)row["id"],
                isIncome = (bool)row["isIncome"],
                period = (Period)row["period"],
                userId = (int)row["userId"]
            });
        }

        connection.Close();

        return incomes;
    }
}