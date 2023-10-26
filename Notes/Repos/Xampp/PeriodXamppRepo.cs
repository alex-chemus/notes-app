using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using Notes.Core.Budget;

namespace Notes.Repos.Xampp;

internal class PeriodXamppRepo : IPeriodRepo
{
    private string connectParams = "datasource=127.0.0.1;port=3306;username=root;password=;database=karandash;";
    private MySqlConnection connection;

    public PeriodXamppRepo()
    {
        connection = new MySqlConnection(connectParams);
    }

    public List<GetPeriodDto> getAllPeriods()
    {
        var periods = new List<GetPeriodDto>();

        string query = "select * from Periods";
        connection.Open();
        MySqlCommand command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();

        foreach (DataRow item in ds.Tables[0].Rows)
        {
            periods.Add(new GetPeriodDto
            {
                id = (Period)item["id"],
                title = (string)item["title"],
            });
        }

        return periods;
    }
}

