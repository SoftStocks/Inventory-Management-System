namespace SoftStocksGUI
{
    partial class frmBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNavFrame = new Panel();
            pnlNavContent = new Panel();
            pnlProfile = new Panel();
            lblProfile = new Label();
            imgProfile = new PictureBox();
            panel3 = new Panel();
            btnLogout = new Button();
            lblBanner = new Label();
            pnlFormContent = new Panel();
            pnlNavFrame.SuspendLayout();
            pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProfile).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavFrame
            // 
            pnlNavFrame.BackColor = Color.FromArgb(146, 132, 132);
            pnlNavFrame.Controls.Add(pnlNavContent);
            pnlNavFrame.Controls.Add(pnlProfile);
            pnlNavFrame.Dock = DockStyle.Left;
            pnlNavFrame.Location = new Point(0, 0);
            pnlNavFrame.Name = "pnlNavFrame";
            pnlNavFrame.Size = new Size(186, 577);
            pnlNavFrame.TabIndex = 0;
            // 
            // pnlNavContent
            // 
            pnlNavContent.Dock = DockStyle.Fill;
            pnlNavContent.Location = new Point(0, 127);
            pnlNavContent.Name = "pnlNavContent";
            pnlNavContent.Size = new Size(186, 450);
            pnlNavContent.TabIndex = 7;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.FromArgb(27, 155, 183);
            pnlProfile.Controls.Add(lblProfile);
            pnlProfile.Controls.Add(imgProfile);
            pnlProfile.Dock = DockStyle.Top;
            pnlProfile.Location = new Point(0, 0);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(186, 127);
            pnlProfile.TabIndex = 0;
            // 
            // lblProfile
            // 
            lblProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfile.ForeColor = Color.White;
            lblProfile.Location = new Point(0, 90);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(186, 21);
            lblProfile.TabIndex = 1;
            lblProfile.Text = "Guest User";
            lblProfile.TextAlign = ContentAlignment.BottomCenter;
            // 
            // imgProfile
            // 
            imgProfile.Image = Properties.Resources.profile;
            imgProfile.Location = new Point(55, 12);
            imgProfile.Name = "imgProfile";
            imgProfile.Size = new Size(75, 75);
            imgProfile.SizeMode = PictureBoxSizeMode.AutoSize;
            imgProfile.TabIndex = 0;
            imgProfile.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 221, 254);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(lblBanner);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(186, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 127);
            panel3.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana Pro Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(626, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(0, 30, 0, 0);
            btnLogout.Size = new Size(139, 127);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblBanner
            // 
            lblBanner.Dock = DockStyle.Left;
            lblBanner.Font = new Font("Verdana Pro Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanner.ForeColor = Color.White;
            lblBanner.Location = new Point(0, 0);
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(620, 127);
            lblBanner.TabIndex = 0;
            lblBanner.Text = "Login / Authenticate";
            lblBanner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFormContent
            // 
            pnlFormContent.Dock = DockStyle.Fill;
            pnlFormContent.Location = new Point(186, 127);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(765, 450);
            pnlFormContent.TabIndex = 2;
            // 
            // frmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 89, 89);
            ClientSize = new Size(951, 577);
            Controls.Add(pnlFormContent);
            Controls.Add(panel3);
            Controls.Add(pnlNavFrame);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlNavFrame.ResumeLayout(false);
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgProfile).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNavFrame;
        private Panel pnlProfile;
        private PictureBox imgProfile;
        private Panel panel3;
        internal Label lblProfile;
        internal Panel pnlFormContent;
        internal Label lblBanner;
        internal Panel pnlNavContent;
        private Button btnLogout;
    }
}