namespace SoftStocksGUI
{
    partial class frmLogin
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
            chckSeePassword = new CheckBox();
            lblInvalid = new Label();
            btnLogin = new Button();
            inpPassword = new TextBox();
            inpUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            SuspendLayout();
            // 
            // chckSeePassword
            // 
            chckSeePassword.Appearance = Appearance.Button;
            chckSeePassword.AutoSize = true;
            chckSeePassword.FlatAppearance.BorderSize = 0;
            chckSeePassword.FlatStyle = FlatStyle.Flat;
            chckSeePassword.Image = Properties.Resources.eye_closed;
            chckSeePassword.Location = new Point(607, 117);
            chckSeePassword.Name = "chckSeePassword";
            chckSeePassword.Size = new Size(66, 66);
            chckSeePassword.TabIndex = 15;
            chckSeePassword.TextImageRelation = TextImageRelation.ImageAboveText;
            chckSeePassword.UseVisualStyleBackColor = true;
            chckSeePassword.CheckedChanged += chckSeePassword_CheckedChanged;
            // 
            // lblInvalid
            // 
            lblInvalid.Font = new Font("Verdana Pro", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvalid.ForeColor = Color.Red;
            lblInvalid.Location = new Point(0, 326);
            lblInvalid.Name = "lblInvalid";
            lblInvalid.Size = new Size(765, 35);
            lblInvalid.TabIndex = 14;
            lblInvalid.Text = "Bad Credentials";
            lblInvalid.TextAlign = ContentAlignment.MiddleCenter;
            lblInvalid.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(73, 221, 254);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Verdana Pro Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = Properties.Resources.login_arrow;
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(181, 220);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(390, 50);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // inpPassword
            // 
            inpPassword.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inpPassword.Location = new Point(352, 150);
            inpPassword.Name = "inpPassword";
            inpPassword.PasswordChar = '*';
            inpPassword.PlaceholderText = "Enter Password Here";
            inpPassword.Size = new Size(219, 35);
            inpPassword.TabIndex = 12;
            // 
            // inpUsername
            // 
            inpUsername.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inpUsername.Location = new Point(352, 101);
            inpUsername.Name = "inpUsername";
            inpUsername.PlaceholderText = "Enter Username Here";
            inpUsername.Size = new Size(219, 35);
            inpUsername.TabIndex = 11;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana Pro Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(181, 148);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(152, 35);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana Pro Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(181, 99);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(165, 35);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 89, 89);
            ClientSize = new Size(765, 450);
            Controls.Add(chckSeePassword);
            Controls.Add(lblInvalid);
            Controls.Add(btnLogin);
            Controls.Add(inpPassword);
            Controls.Add(inpUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chckSeePassword;
        private Label lblInvalid;
        private Button btnLogin;
        private TextBox inpPassword;
        private TextBox inpUsername;
        private Label lblPassword;
        private Label lblUsername;
    }
}