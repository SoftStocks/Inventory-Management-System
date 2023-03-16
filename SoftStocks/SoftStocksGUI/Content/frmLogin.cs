using SoftStocksData;
using System.Data.Entity;

namespace SoftStocksGUI
{
    public partial class frmLogin : Form
    {

        private frmBase _frmBaseRef;
        public frmLogin(frmBase formBaseRef)
        {
            InitializeComponent();
            _frmBaseRef = formBaseRef;
        }

        private string? userName;
        private string? password;

        // Error messages
        private string INVALID_CREDENTIALS = "Invalid username or password. Please check your credentials";
        private string NO_USERNAME = "Please enter a username";
        private string NO_PASSWORD = "Please enter a password";

        private bool Authenticate()
        {

            userName = inpUsername.Text;
            password = inpPassword.Text;

            Credential credential;

            if (userName == string.Empty)
            {
                lblInvalid.Text = NO_USERNAME;
                lblInvalid.Visible = true;
                return false;
            }

            if (password == string.Empty)
            {
                lblInvalid.Text = NO_PASSWORD;
                lblInvalid.Visible = true;
                return false;
            }


            using (var db = new SoftStocksDBContext())
            {
                db.Credentials.Load();
                credential = db.Credentials.FirstOrDefault(c => c.Username == userName && c.Password == password);
            }

            if (credential != null)
            {
                return true;
            }
            else
            {
                lblInvalid.Text = INVALID_CREDENTIALS;
                lblInvalid.Visible = true;
                inpPassword.Text = string.Empty;
                return false;
            }

        }

        private void chckSeePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSeePassword.Checked)
            {
                inpPassword.PasswordChar = '\0';
                chckSeePassword.Image = Properties.Resources.eye_open;
            }
            else
            {
                inpPassword.PasswordChar = '*';
                chckSeePassword.Image = Properties.Resources.eye_closed;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Authenticate())
            {

                _frmBaseRef.lblProfile.Text = userName;

                _frmBaseRef.pnlNavContent.Controls.Clear();
                frmNavHome frmNavHome_Vrb = new frmNavHome(_frmBaseRef) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmNavHome_Vrb.FormBorderStyle = FormBorderStyle.None;
                _frmBaseRef.pnlNavContent.Controls.Add(frmNavHome_Vrb);
                frmNavHome_Vrb.Show();

            }
        }
    }
}
