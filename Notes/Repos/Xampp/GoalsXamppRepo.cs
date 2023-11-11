using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Notes.Core.Goals;

namespace Notes.Repos.Xampp;

class GoalsXamppRepo : IGoalRepo
{
    private string connectParams = "datasource=127.0.0.1;port=3306;username=root;password=;database=karandash;";
    private MySqlConnection connection;

    public GoalsXamppRepo()
    {
        connection = new MySqlConnection(connectParams);
    }

    public void addGoal(CreateGoalDto dto)
    {
        connection.Open();

        string query = $"insert into Goals(" +
            $"id, name, amount, deadline" +
            $") values (" +
            $"'{dto.id}', '{dto.name}', {dto.amount}, '{dto.deadline.ToString("yyyy-MM-dd")}')";

        MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }

    public Goal getById(int id)
    {
        connection.Open();

        string query = $"select * from Goals where id = {id}";

        var command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();

        return new Goal
        {
            id = (int)ds.Tables[0].Rows[0]["id"],
            name = ds.Tables[0].Rows[0]["name"].ToString(),
            amount = (int)ds.Tables[0].Rows[0]["amount"],
            deadline = ds.Tables[0].Rows[0]["deadline"].ToString()
        };
    }
}