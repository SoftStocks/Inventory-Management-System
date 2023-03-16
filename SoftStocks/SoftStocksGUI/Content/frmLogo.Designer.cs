namespace SoftStocksGUI.Content
{
    partial class frmLogo
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
            pbLogo = new PictureBox();
            lblLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.backpack;
            pbLogo.Location = new Point(177, 143);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(169, 153);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Verdana Pro Light", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(352, 136);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(241, 160);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Soft\r\nStocks";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 89, 89);
            ClientSize = new Size(765, 450);
            Controls.Add(pbLogo);
            Controls.Add(lblLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogo";
            Text = "frmLogo";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblLogo;
    }
}