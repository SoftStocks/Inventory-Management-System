namespace SoftStocksGUI
{
    partial class AddCredential
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            gdvCredentials = new DataGridView();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            credentialBindingSource = new BindingSource(components);
            btnSubmitCred = new Button();
            ((System.ComponentModel.ISupportInitialize)gdvCredentials).BeginInit();
            ((System.ComponentModel.ISupportInitialize)credentialBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 66);
            label1.Name = "label1";
            label1.Size = new Size(727, 106);
            label1.TabIndex = 0;
            label1.Text = "Add new credential";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 260);
            label2.Name = "label2";
            label2.Size = new Size(152, 41);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(355, 265);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 47);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 341);
            label3.Name = "label3";
            label3.Size = new Size(143, 41);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(355, 341);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 47);
            txtPassword.TabIndex = 4;
            // 
            // gdvCredentials
            // 
            gdvCredentials.AutoGenerateColumns = false;
            gdvCredentials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvCredentials.Columns.AddRange(new DataGridViewColumn[] { usernameDataGridViewTextBoxColumn, staffIdDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            gdvCredentials.DataSource = credentialBindingSource;
            gdvCredentials.Location = new Point(49, 437);
            gdvCredentials.Name = "gdvCredentials";
            gdvCredentials.RowHeadersWidth = 102;
            gdvCredentials.RowTemplate.Height = 49;
            gdvCredentials.Size = new Size(887, 231);
            gdvCredentials.TabIndex = 5;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 12;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.Width = 250;
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            staffIdDataGridViewTextBoxColumn.DataPropertyName = "StaffId";
            staffIdDataGridViewTextBoxColumn.HeaderText = "StaffId";
            staffIdDataGridViewTextBoxColumn.MinimumWidth = 12;
            staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            staffIdDataGridViewTextBoxColumn.Width = 250;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 12;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 250;
            // 
            // credentialBindingSource
            // 
            credentialBindingSource.DataSource = typeof(SoftStocksData.Credential);
            // 
            // btnSubmitCred
            // 
            btnSubmitCred.Location = new Point(723, 338);
            btnSubmitCred.Name = "btnSubmitCred";
            btnSubmitCred.Size = new Size(188, 58);
            btnSubmitCred.TabIndex = 6;
            btnSubmitCred.Text = "Add";
            btnSubmitCred.UseVisualStyleBackColor = true;
            btnSubmitCred.Click += btnSubmitCred_Click;
            // 
            // AddCredential
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 680);
            Controls.Add(btnSubmitCred);
            Controls.Add(gdvCredentials);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCredential";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add credentials";
            ((System.ComponentModel.ISupportInitialize)gdvCredentials).EndInit();
            ((System.ComponentModel.ISupportInitialize)credentialBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private DataGridView gdvCredentials;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource credentialBindingSource;
        private Button btnSubmitCred;
    }
}