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
    public partial class NoteView : Form
    {
        private DbHelper db;

        public NoteView(int id)
        {
            InitializeComponent();

            this.db = new DbHelper();

            string query = $"SELECT * FROM notes WHERE `id` = '{id}'";

            DataRow note = db.getSignelRecord(query);

            title.Text = note["title"].ToString();
            date.Text = note["creationDate"].ToString();
            textBox.Text = note["noteText"].ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new NotesList().Show();
            this.Hide();
        }
    }
}
