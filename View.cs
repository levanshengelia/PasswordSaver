using PasswordSaver.Utilities;

namespace PasswordSaver
{
    internal class View
    {

        public static void GiveFillOutAllFieldsWarning()
        {
            MessageBox.Show(@"Please fill out all the fields");
        }

        public static void GiveWeakPasswordWarning(int minimumPasswordLength)
        {
            MessageBox.Show(@"Weak password. Your password must consist minimum " +
                            minimumPasswordLength + @" characters");
        }

        public static void GivePasswordsNotMatchWarning()
        {
            MessageBox.Show(@"Repeated Password didn't match");
        }

        internal static void GiveSuccessfulRegistrationNotification()
        {
            MessageBox.Show(@"Registration successful! Now you can login to your account");
        }

        public static void GiveUsernameAlreadyExistsWarning()
        {
            MessageBox.Show(@"This username already exists");
        }

        internal static void GiveIncorrectUsernameOrPasswordWarning()
        {
            MessageBox.Show(@"Username or password is incorrect");
        }

        public static void GiveInstructions()
        {
            MessageBox.Show(@"Select row to copy account's password");
        }

        public static void GiveSelectOnlyOneRowWarning()
        {
            MessageBox.Show(@"Select only one row");
        }

        public static void GiveWebsiteAlreadyExistsWarning()
        {
            MessageBox.Show(@"That website's account is already in the list");
        }

        public static string VerifyPassword(string masterPassword)
        {
            while (true)
            {
                var password = ShowInputDialog("Verify Password");

                if (SecurityUtils.GetHashValue(password) == masterPassword || password == string.Empty) return password;

                MessageBox.Show(@"Incorrect password");
            }
        }

        private static string ShowInputDialog(string title)
        {
            var size = new Size(300, 80);
            var inputBox = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = title
            };

            var textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5),
                UseSystemPasswordChar = true
            };
            inputBox.Controls.Add(textBox);

            var okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = @"OK",
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            var cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = @"Cancel",
                Location = new Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            inputBox.ShowDialog();

            return textBox.Text;
        }

        public static void GivePasswordCopiedNotification()
        {
            MessageBox.Show(@"Password copied");
        }
    }
}
