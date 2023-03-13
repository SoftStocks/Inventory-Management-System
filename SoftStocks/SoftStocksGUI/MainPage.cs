using SoftStocksData.Reports;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = "jackwallace2002@hotmail.co.uk";  //Variables to change
            string recipients = "jackwallace2002@hotmail.co.uk";
            string subject = "Bonjourino";
            string body = "Bludclart email class";

            List<string> attachments = new List<string>();
            attachments.Add("C:\\Users\\jack.wallace\\Documents\\Holiday Request Form.doc");  //Change to suit your own attachment

            EmailReport.SendEmail(from, recipients, subject, body, attachments, true);
        }
    }
}
