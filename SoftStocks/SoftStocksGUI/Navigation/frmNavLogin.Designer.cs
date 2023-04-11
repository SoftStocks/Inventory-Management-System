namespace SoftStocksGUI
{
    partial class frmNavLogin
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
            btnNavLogin = new Button();
            btnNavClose = new Button();
            pnlNavSelect = new Panel();
            SuspendLayout();
            // 
            // btnNavLogin
            // 
            btnNavLogin.Dock = DockStyle.Top;
            btnNavLogin.FlatAppearance.BorderSize = 0;
            btnNavLogin.FlatStyle = FlatStyle.Flat;
            btnNavLogin.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavLogin.ForeColor = Color.White;
            btnNavLogin.Image = Properties.Resources._lock;
            btnNavLogin.Location = new Point(0, 0);
            btnNavLogin.Name = "btnNavLogin";
            btnNavLogin.Size = new Size(186, 75);
            btnNavLogin.TabIndex = 0;
            btnNavLogin.Text = "Login";
            btnNavLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNavLogin.UseVisualStyleBackColor = false;
            btnNavLogin.Click += btnNavLogin_Click;
            // 
            // btnNavClose
            // 
            btnNavClose.Dock = DockStyle.Bottom;
            btnNavClose.FlatAppearance.BorderSize = 0;
            btnNavClose.FlatStyle = FlatStyle.Flat;
            btnNavClose.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavClose.ForeColor = Color.White;
            btnNavClose.Image = Properties.Resources.close;
            btnNavClose.Location = new Point(0, 375);
            btnNavClose.Name = "btnNavClose";
            btnNavClose.Size = new Size(186, 75);
            btnNavClose.TabIndex = 1;
            btnNavClose.Text = "Close";
            btnNavClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNavClose.UseVisualStyleBackColor = true;
            btnNavClose.Click += btnNavClose_Click;
            // 
            // pnlNavSelect
            // 
            pnlNavSelect.BackColor = Color.White;
            pnlNavSelect.Location = new Point(91, 188);
            pnlNavSelect.Name = "pnlNavSelect";
            pnlNavSelect.Size = new Size(4, 75);
            pnlNavSelect.TabIndex = 4;
            pnlNavSelect.Visible = false;
            // 
            // frmNavLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 132, 132);
            ClientSize = new Size(186, 450);
            Controls.Add(pnlNavSelect);
            Controls.Add(btnNavClose);
            Controls.Add(btnNavLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNavLogin";
            Text = "loginNavForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNavLogin;
        private Button btnNavClose;
        private Panel pnlNavSelect;
    }
}