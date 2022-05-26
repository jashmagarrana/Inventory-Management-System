namespace IMS._17
{
	partial class StockReport
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
			this.gvStockReport = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.Search = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvStockReport)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gvStockReport
			// 
			this.gvStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvStockReport.Location = new System.Drawing.Point(12, 79);
			this.gvStockReport.Name = "gvStockReport";
			this.gvStockReport.Size = new System.Drawing.Size(776, 359);
			this.gvStockReport.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Controls.Add(this.Search);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 61);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(416, 27);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(138, 26);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// Search
			// 
			this.Search.AutoSize = true;
			this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Search.Location = new System.Drawing.Point(320, 28);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(66, 20);
			this.Search.TabIndex = 0;
			this.Search.Text = "Search";
			this.Search.Click += new System.EventHandler(this.label1_Click);
			// 
			// StockReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gvStockReport);
			this.Controls.Add(this.groupBox1);
			this.Name = "StockReport";
			this.Text = "StockReport";
			((System.ComponentModel.ISupportInitialize)(this.gvStockReport)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gvStockReport;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label Search;
	}
}