using SoftStocksGUI.Content;

namespace SoftStocksGUI
{
	public partial class frmNavHome : Form
	{
		private frmBase _frmBaseRef;
		public frmNavHome(frmBase frmBaseRef)
		{
			_frmBaseRef = frmBaseRef;
			InitializeComponent();

			_frmBaseRef.lblBanner.Text = "SoftStocks Ltd";
			_frmBaseRef.pnlFormContent.Controls.Clear();
			frmLogo frmLogo_Vrb = new frmLogo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			frmLogo_Vrb.FormBorderStyle = FormBorderStyle.None;
			_frmBaseRef.pnlFormContent.Controls.Add(frmLogo_Vrb);
			frmLogo_Vrb.Show();

		}

		private void btnNavReset(object sender)
		{

			var children = this.Controls.OfType<Control>();
			foreach (var btnNav in children)
			{
				if (btnNav.Text != "")
				{
					btnNav.BackColor = ColorTranslator.FromHtml("#928484");
				}
			}

			Button? btn = sender as Button;
			if (btn != null)
			{
				pnlNavSelect.Height = btn.Height;
				pnlNavSelect.Top = btn.Top;
				pnlNavSelect.Left = btn.Right - 4;
				pnlNavSelect.Visible = true;
				btn.BackColor = ColorTranslator.FromHtml("#49DDFE");
			}
		}

		private void btnNavHome_Click(object sender, EventArgs e)
		{

			btnNavReset(sender);

			_frmBaseRef.lblBanner.Text = "Home / Dashboard";
			_frmBaseRef.pnlFormContent.Controls.Clear();
			frmHome frmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			frmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
			_frmBaseRef.pnlFormContent.Controls.Add(frmHome_Vrb);
			frmHome_Vrb.Show();
		}

		private void btnNavSupplier_Click(object sender, EventArgs e)
		{
			btnNavReset(sender);

			_frmBaseRef.lblBanner.Text = "Supplier Dashboard";
			_frmBaseRef.pnlFormContent.Controls.Clear();
			frmSupplier frmSupplier_Vrb = new frmSupplier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			frmSupplier_Vrb.FormBorderStyle = FormBorderStyle.None;
			_frmBaseRef.pnlFormContent.Controls.Add(frmSupplier_Vrb);
			frmSupplier_Vrb.Show();
		}

		private void btnNavKeyboards_Click(object sender, EventArgs e)
		{
			btnNavReset(sender);

			_frmBaseRef.lblBanner.Text = "Keyboard Dashboard";
			_frmBaseRef.pnlFormContent.Controls.Clear();
			frmKeyboard frmKeyboard_Vrb = new frmKeyboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			frmKeyboard_Vrb.FormBorderStyle = FormBorderStyle.None;
			_frmBaseRef.pnlFormContent.Controls.Add(frmKeyboard_Vrb);
			frmKeyboard_Vrb.Show();
		}

		private void btnNavTasks_Click(object sender, EventArgs e)
		{
			btnNavReset(sender);

			_frmBaseRef.lblBanner.Text = "Task Dashboard";
			_frmBaseRef.pnlFormContent.Controls.Clear();
			frmTask frmTask_Vrb = new frmTask() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			frmTask_Vrb.FormBorderStyle = FormBorderStyle.None;
			_frmBaseRef.pnlFormContent.Controls.Add(frmTask_Vrb);
			frmTask_Vrb.Show();
		}

		private void btnNavReports_Click(object sender, EventArgs e)
		{
			btnNavReset(sender);

			_frmBaseRef.lblBanner.Text = "Report Dashboard";
			_frmBaseRef.pnlFormContent.Controls.Clear();
			frmReport frmReport_Vrb = new frmReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			frmReport_Vrb.FormBorderStyle = FormBorderStyle.None;
			_frmBaseRef.pnlFormContent.Controls.Add(frmReport_Vrb);
			frmReport_Vrb.Show();
		}

		private void btnNavClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
