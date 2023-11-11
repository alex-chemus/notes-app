using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Notes.Repos;
using Notes.Core.Notes;

namespace Notes;

public partial class NotesView : Form
{
    private DateTime dateStart;
    private NotesXamppRepo notesXamppRepo;
    private NotesService notesService;

    public NotesView()
    {
        InitializeComponent();
        dateStart = DateTime.Now;

        notesXamppRepo = new NotesXamppRepo();
        notesService = new NotesService(UserState.getInstance().id, notesXamppRepo);

        notesListView.Visible = false;
        noteLayoutPanel.Visible = false;

        setLayoutTheme();
    }

    private void NotesList_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void calendar_DateChanged(object sender, DateRangeEventArgs e)
    {
        dateStart = e.Start;
    }

    private void showNotesButton_Click(object sender, EventArgs e)
    {
        notesListView.Visible = true;

        var notes = notesService.getListByDate(dateStart);

        foreach (var note in notes)
        {
            var item = new ListViewItem(note.title);
            item.Tag = note.id;
            notesListView.Items.Add(item);
        }
    }

    private void notesListView_MouseClick(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < notesListView.Items.Count; i++)
        {
            var rectangle = notesListView.GetItemRect(i);
            if (rectangle.Contains(e.Location))
            {
                int noteId = (int)notesListView.Items[i].Tag;

                var note = notesService.getNoteById(noteId);

                noteLayoutPanel.Visible = true;

                titleLabel.Text = note.title;
                dateLabel.Text = note.date.ToString("dd.MM.yyyy");
                noteTextLabel.Text = note.text;

                return;
            }
        }
    }

    private void budgetButton_Click(object sender, EventArgs e)
    {
        new BudgetView().Show();
        Hide();
    }

    private void createNoteButton_Click(object sender, EventArgs e)
    {
        string title = titleTextBox.Text;
        DateTime date = datePicker.Value;
        string text = noteTextBox.Text;

        if (title == "" || text == "") MessageBox.Show("Неправильно введены поля");
        else
        {
            notesService.addNote(new AddNoteDto
            {
                title = title,
                date = date,
                text = text,
                userId = UserState.getInstance().id
            });
            MessageBox.Show("Заметка добавлена");
            titleTextBox.Text = "";
            noteTextBox.Text = "";
        }
    }

    private void setLayoutTheme()
    {
        var theme = ColorModeState.getInstance();

        this.BackColor = theme.bgPrimary;
        this.colorModeButton.ForeColor = theme.textPrimary;
        this.notesListView.BackColor = theme.bgSecondary;
        this.notesListView.ForeColor = theme.textPrimary;
        this.titleLabel.ForeColor = theme.textPrimary;
        this.dateLabel.ForeColor = theme.textSecondary;
        this.noteTextLabel.ForeColor = theme.textSecondary;
        this.titleFormLabel.ForeColor = theme.textSecondary;
        this.dateFormLabel.ForeColor = theme.textSecondary;
        this.titleTextBox.BackColor = theme.bgSecondary;
        this.titleTextBox.ForeColor = theme.textSecondary;
        this.noteTextBox.BackColor = theme.bgSecondary;
        this.noteTextBox.ForeColor = theme.textSecondary;
    }

    private void colorModeButton_Click(object sender, EventArgs e)
    {
        var colorMode = ColorModeState.getInstance();

        colorMode.setColorMode(colorMode.mode == "dark" ? "light" : "dark");

        setLayoutTheme();
    }

    private void openCalcNote_Click(object sender, EventArgs e)
    {
        new CalculatorView().Show();
    }
}
