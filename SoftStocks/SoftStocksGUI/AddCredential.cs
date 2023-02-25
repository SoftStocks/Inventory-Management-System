using Microsoft.EntityFrameworkCore;
using SoftStocksData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftStocksGUI
{
    public partial class AddCredential : Form
    {
        public AddCredential()
        {
            InitializeComponent();
        }

        private void btnSubmitCred_Click(object sender, EventArgs e)
        {
            SoftStocksDBContext dbc = new SoftStocksDBContext();

            using(dbc)
            {
                dbc.Credentials.Add(new Credential { Username=txtUsername.Text, StaffId=1, Password=txtPassword.Text });
                dbc.SaveChanges();
                var query = from c in dbc.Credentials select c;
                gdvCredentials.DataSource = query.ToList();
            }

            gdvCredentials.Refresh();

            
        }
    }
}
