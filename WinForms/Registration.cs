using PasswordSaver.Utilities;

namespace PasswordSaver.WinForms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            ConfigureEventHandlers();
        }

        private void ConfigureEventHandlers()
        {
            loginButton.Click += LoginButton_Clicked;
            registrationButton.Click += RegistrationButton_Clicked;

            passwordTextBox.UseSystemPasswordChar = true;
            repeatPasswordTextBox.UseSystemPasswordChar = true;

            registrationButton.Select();
        }

        private void RegistrationButton_Clicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(repeatPasswordTextBox.Text))
            {
                View.GiveFillOutAllFieldsWarning();
            } 
            else if (JsonManager.GetUser(usernameTextBox.Text, passwordTextBox.Text) != null)
            {
                View.GiveUsernameAlreadyExistsWarning();

                usernameTextBox.Text = string.Empty;
            }
            else if (passwordTextBox.Text.Length < PasswordSaverConstants.MinimumPasswordLength)
            {
                View.GiveWeakPasswordWarning(PasswordSaverConstants.MinimumPasswordLength);
            } 
            else if (passwordTextBox.Text != repeatPasswordTextBox.Text)
            {
                View.GivePasswordsNotMatchWarning();

                repeatPasswordTextBox.Text = "";
            }
            else
            {
                View.GiveSuccessfulRegistrationNotification();
                
                JsonManager.AddUser(usernameTextBox.Text, passwordTextBox.Text);

                LoginButton_Clicked(sender, e);
            }
        }

        private void LoginButton_Clicked(object? sender, EventArgs e)
        {
            Hide();

            new Login().Show();
        }
    }
}
