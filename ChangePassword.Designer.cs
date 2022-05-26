namespace IMS._17
{
	partial class ChangePassword
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtOldPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.btnChangePassword = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmPassword.Location = new System.Drawing.Point(160, 146);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(100, 23);
			this.txtConfirmPassword.TabIndex = 21;
			this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 17);
			this.label5.TabIndex = 20;
			this.label5.Text = "Old Password";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtOldPassword
			// 
			this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOldPassword.Location = new System.Drawing.Point(151, 71);
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.Size = new System.Drawing.Size(100, 23);
			this.txtOldPassword.TabIndex = 19;
			this.txtOldPassword.TextChanged += new System.EventHandler(this.txtOldPassword_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 17);
			this.label4.TabIndex = 18;
			this.label4.Text = "Confirm Password ";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(151, 36);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(100, 23);
			this.txtUserName.TabIndex = 17;
			this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "User Name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 17);
			this.label2.TabIndex = 23;
			this.label2.Text = "New Password";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNewPassword.Location = new System.Drawing.Point(151, 108);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.Size = new System.Drawing.Size(100, 23);
			this.txtNewPassword.TabIndex = 22;
			this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
			// 
			// btnChangePassword
			// 
			this.btnChangePassword.BackColor = System.Drawing.Color.ForestGreen;
			this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangePassword.Location = new System.Drawing.Point(55, 189);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.Size = new System.Drawing.Size(177, 36);
			this.btnChangePassword.TabIndex = 24;
			this.btnChangePassword.Text = "Change Password";
			this.btnChangePassword.UseVisualStyleBackColor = false;
			this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
			// 
			// ChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(333, 249);
			this.Controls.Add(this.btnChangePassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtOldPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label1);
			this.Name = "ChangePassword";
			this.Text = "ChangePassword";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtOldPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.Button btnChangePassword;
	}
}