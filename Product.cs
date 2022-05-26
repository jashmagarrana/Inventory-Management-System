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
	public partial class Product : Form
	{
		int productId = 0;
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
		
		public Product()
		{
			InitializeComponent();
		}
		private void label7_Click(object sender, EventArgs e)
		{
		}
		private void LoadCategory()
		{
			try
			{
			//tring connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
				SqlConnection con = new SqlConnection(connectionstring);
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = con;
				con.Open();
				cmd.CommandText = "SELECT CategoryId,CategoryName,Remarks from Category";
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DataRow dr = dt.NewRow();
				dr.ItemArray = new object[] {-1, "Select Category"};
				dt.Rows.InsertAt(dr,0);
				cmbCategory.DisplayMember = "CategoryName";
				cmbCategory.ValueMember = "CategoryId";
				cmbCategory.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Something went wrong;","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadUnit()
		{
			try
			{
			//tring connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
				SqlConnection con = new SqlConnection(connectionstring);
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = con;
				con.Open();
				cmd.CommandText = "SELECT UnitId,UnitName,Alias,Remarks from unit";
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DataRow dr = dt.NewRow();
				dr.ItemArray = new object[] { -1, "select Unit" };
				dt.Rows.InsertAt(dr, 0);
				cmbUnit.DisplayMember = "UnitName";
				cmbUnit.ValueMember = "UnitId";
				cmbUnit.DataSource = dt;
        	}
			catch (Exception)
			{

				MessageBox.Show("Something went wrong;", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadGrid()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(connectionstring))
				{
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;
					con.Open();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "spGetProduct";
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);
					gvProduct.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Product_Load(object sender, EventArgs e)
		{
			LoadCategory();
			LoadUnit();
			LoadGrid();
		}
		private void clearForm()
		{
			txtProductName.Text = string.Empty;
			txtRate.Text = string.Empty;
			txtQuantity.Text = string.Empty;
			txtRemarks.Text = string.Empty;
			cmbCategory.SelectedIndex = 0;
			cmbUnit.SelectedIndex = 0;
		}
		private bool  FormValidation()
		{
			if(cmbCategory.SelectedValue.ToString()=="-1")
			{
        	MessageBox.Show("Categotry is not selected...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbCategory.Focus();
				return false;
			}
			if (txtProductName.Text== string.Empty)
			{
				MessageBox.Show("ProductName is Required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtProductName.Text = string.Empty;
				txtProductName.Focus();
				return false;
			}
			if (cmbUnit.SelectedValue.ToString() == "-1")
			{
				MessageBox.Show("Unit is not selected...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbUnit.Focus();
				return false;
			}
			if (txtRate.Text == string.Empty)
			{
				MessageBox.Show("Product Rate is Required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtRate.Text = string.Empty;
				txtRate.Focus();
				return false;
			}
			if (txtRate.Text != string.Empty)
			{
				decimal outRate = 0;
				bool isRateDecimal = decimal.TryParse(txtRate.Text, out outRate);
				if (isRateDecimal == false)
				{
					MessageBox.Show("Product Rate should be Decimal...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtRate.Text = string.Empty;
					txtRate.Focus();
					return false;
				}
			}
			if (txtQuantity.Text == string.Empty)
			{
				MessageBox.Show("Product Quantity is Required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtQuantity.Text = string.Empty;
				txtQuantity.Focus();
				return false;
			}
			 
			 if (txtQuantity.Text != string.Empty)
			{
				decimal outQuantity = 0;
				bool isQuantityDecimal = decimal.TryParse(txtQuantity.Text, out outQuantity);
				if (isQuantityDecimal == false)
				{
					MessageBox.Show("Product Quantity should be Decimal...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtQuantity.Text = string.Empty;
					txtQuantity.Focus();
					return false;
				}
			}
			return true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var confirm = MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (confirm.ToString().ToUpper() == "OK")
				{
					bool isValidationSuccess = FormValidation();
					if (isValidationSuccess == true)
					{
						using (SqlConnection con = new SqlConnection(connectionstring))
						{
							SqlCommand cmd = new SqlCommand();
							cmd.Connection = con;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.CommandText = "spCreateProduct ";
							con.Open();
							cmd.Parameters.AddWithValue("@CategoryId", int.Parse(cmbCategory.SelectedValue.ToString()));
							cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
							cmd.Parameters.AddWithValue("@UnitId", int.Parse(cmbUnit.SelectedValue.ToString()));
							cmd.Parameters.AddWithValue("@Rate", decimal.Parse(txtRate.Text));
							cmd.Parameters.AddWithValue("@Quantity", decimal.Parse(txtQuantity.Text));
							cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product saved successfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							clearForm();
							LoadGrid();	
						}
						}
					}
			}
			catch (Exception ex)
			{
				if (ex.Message.ToString().Contains("UK_ProductName"))
				{
					MessageBox.Show("ProductName should be Unique..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtProductName.Text = string.Empty;
					txtProductName.Focus();
				}
				else
				{
					MessageBox.Show("Something went wrong..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(connectionstring))
				{
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;
					con.Open();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
					cmd.CommandText = "spSearchProduct";
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);
					gvProduct.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void gvProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int CategoryId = int.Parse(gvProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
			cmbCategory.SelectedValue = CategoryId;
			productId = int.Parse(gvProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
			txtProductName.Text = gvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
			int unitId = int.Parse(gvProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
			cmbUnit.SelectedValue = unitId;
			txtRate.Text = gvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtQuantity.Text = gvProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
			txtRemarks.Text = gvProduct.Rows[e.RowIndex].Cells[8].Value.ToString();
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				var confirm = MessageBox.Show("Do you want to update?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (confirm.ToString().ToUpper() == "OK")
				{
					using (SqlConnection con = new SqlConnection(connectionstring))
					{
						bool isValiationSucess = FormValidation();
						if (isValiationSucess == true)
						{
							SqlCommand cmd = new SqlCommand();
							cmd.Connection = con;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.CommandText = "spUpdateProduct";
							con.Open();
							cmd.Parameters.AddWithValue("@ProductId", productId);
							cmd.Parameters.AddWithValue("@categoryId", int.Parse(cmbCategory.SelectedValue.ToString()));
							cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
							cmd.Parameters.AddWithValue("@unitId", int.Parse(cmbUnit.SelectedValue.ToString()));
							cmd.Parameters.AddWithValue("@Rate", decimal.Parse(txtRate.Text));
							cmd.Parameters.AddWithValue("@Quantity", decimal.Parse(txtQuantity.Text));
							cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product updated sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							clearForm();
							LoadGrid();
						}
					}
				}
			}
			catch (Exception ex)
			{
				if (ex.Message.ToString().Contains("UK_ProductName"))
				{
					MessageBox.Show("Product Name should be unique...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtProductName.Focus();
				}
				else
				{
					MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
         }
		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var confirm = MessageBox.Show("Do you want to Delete?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (confirm.ToString().ToUpper() == "OK")
				{
					using (SqlConnection con = new SqlConnection(connectionstring))
					{
 					 SqlCommand cmd = new SqlCommand();
						cmd.Connection = con;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "spDeleteProduct";
						con.Open();
						cmd.Parameters.AddWithValue("@productId", productId);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Product deleted sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						clearForm();
						LoadGrid();
					}
				}
			}
			catch (Exception ex)
			{
				if (ex.Message.ToString().Contains("UK_ProductName"))
				{
					MessageBox.Show("Product Name should be unique...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtProductName.Focus();
				}
				else
				{
					MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
		clearForm();		
	  }
	}
}
