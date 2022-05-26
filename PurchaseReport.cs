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

namespace IMS._17
{
	public partial class PurchaseReport : Form
	{
		public PurchaseReport()
		{
			InitializeComponent();
		}
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
		
		private void btnShow_Click(object sender, EventArgs e)
		{
			try
			{
				string fromDate = txtfromDate.Text;
				string toDate = txttoDate.Text;
				SqlConnection con = new SqlConnection(connectionstring);
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = con;
				con.Open();
				cmd.CommandText = @"Select m.TransactionDate, cs.Name, p.ProductName , c.CategoryName,u.UnitName,m.GrandTotal,m.Vat,m.Discount,d.Quantity,d.Rate as [Purchase Rate], d.Total from TransactionDetail d inner join TransactionMaster m on m.TransactionMasterId=d.TransactionMasterId 
                                       INNER JOIN Product p on p.ProductId = d.ProductId
                                        inner join Category c on  c.CategoryId = p.CategoryId
                                        INNER JOIN Unit u on u.UnitId = p.UnitId 
                                        INNER JOIN CustSupplier cs ON CS.CustSupplierId = m.CustSupplierId
                                       WHERE m.TransactionDate BETWEEN '" + fromDate + "' and  '" + toDate + "'";
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				gvPurchaseReport.DataSource = dt;
			}
			catch (Exception ex )
			{

				MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
	}
}
