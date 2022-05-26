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
	public partial class Category : Form
	{
		public Category()
		{
			InitializeComponent();
		}
		private void LoadGrid()
		{
			txtCategoryId.Visible = false;

			string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
			SqlConnection con = new SqlConnection(connectionstring);
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.Connection = con;
			con.Open();
			cmd.CommandText = "SELECT *FROM Category";
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			gvCategory.DataSource = dt;
		}

		private void Category_Load(object sender, EventArgs e)
		{
			LoadGrid();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			LoadGrid();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmation = MessageBox.Show("Do yo wish to continue", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.Yes)
				{
					string strCategoryName = txtCategoryName.Text;
					if (strCategoryName == string.Empty)
					{
						MessageBox.Show("Category Name is required", "warning----!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					//step-1 prepare ConnectionString
					//string connection=System.Configuration.ConfigurationManager.ConnectionString["con"].ConnectionString.ToString();
					string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";

					//step-2 prepare for sql connection
					SqlConnection con = new SqlConnection(connection);
					//step-3 prepare for sql command
					SqlCommand cmd = new SqlCommand();
					cmd.CommandType = CommandType.Text;
					cmd.Connection = con;
					con.Open();
					cmd.CommandText = "INSERT INTO Category(CategoryName,Remarks) VALUES(@CategoryName,@Remarks )";
					cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
					cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Successfully Saved", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
					LoadGrid();

				}
				else
				{
					MessageBox.Show("Permission denies to save..");
				}
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("UK_Category"))
				{
					//MessageBox.Show(ex.Message);
					MessageBox.Show("Category name already exists:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
				}
				else
				{//MessageBox.Show(ex.Message);
					MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
	}
}
}
		private void gvCategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
			txtCategoryName.Text = (gvCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
			txtRemarks.Text = (gvCategory.Rows[e.RowIndex].Cells[1].Value.ToString());
			txtCategoryId.Text = (gvCategory.Rows[e.RowIndex].Cells[2].Value.ToString());
		}
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmation = MessageBox.Show("Do yo want to Update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.Yes)
				{
					string strCategoryName = txtCategoryName.Text;
					if (strCategoryName == string.Empty)
					{
						MessageBox.Show("Category Name is required", "warning----!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					//step-1 prepare ConnectionString
					//string connection=System.Configuration.ConfigurationManager.ConnectionString["con"].ConnectionString.ToString();
					string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
					//step-2 prepare for sql connection
					SqlConnection con = new SqlConnection(connection);
					//step-3 prepare for sql command
					SqlCommand cmd = new SqlCommand();
					cmd.CommandType = CommandType.Text;
					cmd.Connection = con;
					con.Open();
					cmd.CommandText = "UPDATE Category SET CategoryName=@CategoryName ,Remarks=@Remarks where CategoryId=@CategoryId";
					cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
					cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
					cmd.Parameters.AddWithValue("@CategoryId", txtCategoryId.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Successfully Updated:", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
					LoadGrid();
				}
				else
				{
					MessageBox.Show("Permission Denied to Update!!");
				}
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("UK_Category"))
				{
					//MessageBox.Show(ex.Message);
					MessageBox.Show("Category name already exists:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
				}
				else
				{//MessageBox.Show(ex.Message);
					MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
				}
			}
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmation = MessageBox.Show("Do yo want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.Yes)
				{
					string strCategoryName = txtCategoryName.Text;
					if (strCategoryName == string.Empty)
					{
						MessageBox.Show("Category Name is required", "warning----!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					//step-1 prepare ConnectionString
					//string connection=System.Configuration.ConfigurationManager.ConnectionString["con"].ConnectionString.ToString();
					string connection = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";
					//step-2 prepare for sql connection
					SqlConnection con = new SqlConnection(connection);
					//step-3 prepare for sql command
					SqlCommand cmd = new SqlCommand();
					cmd.CommandType = CommandType.Text;
					cmd.Connection = con;
					con.Open();
					cmd.CommandText = "Delete From Category where CategoryId=@CategoryId";
					cmd.Parameters.AddWithValue("@CategoryId", txtCategoryId.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Successfully Deleted:", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
					LoadGrid();
				}
				else
				{
					MessageBox.Show("Permission Denied to Delete!!");
				}
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("UK_Category"))
				{
					//MessageBox.Show(ex.Message);
					MessageBox.Show("Category name already exists:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
				}
				else
				{//MessageBox.Show(ex.Message);
					MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCategoryName.Text = string.Empty;//" "
					txtRemarks.Text = string.Empty;
				}
				}
	}
}
	}