
using PasswordSaver.Utilities;

namespace PasswordSaver.WinForms;
public partial class AddAccountDialog : Form
{

    private readonly Homepage homepage;
    private readonly string password;

    public AddAccountDialog(Homepage homepage, string password)
    {
        this.homepage = homepage;
        this.password = password;

        InitializeComponent();

        SetEventHandlers();
    }

    private void SetEventHandlers()
    {
        addAccountButton.Click += AddAccountButton_Clicked;
        cancelButton.Click += CancelButton_Clicked;
    }

    private void CancelButton_Clicked(object? sender, EventArgs e)
    {
        Close();
    }

    private void AddAccountButton_Clicked(object? sender, EventArgs e)
    {
        if (WebsiteTextBox.Text.Length == 0 || UsernameTextBox.Text.Length == 0 || PasswordTextBox.Text.Length == 0)
        {
            View.GiveFillOutAllFieldsWarning();
        } 
        else if (homepage.DoesWebsiteAlreadyExist(WebsiteTextBox.Text))
        {
            View.GiveWebsiteAlreadyExistsWarning();
            WebsiteTextBox.Text = string.Empty;
        }
        else if (PasswordTextBox.Text.Length < PasswordSaverConstants.MinimumPasswordLength)
        {
            View.GiveWeakPasswordWarning(PasswordSaverConstants.MinimumPasswordLength);
            PasswordTextBox.Text = string.Empty;
        }
        else
        {
            AddAccount();
        }
    }

    private void AddAccount()
    {
        homepage.AddAccount(WebsiteTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text, CommentTextBox.Text, password);
        Close();
    }
}