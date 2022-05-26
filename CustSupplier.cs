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
	public partial class CustSupplier : Form
	{
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
		private SqlConnection con;
		public CustSupplier()
		{
			InitializeComponent();
		}
		private void LoadGrid()
		{
			using (SqlConnection con = new SqlConnection(connectionstring))

			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;
				cmd.CommandType = CommandType.Text;
				con.Open();
				cmd.CommandText = "SELECT *FROM CustSupplier";
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				gvCustSupplier.DataSource = dt;
			}
		}
		private void CustSupplier_Load(object sender, EventArgs e)
		{
			LoadGrid();
		}
		private bool FormValidation()
		{
			if (txtName.Text == string.Empty)
			{
				MessageBox.Show("Name is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtName.Focus();
				return false;
			}
			if (cmbType.Text == string.Empty)
			{
				MessageBox.Show("Type is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbType.Focus();
				return false;
			}
			if (txtPhoneNo.Text == string.Empty)
			{
				MessageBox.Show("Phone.no is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPhoneNo.Focus();
				return false;
			}
			if (txtAddress.Text == string.Empty)
			{
				MessageBox.Show("Address is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtAddress.Focus();
				return false;
			}
			return true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var confirm = MessageBox.Show("Do you want to save?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (confirm.ToString().ToUpper() == "OK")
				{
					using (SqlConnection con = new SqlConnection(connectionstring))
					{
						bool isValiationSucess = FormValidation();
						if (isValiationSucess == true)
						{
							SqlCommand cmd = new SqlCommand();
							cmd.Connection = con;
							cmd.CommandType = CommandType.Text;
							con.Open();
							cmd.CommandText = @"INSERT INTO CustSupplier (Name,Type,Email,PhoneNo,MobileNo,Address) 
                                               VALUES (@name,@type,@email,@PhoneNo,@MobileNo,@address) ";
							cmd.Parameters.AddWithValue("@name", txtName.Text);
							cmd.Parameters.AddWithValue("@type", cmbType.Text);
							cmd.Parameters.AddWithValue("@email", txtEmail.Text);
							cmd.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);
							cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
							cmd.Parameters.AddWithValue("@address", txtAddress.Text);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Record saved sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ClearForm();
							LoadGrid();
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show(" went wrong..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ClearForm()
		{
			txtCustSupplierId.Text = string.Empty;
			txtName.Text = string.Empty;
			cmbType.Text = string.Empty;

			txtEmail.Text = string.Empty;
			txtPhoneNo.Text = string.Empty;
			txtMobileNo.Text = string.Empty;
			txtAddress.Text = string.Empty;
		}
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(connectionstring))
				{
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;
					cmd.CommandType = CommandType.Text;
					con.Open();
					cmd.CommandText = @"SELECT Name,Type,Email,PhoneNo,MobileNo,Address From CustSupplier where Name Like @Search OR
                                       Type Like @Search OR Email Like @Search OR PhoneNo Like @Search OR MobileNo Like @Search OR Address Like @Search";
					cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);
					gvCustSupplier.DataSource = dt;
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void gvCustSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			LoadGrid();
		}
		private void gvCustSupplier_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				txtCustSupplierId.Text = (gvCustSupplier.Rows[e.RowIndex].Cells[0].Value.ToString());
				txtName.Text = (gvCustSupplier.Rows[e.RowIndex].Cells[1].Value.ToString());
				cmbType.Text = (gvCustSupplier.Rows[e.RowIndex].Cells[2].Value.ToString());
				txtEmail.Text = (gvCustSupplier.Rows[e.RowIndex].Cells[3].Value.ToString());
				txtPhoneNo.Text = (gvCustSupplier.Rows[e.RowIndex].Cells[4].Value.ToString());
				txtMobileNo.Text = (gvCustSupplier.Rows[e.RowIndex].Cells[5].Value.ToString());
				txtAddress.Text = (gvCustSupplier.Rows[e.RowIndex].Cells[6].Value.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
						bool isValidationSucess = FormValidation();
						if (isValidationSucess == true)
						{
							SqlCommand cmd = new SqlCommand();
							cmd.Connection = con;
							cmd.CommandType = CommandType.Text;
							con.Open();
							cmd.CommandText = @"Update  CustSupplier set Name=@name,Type=@type,Email=@email,PhoneNo=@phoneNo,MobileNo=@mobileNo,Address=@address where CustSupplierId=@custSupplierId";
							cmd.Parameters.AddWithValue("@name", txtName.Text);
							cmd.Parameters.AddWithValue("@type", cmbType.Text);
							cmd.Parameters.AddWithValue("@email", txtEmail.Text);
							cmd.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);
							cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
							cmd.Parameters.AddWithValue("@address", txtAddress.Text);
							cmd.Parameters.AddWithValue("@custSupplierId", txtCustSupplierId.Text);

							cmd.ExecuteNonQuery();
							MessageBox.Show("Record Updated sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ClearForm();
							LoadGrid();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
						bool isValiationSucess = FormValidation();
						if (isValiationSucess == true)
						{
							SqlCommand cmd = new SqlCommand();
							cmd.Connection = con;
							cmd.CommandType = CommandType.Text;
							con.Open();
							//cmd.CommandText = "DELETE from CustSupplier where CustSupplierId = @custSupplierId";
							cmd.Parameters.AddWithValue("@custSupplierId", txtCustSupplierId.Text);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Record Deleted sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ClearForm();
							LoadGrid();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
	}
}
