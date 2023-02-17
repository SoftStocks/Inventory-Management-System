using SoftStocksData;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;

namespace SoftStocksGUI
{
    public partial class LoginPage : Form
    {
        private string userName;
        private string password;

        // Error messages
        private string INVALID_CREDENTIALS = "Invalid username or password. Please check your credentials";
        private string NO_USERNAME = "Please enter a username";
        private string NO_PASSWORD = "Please enter a password";

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

            if (userName == string.Empty)
            {
                lblInvalidMessage.Text = NO_USERNAME;
                lblInvalidMessage.Visible = true;
                return false;
            }

            if (password == string.Empty)
            {
                lblInvalidMessage.Text = NO_PASSWORD;
                lblInvalidMessage.Visible = true;
                return false;
            }

            string correctUserName;
            string correctPassword;


            using (var db = new SoftStocksDBContext())
            {
                var credentials = db.Credentials.ToList();

                if (credentials.Count() != 1)
                {
                    lblInvalidMessage.Visible = true;
                    lblInvalidMessage.Text = INVALID_CREDENTIALS;
                    return false;
                }
                else
                {
                    correctUserName = credentials[0].Username; 
                    correctPassword = credentials[0].Password;
                }


            } 

            if ((password == correctPassword) && (userName == correctUserName))
            {
                return true;
            }
            else
            {
                lblInvalidMessage.Text = INVALID_CREDENTIALS;
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
