using MySql.Data.MySqlClient;
using System.Data;
using Notes.Core.Budget;
using System.Diagnostics.Metrics;
using System.Reflection;

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
        var command = new MySqlCommand(query, connection);

        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);

        connection.Close();

        var resultRow = ds.Tables[0].Rows[0];

        return resultRow["amount"] != DBNull.Value ? Decimal.ToInt32((decimal)ds.Tables[0].Rows[0]["amount"]) : 0;
    }

    public int getMonthIncome(int userId, int month)
    {
        connection.Open();
        string query = $"select sum(amount) as amount from SingularBudget where month(creationDate) = {month} and isIncome = True";
        var command = new MySqlCommand(query, connection);

        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);

        connection.Close();

        var resultRow = ds.Tables[0].Rows[0];

        return resultRow["amount"] != DBNull.Value ? Decimal.ToInt32((decimal)ds.Tables[0].Rows[0]["amount"]) : 0;
    }
}