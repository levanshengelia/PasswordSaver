using PasswordSaver.Utilities;

namespace PasswordSaver.WinForms;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();

        ConfigureEventHandlers();
    }

    private void ConfigureEventHandlers()
    {
        registrationButton.Click += RegistrationButton_Clicked;
        loginButton.Click += LoginButton_Clicked;

        passwordTextBox.UseSystemPasswordChar = true;
    }

    private void LoginButton_Clicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
        {
            View.GiveFillOutAllFieldsWarning();
        } else if (JsonManager.GetUser(usernameTextBox.Text, passwordTextBox.Text, false) == null)
        {
            View.GiveIncorrectUsernameOrPasswordWarning();
        }
        else
        {
            LoginUser();
        }
            
    }

    private void LoginUser()
    {
        Hide();

        var user = JsonManager.GetUser(usernameTextBox.Text, passwordTextBox.Text, false) ?? throw new NullReferenceException();
            
        new Homepage(user.Username, user.Password).Show();
    }

    private void RegistrationButton_Clicked(object? sender, EventArgs e)
    {
        Hide();

        new Registration().Show();
    }
}