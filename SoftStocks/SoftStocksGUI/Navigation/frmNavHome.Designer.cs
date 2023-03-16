namespace SoftStocksGUI
{
    partial class frmNavHome
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
            btnNavHome = new Button();
            btnNavClose = new Button();
            pnlNavSelect = new Panel();
            btnNavSupplier = new Button();
            btnNavTasks = new Button();
            btnNavReports = new Button();
            SuspendLayout();
            // 
            // btnNavHome
            // 
            btnNavHome.Dock = DockStyle.Top;
            btnNavHome.FlatAppearance.BorderSize = 0;
            btnNavHome.FlatStyle = FlatStyle.Flat;
            btnNavHome.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavHome.ForeColor = Color.White;
            btnNavHome.Image = Properties.Resources.home;
            btnNavHome.Location = new Point(0, 0);
            btnNavHome.Name = "btnNavHome";
            btnNavHome.Size = new Size(186, 75);
            btnNavHome.TabIndex = 0;
            btnNavHome.Text = "Home";
            btnNavHome.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNavHome.UseVisualStyleBackColor = false;
            btnNavHome.Click += btnNavHome_Click;
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
            pnlNavSelect.Location = new Point(27, 306);
            pnlNavSelect.Name = "pnlNavSelect";
            pnlNavSelect.Size = new Size(4, 75);
            pnlNavSelect.TabIndex = 4;
            pnlNavSelect.Visible = false;
            // 
            // btnNavSupplier
            // 
            btnNavSupplier.Dock = DockStyle.Top;
            btnNavSupplier.FlatAppearance.BorderSize = 0;
            btnNavSupplier.FlatStyle = FlatStyle.Flat;
            btnNavSupplier.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavSupplier.ForeColor = Color.White;
            btnNavSupplier.Image = Properties.Resources.edit;
            btnNavSupplier.Location = new Point(0, 75);
            btnNavSupplier.Name = "btnNavSupplier";
            btnNavSupplier.Size = new Size(186, 75);
            btnNavSupplier.TabIndex = 5;
            btnNavSupplier.Text = "Suppliers";
            btnNavSupplier.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNavSupplier.UseVisualStyleBackColor = false;
            btnNavSupplier.Click += btnNavSupplier_Click;
            // 
            // btnNavTasks
            // 
            btnNavTasks.Dock = DockStyle.Top;
            btnNavTasks.FlatAppearance.BorderSize = 0;
            btnNavTasks.FlatStyle = FlatStyle.Flat;
            btnNavTasks.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavTasks.ForeColor = Color.White;
            btnNavTasks.Image = Properties.Resources.advanced;
            btnNavTasks.Location = new Point(0, 150);
            btnNavTasks.Name = "btnNavTasks";
            btnNavTasks.Size = new Size(186, 75);
            btnNavTasks.TabIndex = 6;
            btnNavTasks.Text = "Tasks";
            btnNavTasks.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNavTasks.UseVisualStyleBackColor = false;
            btnNavTasks.Click += btnNavTasks_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.Dock = DockStyle.Top;
            btnNavReports.FlatAppearance.BorderSize = 0;
            btnNavReports.FlatStyle = FlatStyle.Flat;
            btnNavReports.Font = new Font("Verdana Pro Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavReports.ForeColor = Color.White;
            btnNavReports.Image = Properties.Resources.documents;
            btnNavReports.Location = new Point(0, 225);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(186, 75);
            btnNavReports.TabIndex = 7;
            btnNavReports.Text = "Reports";
            btnNavReports.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNavReports.UseVisualStyleBackColor = false;
            btnNavReports.Click += btnNavReports_Click;
            // 
            // frmNavHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 132, 132);
            ClientSize = new Size(186, 450);
            Controls.Add(pnlNavSelect);
            Controls.Add(btnNavReports);
            Controls.Add(btnNavTasks);
            Controls.Add(btnNavSupplier);
            Controls.Add(btnNavClose);
            Controls.Add(btnNavHome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNavHome";
            Text = "loginNavForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNavHome;
        private Button btnNavClose;
        private Panel pnlNavSelect;
        private Button btnNavSupplier;
        private Button btnNavTasks;
        private Button btnNavReports;
    }
}