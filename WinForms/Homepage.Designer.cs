namespace PasswordSaver.WinForms
{
    partial class Homepage
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
            accountGrid = new DataGridView();
            Application = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            addButton = new Button();
            copyPasswordButton = new Button();
            copyPasswordAndQuitButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)accountGrid).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.SpringGreen;
            addButton.Cursor = Cursors.Hand;
            addButton.Dock = DockStyle.Bottom;
            addButton.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(0, 391);
            addButton.Name = "addButton";
            addButton.Size = new Size(775, 38);
            addButton.TabIndex = 1;
            addButton.Text = "Add Account";
            addButton.UseVisualStyleBackColor = false;
            // 
            // copyPasswordButton
            // 
            copyPasswordButton.AutoSize = true;
            copyPasswordButton.BackColor = Color.Lavender;
            copyPasswordButton.Cursor = Cursors.Hand;
            copyPasswordButton.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            copyPasswordButton.Location = new Point(0, 355);
            copyPasswordButton.Name = "copyPasswordButton";
            copyPasswordButton.Size = new Size(236, 39);
            copyPasswordButton.TabIndex = 2;
            copyPasswordButton.Text = "Copy Password";
            copyPasswordButton.UseVisualStyleBackColor = false;
            copyPasswordButton.Visible = false;
            // 
            // copyPasswordAndQuitButton
            // 
            copyPasswordAndQuitButton.AutoSize = true;
            copyPasswordAndQuitButton.BackColor = Color.Lavender;
            copyPasswordAndQuitButton.Cursor = Cursors.Hand;
            copyPasswordAndQuitButton.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            copyPasswordAndQuitButton.Location = new Point(232, 355);
            copyPasswordAndQuitButton.Name = "copyPasswordAndQuitButton";
            copyPasswordAndQuitButton.Size = new Size(304, 39);
            copyPasswordAndQuitButton.TabIndex = 3;
            copyPasswordAndQuitButton.Text = "Copy Password and Quit";
            copyPasswordAndQuitButton.UseVisualStyleBackColor = false;
            copyPasswordAndQuitButton.Visible = false;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = Color.OrangeRed;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(535, 355);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(240, 39);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete Account";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            // 
            // accountGrid
            // 
            accountGrid.AllowUserToAddRows = false;
            accountGrid.AllowUserToDeleteRows = false;
            accountGrid.AllowUserToResizeColumns = false;
            accountGrid.AllowUserToResizeRows = false;
            accountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountGrid.Columns.AddRange(new DataGridViewColumn[] { Application, Username, Comment });
            accountGrid.Dock = DockStyle.Top;
            accountGrid.Location = new Point(0, 0);
            accountGrid.Name = "accountGrid";
            accountGrid.RowTemplate.Height = 25;
            accountGrid.Size = new Size(775, 357);
            accountGrid.TabIndex = 0;
            // 
            // Application
            // 
            Application.HeaderText = "Application";
            Application.Name = "Application";
            Application.Width = 244;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.Width = 244;
            // 
            // Comment
            // 
            Comment.HeaderText = "Comment";
            Comment.Name = "Comment";
            Comment.Width = 244;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 429);
            Controls.Add(deleteButton);
            Controls.Add(copyPasswordAndQuitButton);
            Controls.Add(copyPasswordButton);
            Controls.Add(addButton);
            Controls.Add(accountGrid);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Homepage";
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)accountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView accountGrid;
        private DataGridViewTextBoxColumn Application;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Comment;
        private Button addButton;
        private Button copyPasswordButton;
        private Button copyPasswordAndQuitButton;
        private Button deleteButton;
    }
}