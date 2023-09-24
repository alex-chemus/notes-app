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
    public partial class NotesList : Form
    {
        private DbHelper db;
        private DateTime dateStart;
        private DateTime dateEnd;

        public NotesList()
        {
            InitializeComponent();
            dateStart = DateTime.Now;
            dateEnd = DateTime.Now;
            db = new DbHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewNoteForm().Show();
            this.Hide();
        }

        private void NotesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateStart = e.Start;
            dateEnd = e.End;
        }

        private void showNotesButton_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM notes WHERE " +
                $"`creationDate` >= \"{dateStart.ToString("yyyy-MM-dd")}\"AND " +
                $"`creationDate` <= \"{dateEnd.ToString("yyyy-MM-dd")}\"";
            DataTable notesTable = db.getRecords(query);

            notesListView.Items.Clear();
            foreach (DataRow row in notesTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["title"].ToString());
                item.Tag = (int)row["id"];
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
                    new NoteView((int)notesListView.Items[i].Tag).Show();
                    this.Hide();
                    return;
                }
            }
        }
    }
}
