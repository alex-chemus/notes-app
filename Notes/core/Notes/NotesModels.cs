namespace Notes.Core.Notes;

interface INote
{
    public int id { get; set; }
    public string title { get; set; }
    public DateTime date { get; set; }
    public string text { get; set; }
    public int userId { get; set; }
}

record Note : INote
{
    public int id { get; set; }
    public string title { get; set; }
    public DateTime date { get; set; }
    public string text { get; set; }
    public int userId { get; set; }
}

record AddNoteDto
{
    public string title { get; init; }
    public DateTime date { get; init; }
    public string text { get; init; }
    public int userId { get; init; }
}

record NotesListItemDto
{
    public int id { get; init; }
    public string title { get; init; }
    public int userId { get; init; }

}

interface INotesRepo
{
    public void addNote(int userId, AddNoteDto note);
    public List<NotesListItemDto> getListByDate(int userId, DateTime date);
    public INote getNoteById(int userId, int noteId);
}