using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class NewNoteForm : Form
    {
        private DbHelper db;

        public NewNoteForm()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        /*private void boldButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                if (richTextBox1.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    style |= FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }*/

        /*private void italicButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                if (richTextBox1.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic;
                }
                else
                {
                    style |= FontStyle.Italic;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }*/

        private void NewNoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private int insertNote()
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy.MM.dd";

            string title = titleTextBox.Text;
            string text = textBox.Text;
            string date = datePicker.Text;
            int userId = UserState.getInstance().id;

            string NewNoteQuery = $"INSERT INTO notes(" +
                $"`title`, `creationDate`, `noteText`, `userId`" +
                $") VALUES (" +
                $"\'{title}\', \'{date}\', \'{text}\', {userId})";

            return db.InsertRecord(NewNoteQuery);
        }

        private void insertCashbookRecord(int noteId)
        {
            int sum;
            if (Int32.TryParse(sumTextBox.Text, out sum))
            {
                datePicker.Format = DateTimePickerFormat.Custom;
                datePicker.CustomFormat = "yyyy.MM.dd";

                string NewCashbookRecordQuery = $"INSERT INTO cashBook(" +
                    $"`noteId`, `recordDate`, `isIncome`, `amount`" +
                    $") VALUES (" +
                    $"{noteId}, '{datePicker.Text}', {incomeCheckbox.Checked}, {sum})";
                db.InsertRecord(NewCashbookRecordQuery);
            }
            else
            {
                MessageBox.Show("Неверно введена сумма");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int noteId = insertNote();
            insertCashbookRecord(noteId);

            titleTextBox.Text = "";
            textBox.Text = "";
            datePicker.Text = "";

            MessageBox.Show("Заметка сохранена");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new NotesList().Show();
            this.Hide();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            new Calculator().Show();
        }
    }
}
