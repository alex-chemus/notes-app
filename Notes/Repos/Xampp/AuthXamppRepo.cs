using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Notes.core.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Repos.Xampp;

class AuthXamppRepo : IAuthRepo
{
    private string connectParams = "datasource=127.0.0.1;port=3306;username=root;password=;database=karandash;";
    private MySqlConnection connection;

    public AuthXamppRepo()
    {
        connection = new MySqlConnection(connectParams);
    }

    public bool loginInUse(string login)
    {
        connection.Open();
        string query = $"select * from users where login = '{login}'";
        var command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        return ds.Tables[0].Rows.Count != 0;
    }

    public bool passwordInUse(string password)
    {
        connection.Open();
        string query = $"select * from users where password = '{password}'";
        var command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        return ds.Tables[0].Rows.Count != 0;
    }

    public bool validateCreds(UserCredsDto dto)
    {
        connection.Open();
        string query = $"select * from users where login = '{dto.login}' and password = '{dto.password}'";
        var command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        return ds.Tables[0].Rows.Count != 0;
    }

    public void createUser(UserCredsDto dto)
    {
        connection.Open();

        string query = $"insert into Users(" +
            $"login, password" +
            $") values (" +
            $"'{dto.login}', {dto.password})";
        MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }

    public int getIdByCreds(UserCredsDto dto)
    {
        connection.Open();
        string query = $"select * from users where login = '{dto.login}' and password = '{dto.password}'";
        var command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        return (int)ds.Tables[0].Rows[0]["id"];
    }
}
