using PasswordSaver.Models;
using PasswordSaver.Utilities;

namespace PasswordSaver.WinForms;

public partial class Homepage : Form
{

    private readonly string _username;
    private readonly string _password;
    private User User => JsonManager.GetUser(_username, _password) ?? throw new NullReferenceException();

    private Thread? clipboardClearThread;

    public Homepage(string username, string password)
    {
        _username = username;
        _password = password;

        InitializeComponent();

        SetEventHandlers();

        AddExistingAccountsInGrid();
    }

    private void AddExistingAccountsInGrid()
    {
        User.Accounts.ForEach(x => accountGrid.Rows.Add(x.Website, x.Username, x.Comment));
    }

    private void SetEventHandlers()
    {
        Shown += Application_Opened;
        accountGrid.SelectionChanged += AccountGrid_SelectionChanged;
        addButton.Click += AddButton_Clicked;
        deleteButton.Click += DeleteButton_Clicked;
        copyPasswordButton.Click += CopyPasswordButton_Clicked;
        copyPasswordAndQuitButton.Click += CopyPasswordAndQuitButton_Clicked;
    }

    private void CopyPasswordAndQuitButton_Clicked(object? sender, EventArgs e)
    {
        CopyPasswordButton_Clicked(sender, e);

        Hide();

        if (clipboardClearThread is { IsAlive: true })
        {
            clipboardClearThread.Join();
        }

        Close();
    }

    private void CopyPasswordButton_Clicked(object? sender, EventArgs e)
    {
        var verifiedPassword = View.VerifyPassword(User.Password);

        if (verifiedPassword == string.Empty)
        {
            return;
        }

        var encryptedPassword = JsonManager.GetUsersAccountPassword(User.Username, (string)accountGrid.SelectedRows[0].Cells[0].Value);

        var realPassword = SecurityUtils.Decrypt(encryptedPassword, verifiedPassword);

        Clipboard.SetText(realPassword);
        View.GivePasswordCopiedNotification();

        clipboardClearThread = new Thread(ClearClipboardAfterTimeout);
        clipboardClearThread.SetApartmentState(ApartmentState.STA);

        clipboardClearThread.Start();
    }

    private static void ClearClipboardAfterTimeout()
    {
        Thread.Sleep(PasswordSaverConstants.ClipboardDurationInSeconds * 1000);

        Clipboard.Clear();
    }

    private void DeleteButton_Clicked(object? sender, EventArgs e)
    {

        var verifiedPassword = View.VerifyPassword(User.Password);

        if (verifiedPassword == string.Empty)
        {
            return;
        }

        JsonManager.DeleteAccount(User.Username, accountGrid);

        DisableEnableButtons(false);
    }

    private void DisableEnableButtons(bool onOff)
    {
        copyPasswordButton.Visible = onOff;
        copyPasswordAndQuitButton.Visible = onOff;
        deleteButton.Visible = onOff;
    }

    private void AddButton_Clicked(object? sender, EventArgs e)
    {
        var verifiedPassword = View.VerifyPassword(User.Password);

        if (verifiedPassword == string.Empty)
        {
            return;
        }

        var addAccountForm = new AddAccountDialog(this, verifiedPassword);
        addAccountForm.ShowDialog();
    }

    private void AccountGrid_SelectionChanged(object? sender, EventArgs e)
    {
        var selectedRows = accountGrid.SelectedRows;

        switch (selectedRows.Count)
        {
            case > 1:
                DisableEnableButtons(false);
                View.GiveSelectOnlyOneRowWarning();
                break;
            case 1:
                DisableEnableButtons(true);
                break;
            default:
                DisableEnableButtons(false);
                break;
        }
    }

    private static void Application_Opened(object? sender, EventArgs e)
    {
        GiveInstructions();
    }

    private static void GiveInstructions()
    {
        View.GiveInstructions();
    }

    internal void AddAccount(string website, string username, string password, string comment, string masterPassword)
    {
        var account = new Account(website, username, SecurityUtils.Encrypt(password, masterPassword), comment);

        JsonManager.AddUserAccount(User.Username, account);

        accountGrid.Rows.Add(website, username, comment);
    }

    internal bool DoesWebsiteAlreadyExist(string website)
    {
        return User.Accounts.Any(x => x.Website == website);
    }
}