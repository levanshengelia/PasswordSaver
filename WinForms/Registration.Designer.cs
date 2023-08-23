namespace PasswordSaver.WinForms
{
    partial class Registration
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
            loginButton = new Button();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            registrationButton = new Button();
            repeatPasswordLabel = new Label();
            repeatPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(147, 372);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(181, 63);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Cursor = Cursors.IBeam;
            usernameTextBox.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(218, 35);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(220, 38);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(77, 38);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(106, 25);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(77, 117);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(102, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Cursor = Cursors.IBeam;
            passwordTextBox.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(218, 114);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(220, 38);
            passwordTextBox.TabIndex = 3;
            // 
            // registrationButton
            // 
            registrationButton.Cursor = Cursors.Hand;
            registrationButton.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            registrationButton.Location = new Point(147, 276);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(181, 63);
            registrationButton.TabIndex = 5;
            registrationButton.Text = "Registration";
            registrationButton.UseVisualStyleBackColor = true;
            // 
            // repeatPasswordLabel
            // 
            repeatPasswordLabel.AutoSize = true;
            repeatPasswordLabel.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            repeatPasswordLabel.Location = new Point(40, 193);
            repeatPasswordLabel.Name = "repeatPasswordLabel";
            repeatPasswordLabel.Size = new Size(172, 25);
            repeatPasswordLabel.TabIndex = 7;
            repeatPasswordLabel.Text = "Repeat Password";
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Cursor = Cursors.IBeam;
            repeatPasswordTextBox.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            repeatPasswordTextBox.Location = new Point(218, 190);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(220, 38);
            repeatPasswordTextBox.TabIndex = 6;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 470);
            Controls.Add(repeatPasswordLabel);
            Controls.Add(repeatPasswordTextBox);
            Controls.Add(registrationButton);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button loginButton;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button registrationButton;

        #endregion

        private Label repeatPasswordLabel;
        private TextBox repeatPasswordTextBox;
    }
}