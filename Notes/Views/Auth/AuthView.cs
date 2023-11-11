using System;
using System.Data;
using System.Drawing.Imaging;
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
        ColorModeState.createInstance("dark");
        InitializeComponent();
        this.authService = new AuthService(new AuthXamppRepo());
        setLayoutTheme();
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
        }
        catch
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
        }
        catch
        {
            MessageBox.Show("Ошибка регистрации");
        }
    }

    private void setLayoutTheme()
    {
        var theme = ColorModeState.getInstance();

        this.BackColor = theme.bgPrimary;
        this.mainLabel.ForeColor = theme.textPrimary;
        this.loginLabel.ForeColor = theme.textSecondary;
        this.passwordLabel.ForeColor = theme.textSecondary;
        this.loginTextBox.BackColor = theme.bgSecondary;
        this.loginTextBox.ForeColor = theme.textSecondary;
        this.passwordTextBox.BackColor = theme.bgSecondary;
        this.passwordTextBox.ForeColor = theme.textSecondary;
        this.colorModeButton.ForeColor = theme.textSecondary;
    }

    private void colorModeButton_Click(object sender, EventArgs e)
    {
        var colorMode = ColorModeState.getInstance();

        colorMode.setColorMode(colorMode.mode == "dark" ? "light" : "dark");

        setLayoutTheme();
    }
}