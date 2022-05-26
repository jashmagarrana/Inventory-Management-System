using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace IMS._17
{
	public partial class Register : Form
	{
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";

		public Register()
		{
			InitializeComponent();
		}
		private void ClearForm()
		{
			txtUserId.Text = string.Empty;
			txtUserName.Text = string.Empty;
			txtPassword.Text = string.Empty;
			txtConfirmPassword.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtPhone.Text = string.Empty;
		}

		private bool FormValidation()
		{

			if (txtUserName.Text == string.Empty)
			{
				MessageBox.Show("User Name is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUserName.Focus();
				return false;
			}

			if (txtPassword.Text == string.Empty)
			{
				MessageBox.Show("Password  is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPassword.Focus();
				return false;
			}

			if (txtPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("Password doesnot match...!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtConfirmPassword.Focus();
				return false;
			}

			if (txtEmail.Text == string.Empty)
			{
				MessageBox.Show("Email is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmail.Focus();
				return false;
			}
			if (txtPhone.Text == string.Empty)
			{
				MessageBox.Show("Phone Number is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPhone.Focus();
				return false;
			}

			return true;
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			try
			{

				var confirm = MessageBox.Show("Do you want to Register?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
							cmd.CommandText = "INSERT INTO Register(UserName,Password,Email,Phone,SelectUserType) values(@UserName,@Password,@Email,@Phone,@SelectUserType)";
							con.Open();
							cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
							cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
							cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
							cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
							cmd.Parameters.AddWithValue("@SelectUserType", cmbSelectUserType.Text);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Registered  sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							ClearForm();

						}

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
