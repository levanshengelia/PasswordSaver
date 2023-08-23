namespace PasswordSaver.WinForms
{
    partial class AddAccountDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WebsiteTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            CommentTextBox = new TextBox();
            website = new Label();
            username = new Label();
            Password = new Label();
            comment = new Label();
            InstructionLabel = new Label();
            addAccountButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // WebsiteTextBox
            // 
            WebsiteTextBox.Location = new Point(124, 61);
            WebsiteTextBox.Name = "WebsiteTextBox";
            WebsiteTextBox.Size = new Size(247, 23);
            WebsiteTextBox.TabIndex = 0;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(124, 90);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(247, 23);
            UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(124, 119);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(247, 23);
            PasswordTextBox.TabIndex = 0;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // CommentTextBox
            // 
            CommentTextBox.Location = new Point(124, 148);
            CommentTextBox.Name = "CommentTextBox";
            CommentTextBox.Size = new Size(247, 23);
            CommentTextBox.TabIndex = 0;
            // 
            // website
            // 
            website.AutoSize = true;
            website.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            website.Location = new Point(21, 63);
            website.Name = "website";
            website.Size = new Size(70, 21);
            website.TabIndex = 1;
            website.Text = "Website";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(21, 92);
            username.Name = "username";
            username.Size = new Size(83, 21);
            username.TabIndex = 2;
            username.Text = "Username";
            // 
            // password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(21, 119);
            Password.Name = "password";
            Password.Size = new Size(79, 21);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // comment
            // 
            comment.AutoSize = true;
            comment.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comment.Location = new Point(21, 150);
            comment.Name = "comment";
            comment.Size = new Size(82, 21);
            comment.TabIndex = 4;
            comment.Text = "Comment";
            // 
            // InstructionLabel
            // 
            InstructionLabel.AutoSize = true;
            InstructionLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            InstructionLabel.Location = new Point(88, 22);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(217, 21);
            InstructionLabel.TabIndex = 5;
            InstructionLabel.Text = "Fill the fields to add account";
            // 
            // addAccountButton
            // 
            addAccountButton.BackColor = Color.GreenYellow;
            addAccountButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addAccountButton.Location = new Point(102, 186);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(194, 32);
            addAccountButton.TabIndex = 6;
            addAccountButton.Text = "Add Account";
            addAccountButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Tomato;
            cancelButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.Location = new Point(102, 232);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(194, 32);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // AddAccountDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 276);
            Controls.Add(cancelButton);
            Controls.Add(addAccountButton);
            Controls.Add(InstructionLabel);
            Controls.Add(comment);
            Controls.Add(Password);
            Controls.Add(username);
            Controls.Add(website);
            Controls.Add(CommentTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(WebsiteTextBox);
            Name = "AddAccountDialog";
            Text = "AddAccountDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WebsiteTextBox;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private TextBox CommentTextBox;
        private Label website;
        private Label username;
        private Label Password;
        private Label comment;
        private Label InstructionLabel;
        private Button addAccountButton;
        private Button cancelButton;
    }
}