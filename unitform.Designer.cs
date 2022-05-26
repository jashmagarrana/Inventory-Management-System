namespace IMS._17
{
	partial class Unitform
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
			this.gvUnit = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtUnitId = new System.Windows.Forms.TextBox();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.lblRemarks = new System.Windows.Forms.Label();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.lblAlias = new System.Windows.Forms.Label();
			this.txtUnitName = new System.Windows.Forms.TextBox();
			this.lblUnitName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvUnit)).BeginInit();
			this.SuspendLayout();
			// 
			// gvUnit
			// 
			this.gvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvUnit.Location = new System.Drawing.Point(-2, 229);
			this.gvUnit.Name = "gvUnit";
			this.gvUnit.Size = new System.Drawing.Size(398, 177);
			this.gvUnit.TabIndex = 25;
			this.gvUnit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUnit_CellContentClick);
			this.gvUnit.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvUnit_RowHeaderMouseDoubleClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(241, 183);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 40);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(132, 183);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(83, 40);
			this.btnUpdate.TabIndex = 23;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(28, 183);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 36);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(150, 134);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 23);
			this.txtSearch.TabIndex = 21;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(58, 141);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(59, 17);
			this.lblSearch.TabIndex = 20;
			this.lblSearch.Text = "Search";
			// 
			// txtUnitId
			// 
			this.txtUnitId.Location = new System.Drawing.Point(296, 134);
			this.txtUnitId.Name = "txtUnitId";
			this.txtUnitId.Size = new System.Drawing.Size(100, 20);
			this.txtUnitId.TabIndex = 19;
			// 
			// txtRemarks
			// 
			this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRemarks.Location = new System.Drawing.Point(150, 97);
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(100, 23);
			this.txtRemarks.TabIndex = 18;
			// 
			// lblRemarks
			// 
			this.lblRemarks.AutoSize = true;
			this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRemarks.Location = new System.Drawing.Point(32, 103);
			this.lblRemarks.Name = "lblRemarks";
			this.lblRemarks.Size = new System.Drawing.Size(71, 17);
			this.lblRemarks.TabIndex = 17;
			this.lblRemarks.Text = "Remarks";
			// 
			// txtAlias
			// 
			this.txtAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(150, 61);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(100, 23);
			this.txtAlias.TabIndex = 16;
			// 
			// lblAlias
			// 
			this.lblAlias.AutoSize = true;
			this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlias.Location = new System.Drawing.Point(44, 67);
			this.lblAlias.Name = "lblAlias";
			this.lblAlias.Size = new System.Drawing.Size(43, 17);
			this.lblAlias.TabIndex = 15;
			this.lblAlias.Text = "Alias";
			// 
			// txtUnitName
			// 
			this.txtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnitName.Location = new System.Drawing.Point(150, 28);
			this.txtUnitName.Name = "txtUnitName";
			this.txtUnitName.Size = new System.Drawing.Size(100, 23);
			this.txtUnitName.TabIndex = 14;
			// 
			// lblUnitName
			// 
			this.lblUnitName.AutoSize = true;
			this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUnitName.Location = new System.Drawing.Point(32, 31);
			this.lblUnitName.Name = "lblUnitName";
			this.lblUnitName.Size = new System.Drawing.Size(83, 17);
			this.lblUnitName.TabIndex = 13;
			this.lblUnitName.Text = "Unit Name";
			// 
			// Unitform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(401, 406);
			this.Controls.Add(this.gvUnit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.txtUnitId);
			this.Controls.Add(this.txtRemarks);
			this.Controls.Add(this.lblRemarks);
			this.Controls.Add(this.txtAlias);
			this.Controls.Add(this.lblAlias);
			this.Controls.Add(this.txtUnitName);
			this.Controls.Add(this.lblUnitName);
			this.Name = "Unitform";
			this.Text = "Unitform";
			this.Load += new System.EventHandler(this.unitform_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvUnit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gvUnit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtUnitId;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.Label lblRemarks;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Label lblAlias;
		private System.Windows.Forms.TextBox txtUnitName;
		private System.Windows.Forms.Label lblUnitName;
	}
}