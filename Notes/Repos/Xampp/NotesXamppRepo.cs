using Notes.Core.Notes;
using MySql.Data.MySqlClient;
using System.Data;

namespace Notes.Repos;

class NotesXamppRepo : INotesRepo
{
    private string connectParams = "datasource=127.0.0.1;port=3306;username=root;password=;database=karandash;";
    private MySqlConnection connection;

    public NotesXamppRepo()
    {
        connection = new MySqlConnection(connectParams);
    }

    public void addNote(int userId, AddNoteDto dto)
    {
        connection.Open();
        string query = $"insert into Notes(" +
            $"title, creationDate, noteText, userId" +
            $") values (" +
            $"'{dto.title}', '{dto.date.ToString("yyyy-MM-dd")}', '{dto.text}', '{dto.userId}')";
        MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }

    public List<NotesListItemDto> getListByDate(int userId, DateTime date)
    {
        string formattedDate = date.ToString("yyyy-MM-dd");
        connection.Open();
        string query = $"select * from Notes where creationDate = '{formattedDate}'";
        var command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();

        var notesList =  new List<NotesListItemDto>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            notesList.Add(new NotesListItemDto
            {
                id = (int)row["id"],
                title = (string)row["title"],
                userId = (int)row["userId"]
            });
        }

        return notesList;
    }

    public INote getNoteById(int userId, int noteId)
    {
        connection.Open();
        string query = $"select * from Notes where id = {noteId}";
        var command = new MySqlCommand(query, connection);
        var adapter = new MySqlDataAdapter(command);
        var ds = new DataSet();
        adapter.Fill(ds);
        DataRow row = ds.Tables[0].Rows[0];
        connection.Close();

        return new Note
        {
            id = (int)row["id"],
            title = (string)row["title"],
            date = DateTime.Parse(row["creationDate"].ToString()),
            text = (string)row["noteText"],
            userId = (int)row["userId"]
        };
    }
}