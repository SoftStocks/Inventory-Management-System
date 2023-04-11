using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SoftStocksGUI;

namespace SoftStocksGUI
{
    public partial class frmNavLogin : Form
    {
        private frmBase _frmBaseRef;
        public frmNavLogin(frmBase frmBaseRef)
        {
            _frmBaseRef = frmBaseRef;
            InitializeComponent();
        }

        private void btnNavLogin_Click(object sender, EventArgs e)
        {
            pnlNavSelect.Height = btnNavLogin.Height;
            pnlNavSelect.Top = btnNavLogin.Top;
            pnlNavSelect.Left = btnNavLogin.Right - 4;
            pnlNavSelect.Visible = true;

            btnNavLogin.BackColor = ColorTranslator.FromHtml("#49DDFE");

            _frmBaseRef.lblBanner.Text = "Login / Authenticate";
            _frmBaseRef.pnlFormContent.Controls.Clear();
            frmLogin frmLogin_Vrb = new frmLogin(_frmBaseRef) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLogin_Vrb.FormBorderStyle = FormBorderStyle.None;
            _frmBaseRef.pnlFormContent.Controls.Add(frmLogin_Vrb);
            frmLogin_Vrb.Show();

        }

        private void btnNavClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
