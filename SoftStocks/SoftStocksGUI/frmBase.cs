using SoftStocksData;
using SoftStocksGUI.Content;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SoftStocksGUI
{
    public partial class frmBase : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );

        public frmBase()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            this.pnlNavContent.Controls.Clear();
            frmNavLogin frmNavLogin_Vrb = new frmNavLogin(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmNavLogin_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlNavContent.Controls.Add(frmNavLogin_Vrb);
            frmNavLogin_Vrb.Show();

            this.lblBanner.Text = "SoftStocks Ltd";
            this.pnlFormContent.Controls.Clear();
            frmLogo frmLogo_Vrb = new frmLogo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLogo_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormContent.Controls.Add(frmLogo_Vrb);
            frmLogo_Vrb.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.pnlNavContent.Controls.Clear();
            frmNavLogin frmNavLogin_Vrb = new frmNavLogin(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmNavLogin_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlNavContent.Controls.Add(frmNavLogin_Vrb);
            frmNavLogin_Vrb.Show();

            this.lblBanner.Text = "SoftStocks Ltd";
            this.pnlFormContent.Controls.Clear();
            frmLogo frmLogo_Vrb = new frmLogo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLogo_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormContent.Controls.Add(frmLogo_Vrb);
            frmLogo_Vrb.Show();

            this.lblProfile.Text = "Guest";
        }
    }
}