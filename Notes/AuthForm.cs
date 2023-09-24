using System;
using System.Data;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace Notes
{
    public partial class AuthForm : Form
    {
        private DbHelper db;

        public AuthForm()
        {
            InitializeComponent();
            db = new DbHelper();
        }

        private void SetUserId(string login, string password)
        {
            string getUserQuery = "SELECT * FROM users WHERE `login` = '" + login + "' AND `password` = '" + password + "'";
            DataRow record = db.getSignelRecord(getUserQuery);
            UserState.createInstance((int)record["id"]);
        }

        private void OpenNotesList()
        {
            new NotesList().Show();
            this.Hide();
        }

        private void RegisterUser(string login, string password)
        {
            string CheckLoginQuery = "SELECT * FROM users WHERE `login` = '" + login + "'";

            string CheckPasswordQuery = "SELECT * FROM users WHERE `password` = '" + password + "'";

            if (db.CountRecords(CheckLoginQuery) == 0 && db.CountRecords(CheckPasswordQuery) == 0)
            {
                string createUserQuery = "INSERT INTO users(`login`, `password`) VALUES ('" + login + "', '" + password + "')";

                db.InsertRecord(createUserQuery);
                SetUserId(login, password);
                OpenNotesList();
            }
            else
            {
                MessageBox.Show("Логин или пароль уже используются");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            string userExistsQuery = "SELECT * FROM users WHERE `login` = '" + login + "' AND `password` = '" + password + "'";

            if (db.CountRecords(userExistsQuery) > 0)
            {
                SetUserId(login, password);
                OpenNotesList();
            }
            else
            {
                RegisterUser(login, password);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}