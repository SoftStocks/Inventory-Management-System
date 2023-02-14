using SoftStocksData;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SoftStocksGUI
{
    public partial class LoginPage : Form
    {
        private string userName;
        private string password;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            if(authenticate())
            {
                // create new main page form instance
                var t = new Thread(() => Application.Run(new MainPage()));
                t.Start();

                // close current instance
                this.Close();
            }
            else
            {
                
            }
        }

        private bool authenticate()
        {
            
            userName = txtUsername.Text;
            password = txtPassword.Text;
            
            string correctUserName = "andy";
            string correctPassword = "testPassword";
            
            using(var db = new SoftStocksDBContext())
            {
                var credentials = db.Credentials
                    .Where(c => c.UserName == txtUsername.Text);

                //correctUserName = credentials;
                //correctPassword = credentials.Password;
                Console.WriteLine($"######### Credentials: {credentials}");
            }
            

            if (userName == string.Empty)
            {
                lblInvalidMessage.Text = "Please enter a username";
                lblInvalidMessage.Visible = true;
                return false;
            }

            if (password == string.Empty)
            {
                lblInvalidMessage.Text = "Please enter a password";
                lblInvalidMessage.Visible = true;
                return false;
            }

            if ((password == correctPassword) && (userName == correctUserName))
            {
                return true;
            }
            else
            {
                lblInvalidMessage.Text = "Invalid username or password. Please check your credentials";
                lblInvalidMessage.Visible = true;
                txtPassword.Text = string.Empty;
                return false;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            { 
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void credentialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.credentialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softStocksDBCredentials);

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softStocksDBCredentials.Credentials' table. You can move, or remove it, as needed.
            this.credentialsTableAdapter.Fill(this.softStocksDBCredentials.Credentials);

        }
    }
}
