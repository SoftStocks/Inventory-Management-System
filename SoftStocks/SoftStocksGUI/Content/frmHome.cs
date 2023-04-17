using SoftStocksData.Entities.Suppliers;
using SoftStocksData;
using SoftStocksGUI.Widgets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftStocksData.Entities.Keyboards;
using System.Diagnostics;

namespace SoftStocksGUI
{
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();

			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnCount = 3;
			dataGridView1.Columns[0].Name = "Supplier Name";
			dataGridView1.Columns[1].Name = "Model No.";
			dataGridView1.Columns[2].Name = "Quantity";


			List<Keyboard> keyboardList;

			using (SoftStocksDBContext db = new SoftStocksDBContext())
			{
				keyboardList = db.Keyboards.ToList();

			}

			foreach (Keyboard keyboardItem in keyboardList)
			{
				frmKeyboardEntry frmKeyboardEntry_Vrb = new frmKeyboardEntry(keyboardItem.Ident, keyboardItem.ModelNumber, keyboardItem.Quantity, keyboardItem.Price, keyboardItem.SupplierId, keyboardItem.Description) { TopLevel = false, TopMost = true };
				frmKeyboardEntry_Vrb.FormBorderStyle = FormBorderStyle.None;

				//this.pnlScrollableKeyboard.Controls.Add(frmKeyboardEntry_Vrb);
				//listBox1.Items.Add(keyboardItem.Description + "\t" + keyboardItem.ModelNumber + "\t" + keyboardItem.Quantity);

				DataGridViewRow tempRow = new DataGridViewRow();

				DataGridViewCell cellFileName = new DataGridViewTextBoxCell();
				cellFileName.Value = keyboardItem.SupplierId;
				tempRow.Cells.Add(cellFileName);

				DataGridViewCell cellDocCount = new DataGridViewTextBoxCell();
				cellDocCount.Value = keyboardItem.Quantity;
				tempRow.Cells.Add(cellDocCount);

				DataGridViewCell cellPageCount = new DataGridViewTextBoxCell();
				cellPageCount.Value = keyboardItem.ModelNumber;
				tempRow.Cells.Add(cellPageCount);



				//tempRow.Tag = selectedProject.InputFiles[i].Id;
				dataGridView1.Rows.Add(tempRow);


				//frmKeyboardEntry_Vrb.Show();
			}

		}
	}
}
