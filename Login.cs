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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		string connectionstring = "Data source = LAPTOP-J4A8AKB6\\JASH; Initial Catalog =IMS_17;Integrated Security=SSPI";

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{

				{
					SqlConnection con = new SqlConnection(connectionstring);
					SqlCommand cmd = new SqlCommand("Select * from Register where UserName ='" + txtUserName.Text + "' AND Password='" + txtPassword.Text + "'", con);
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);
					string cmbItemValue = cmbSelectUserType.SelectedItem.ToString();
					if (dt.Rows.Count > 0)
					{
						for (int i = 0; i < dt.Rows.Count; i++)
						{
							if (dt.Rows[i]["SelectUserType"].ToString() == cmbItemValue)
							{
								MessageBox.Show("Welcome To MainForm " + dt.Rows[i][5]);
								if (cmbSelectUserType.SelectedIndex == 0)
								{
									this.Hide();
									MainForm mf = new MainForm();
									mf.Show();
								}

							}
						}
					}
					else
					{
						MessageBox.Show("Please check your Username and Password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
			}
		}
