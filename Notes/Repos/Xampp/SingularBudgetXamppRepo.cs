using MySql.Data.MySqlClient;
using System.Data;
using Notes.Core.Budget;

namespace Notes.Repos;

class SingularBudgetXamppRepo : ISingularBudgetRepo
{
    private string connectParams = "datasource=127.0.0.1;port=3306;username=root;password=;database=karandash;";
    private MySqlConnection connection;

    public SingularBudgetXamppRepo()
    {
        connection = new MySqlConnection(connectParams);
    }

    public void addItem(int userId, SingularBudgetCreationDto dto)
    {
        connection.Open();
        string query = $"insert into SingularBudget (" +
            $"amount, isIncome, creationDate, userId" +
            $") values (" +
            $"{dto.amount}, '{dto.isIncome}', '{dto.creationDate.ToString("yyyy-MM-dd")}', {dto.userId})";
        var command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }
    public int getMonthExpense(int userId, int month)
    {
        connection.Open();
        string query = $"select sum(amount) as amount from SingularBudget where month(creationDate) = {month} and isIncome = False";
        var adapter = new MySqlDataAdapter(new MySqlCommand(query, connection));
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        try
        {
            return (int)ds.Tables[0].Rows[0]["amount"];
        }
        catch
        {
            return 0;
        }
    }

    public int getMonthIncome(int userId, int month)
    {
        connection.Open();
        string query = $"select sum(amount) as amount from SingularBudget where month(creationDate) = {month} and isIncome = True";
        var adapter = new MySqlDataAdapter(new MySqlCommand(query, connection));
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        try
        {
            return (int)ds.Tables[0].Rows[0]["amount"];
        }
        catch
        {
            return 0;
        }
    }
}