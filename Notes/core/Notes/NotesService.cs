namespace Notes.Core.Notes;

internal class NotesService
{
    private int userId;
    private INotesRepo notesRepo;

    public NotesService(int userId, INotesRepo notesRepo)
    {
        this.userId = userId;
        this.notesRepo = notesRepo;
    }

    public void addNote(AddNoteDto dto) => notesRepo.addNote(userId, dto);

    public List<NotesListItemDto> getListByDate(DateTime date) => notesRepo.getListByDate(userId, date);

    public INote getNoteById(int id) => notesRepo.getNoteById(userId, id);
}