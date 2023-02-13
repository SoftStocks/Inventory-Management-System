using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var mp = new MainPage();
                mp.Show();

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

            
            
            bool validUserName = true; // TODO: create method to check that username is in database
            string correctPassword = "testPassword"; // TODO: create method to get password from database given a username

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

            if ((password == correctPassword) && validUserName)
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
