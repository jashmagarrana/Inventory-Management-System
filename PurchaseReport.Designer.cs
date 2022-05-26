namespace IMS._17
{
	partial class PurchaseReport
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txttoDate = new System.Windows.Forms.DateTimePicker();
			this.txtfromDate = new System.Windows.Forms.DateTimePicker();
			this.btnShow = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gvPurchaseReport = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPurchaseReport)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txttoDate);
			this.groupBox1.Controls.Add(this.txtfromDate);
			this.groupBox1.Controls.Add(this.btnShow);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 61);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txttoDate
			// 
			this.txttoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txttoDate.Location = new System.Drawing.Point(245, 23);
			this.txttoDate.Name = "txttoDate";
			this.txttoDate.Size = new System.Drawing.Size(141, 20);
			this.txttoDate.TabIndex = 6;
			// 
			// txtfromDate
			// 
			this.txtfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtfromDate.Location = new System.Drawing.Point(67, 23);
			this.txtfromDate.Name = "txtfromDate";
			this.txtfromDate.Size = new System.Drawing.Size(129, 20);
			this.txtfromDate.TabIndex = 5;
			// 
			// btnShow
			// 
			this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShow.Location = new System.Drawing.Point(413, 19);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 36);
			this.btnShow.TabIndex = 4;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(202, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "To";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "From";
			// 
			// gvPurchaseReport
			// 
			this.gvPurchaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvPurchaseReport.Location = new System.Drawing.Point(12, 79);
			this.gvPurchaseReport.Name = "gvPurchaseReport";
			this.gvPurchaseReport.Size = new System.Drawing.Size(776, 359);
			this.gvPurchaseReport.TabIndex = 1;
			// 
			// PurchaseReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gvPurchaseReport);
			this.Controls.Add(this.groupBox1);
			this.Name = "PurchaseReport";
			this.Text = "PurchaseReport";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPurchaseReport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker txttoDate;
		private System.Windows.Forms.DateTimePicker txtfromDate;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gvPurchaseReport;
	}
}