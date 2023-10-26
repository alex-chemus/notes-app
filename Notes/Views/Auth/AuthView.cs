using System;
using System.Data;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

using Notes.core.Auth;
using Notes.Repos.Xampp;

namespace Notes;

public partial class AuthView : Form
{
    private AuthService authService;

    public AuthView()
    {
        InitializeComponent();
        this.authService = new AuthService(new AuthXamppRepo());
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string login = loginTextBox.Text;
        string password = passwordTextBox.Text;

        try
        {
            int userId = authService.login(new UserCredsDto
            {
                login = login,
                password = password
            });
            UserState.createInstance(userId);
            new NotesView().Show();
            this.Hide();
        } catch
        {
            MessageBox.Show("Ошибка входа");
        }
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        string login = loginTextBox.Text;
        string password = passwordTextBox.Text;

        try
        {
            int userId = authService.register(new UserCredsDto
            {
                login = login,
                password = password
            });
            UserState.createInstance(userId);
            new NotesView().Show();
            this.Hide();
        } catch
        {
            MessageBox.Show("Ошибка регистрации");
        }
    }
}