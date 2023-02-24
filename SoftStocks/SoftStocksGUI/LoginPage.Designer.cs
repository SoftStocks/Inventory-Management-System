namespace SoftStocksGUI
{
    partial class LoginPage
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            cbShowPassword = new CheckBox();
            lblInvalidMessage = new Label();
            btnSubmitLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 74);
            label1.Name = "label1";
            label1.Size = new Size(412, 106);
            label1.TabIndex = 0;
            label1.Text = "SoftStocks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 267);
            label2.Name = "label2";
            label2.Size = new Size(152, 41);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(310, 265);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(627, 47);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 393);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(627, 47);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 393);
            label3.Name = "label3";
            label3.Size = new Size(143, 41);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(673, 473);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(264, 45);
            cbShowPassword.TabIndex = 5;
            cbShowPassword.Text = "Show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // lblInvalidMessage
            // 
            lblInvalidMessage.AutoSize = true;
            lblInvalidMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInvalidMessage.ForeColor = Color.IndianRed;
            lblInvalidMessage.Location = new Point(108, 540);
            lblInvalidMessage.Name = "lblInvalidMessage";
            lblInvalidMessage.Size = new Size(829, 41);
            lblInvalidMessage.TabIndex = 6;
            lblInvalidMessage.Text = "Invalid username or password. Please check your credentials";
            lblInvalidMessage.Visible = false;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.Location = new Point(749, 594);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(188, 58);
            btnSubmitLogin.TabIndex = 7;
            btnSubmitLogin.Text = "Login";
            btnSubmitLogin.UseVisualStyleBackColor = true;
            btnSubmitLogin.Click += btnSubmitLogin_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 680);
            Controls.Add(btnSubmitLogin);
            Controls.Add(lblInvalidMessage);
            Controls.Add(cbShowPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoftStocks Inventory Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private CheckBox cbShowPassword;
        private Label lblInvalidMessage;
        private Button btnSubmitLogin;
    }
}