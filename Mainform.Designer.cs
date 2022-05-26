namespace IMS._17
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.custSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purchaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.registerToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// categoryToolStripMenuItem
			// 
			this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proToolStripMenuItem,
            this.productToolStripMenuItem,
            this.unitToolStripMenuItem,
            this.custSupplierToolStripMenuItem});
			this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			this.categoryToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.categoryToolStripMenuItem.Text = "Setup";
			// 
			// proToolStripMenuItem
			// 
			this.proToolStripMenuItem.Name = "proToolStripMenuItem";
			this.proToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.proToolStripMenuItem.Text = "Category";
			this.proToolStripMenuItem.Click += new System.EventHandler(this.proToolStripMenuItem_Click);
			// 
			// productToolStripMenuItem
			// 
			this.productToolStripMenuItem.Name = "productToolStripMenuItem";
			this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.productToolStripMenuItem.Text = "Product";
			this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
			// 
			// unitToolStripMenuItem
			// 
			this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
			this.unitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.unitToolStripMenuItem.Text = "Unit";
			this.unitToolStripMenuItem.Click += new System.EventHandler(this.unitToolStripMenuItem_Click);
			// 
			// transactionsToolStripMenuItem
			// 
			this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.saleToolStripMenuItem});
			this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
			this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.transactionsToolStripMenuItem.Text = "Transactions";
			// 
			// purchaseToolStripMenuItem
			// 
			this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
			this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.purchaseToolStripMenuItem.Text = "Purchase";
			this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
			// 
			// saleToolStripMenuItem
			// 
			this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
			this.saleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.saleToolStripMenuItem.Text = "Sale";
			this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseReportToolStripMenuItem,
            this.salesReportToolStripMenuItem,
            this.stockReportToolStripMenuItem});
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.reportsToolStripMenuItem.Text = "Reports";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
			// 
			// registerToolStripMenuItem
			// 
			this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
			this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.registerToolStripMenuItem.Text = "Register";
			this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
			this.changePasswordToolStripMenuItem.Text = "Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
			// 
			// custSupplierToolStripMenuItem
			// 
			this.custSupplierToolStripMenuItem.Name = "custSupplierToolStripMenuItem";
			this.custSupplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.custSupplierToolStripMenuItem.Text = "CustSupplier";
			this.custSupplierToolStripMenuItem.Click += new System.EventHandler(this.custSupplierToolStripMenuItem_Click);
			// 
			// purchaseReportToolStripMenuItem
			// 
			this.purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
			this.purchaseReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.purchaseReportToolStripMenuItem.Text = "PurchaseReport";
			this.purchaseReportToolStripMenuItem.Click += new System.EventHandler(this.purchaseReportToolStripMenuItem_Click);
			// 
			// salesReportToolStripMenuItem
			// 
			this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
			this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salesReportToolStripMenuItem.Text = "SalesReport";
			this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
			// 
			// stockReportToolStripMenuItem
			// 
			this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
			this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.stockReportToolStripMenuItem.Text = "StockReport";
			this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::IMS._17.Properties.Resources._87553322;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem custSupplierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purchaseReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
	}
}