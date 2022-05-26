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
	public partial class ChangePassword : Form
	{
		public ChangePassword()
		{
			InitializeComponent();
		}
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection con = new SqlConnection(connectionstring);
				SqlDataAdapter da = new SqlDataAdapter("Select count(*) from Register where UserName ='" + txtUserName.Text + "' and Password='" + txtOldPassword.Text + "'", con);
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (dt.Rows[0][0].ToString() == "1")
				{
					if (txtNewPassword.Text == txtConfirmPassword.Text)
					{
						SqlDataAdapter dc = new SqlDataAdapter("Update Register set Password='" + txtNewPassword.Text + "' Where UserName ='" + txtUserName.Text + "' and Password='" + txtOldPassword.Text + "' ", con);
						DataTable df = new DataTable();
						dc.Fill(df);
						MessageBox.Show("Password Changed Successfully...!!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show(" Password doesnot match...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Please check your Username and Password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				txtUserName.Text = string.Empty;
				txtOldPassword.Text = string.Empty;
				txtNewPassword.Text = string.Empty;
				txtConfirmPassword.Text = string.Empty;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void txtOldPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void txtUserName_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txtNewPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
