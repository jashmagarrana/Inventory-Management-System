using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS._17
{
	public partial class MainForm : Form
	{
	public static string transactionsType;
		public MainForm()
		{
			InitializeComponent();
		}

		private void proToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Category cat = new Category();
				cat.Show();
		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Product pro = new Product();
			pro.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
       
		}

		private void unitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Unitform uni = new Unitform();
			uni.Show();
		}
		private void custSupplierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustSupplier obj = new CustSupplier();
			obj.Show();
		}
		private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			transactionsType = "Purchase";
			PurchaseSale PS = new PurchaseSale();
			PS.Show();
		}

		private void saleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			transactionsType = "Sale";
			PurchaseSale PS = new PurchaseSale();
			PS.Show();
		}

		private void registerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Register obj = new Register();
			obj.Show();
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangePassword obj = new ChangePassword();
			obj.Show();
		}

		private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PurchaseReport pr = new PurchaseReport();
			pr.Show();
		}

		private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SalesReport sr = new SalesReport();
			sr.Show();
		}

		private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StockReport str = new StockReport();
			str.Show();
		}
	}
}
 