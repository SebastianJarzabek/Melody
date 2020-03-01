namespace Melody.View.Controls
{
  partial class ListMaterialReceipt
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Data_dgv = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.Search_btn = new System.Windows.Forms.Button();
      this.Refresh_btn = new System.Windows.Forms.Button();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.WarehouseAdmissionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DateOfAdmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HostEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DestinyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NoteFullText = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Data_dgv
      // 
      this.Data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.WarehouseAdmissionNumber,
            this.DateOfAdmission,
            this.HostEmployee,
            this.SupplierName,
            this.OrderNumber,
            this.DestinyName,
            this.Contract,
            this.MaterialName,
            this.MaterialType,
            this.Quantity,
            this.UnitName,
            this.NoteFullText});
      this.Data_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Data_dgv.Location = new System.Drawing.Point(0, 62);
      this.Data_dgv.Name = "Data_dgv";
      this.Data_dgv.RowHeadersWidth = 51;
      this.Data_dgv.RowTemplate.Height = 24;
      this.Data_dgv.Size = new System.Drawing.Size(1920, 1018);
      this.Data_dgv.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.Search_btn);
      this.panel1.Controls.Add(this.Refresh_btn);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1920, 62);
      this.panel1.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(209, 28);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(400, 27);
      this.textBox1.TabIndex = 6;
      // 
      // Search_btn
      // 
      this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Search_btn.Location = new System.Drawing.Point(615, 26);
      this.Search_btn.Name = "Search_btn";
      this.Search_btn.Size = new System.Drawing.Size(200, 30);
      this.Search_btn.TabIndex = 5;
      this.Search_btn.Text = "Szukaj";
      this.Search_btn.UseVisualStyleBackColor = true;
      // 
      // Refresh_btn
      // 
      this.Refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Refresh_btn.Location = new System.Drawing.Point(3, 26);
      this.Refresh_btn.Name = "Refresh_btn";
      this.Refresh_btn.Size = new System.Drawing.Size(200, 30);
      this.Refresh_btn.TabIndex = 4;
      this.Refresh_btn.Text = "Odśwież";
      this.Refresh_btn.UseVisualStyleBackColor = true;
      this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
      // 
      // Id
      // 
      this.Id.HeaderText = "Id";
      this.Id.MinimumWidth = 6;
      this.Id.Name = "Id";
      this.Id.Visible = false;
      this.Id.Width = 125;
      // 
      // WarehouseAdmissionNumber
      // 
      this.WarehouseAdmissionNumber.DataPropertyName = "WarehouseAdmissionNumber";
      this.WarehouseAdmissionNumber.HeaderText = "Numer przyjęcia na magazyn";
      this.WarehouseAdmissionNumber.MinimumWidth = 6;
      this.WarehouseAdmissionNumber.Name = "WarehouseAdmissionNumber";
      this.WarehouseAdmissionNumber.Width = 125;
      // 
      // DateOfAdmission
      // 
      this.DateOfAdmission.DataPropertyName = "DateOfAdmission";
      this.DateOfAdmission.HeaderText = "Data przyjęcia";
      this.DateOfAdmission.MinimumWidth = 6;
      this.DateOfAdmission.Name = "DateOfAdmission";
      this.DateOfAdmission.Width = 125;
      // 
      // HostEmployee
      // 
      this.HostEmployee.DataPropertyName = "HostEmployee";
      this.HostEmployee.HeaderText = "Przyjmujący";
      this.HostEmployee.MinimumWidth = 6;
      this.HostEmployee.Name = "HostEmployee";
      this.HostEmployee.Width = 125;
      // 
      // SupplierName
      // 
      this.SupplierName.DataPropertyName = "SupplierName";
      this.SupplierName.HeaderText = "Dostawca";
      this.SupplierName.MinimumWidth = 6;
      this.SupplierName.Name = "SupplierName";
      this.SupplierName.Width = 125;
      // 
      // OrderNumber
      // 
      this.OrderNumber.DataPropertyName = "OrderNumber";
      this.OrderNumber.HeaderText = "Numer zamówienia";
      this.OrderNumber.MinimumWidth = 6;
      this.OrderNumber.Name = "OrderNumber";
      this.OrderNumber.Width = 125;
      // 
      // DestinyName
      // 
      this.DestinyName.DataPropertyName = "DestinyName";
      this.DestinyName.HeaderText = "Przeznaczenie";
      this.DestinyName.MinimumWidth = 6;
      this.DestinyName.Name = "DestinyName";
      this.DestinyName.Width = 125;
      // 
      // Contract
      // 
      this.Contract.DataPropertyName = "Contract";
      this.Contract.HeaderText = "Kontrakt";
      this.Contract.MinimumWidth = 6;
      this.Contract.Name = "Contract";
      this.Contract.Width = 125;
      // 
      // MaterialName
      // 
      this.MaterialName.DataPropertyName = "MaterialName";
      this.MaterialName.HeaderText = "Nazwa materiału";
      this.MaterialName.MinimumWidth = 6;
      this.MaterialName.Name = "MaterialName";
      this.MaterialName.Width = 125;
      // 
      // MaterialType
      // 
      this.MaterialType.DataPropertyName = "MaterialType";
      this.MaterialType.HeaderText = "Typ materiału";
      this.MaterialType.MinimumWidth = 6;
      this.MaterialType.Name = "MaterialType";
      this.MaterialType.Width = 125;
      // 
      // Quantity
      // 
      this.Quantity.DataPropertyName = "Quantity";
      this.Quantity.HeaderText = "Ilość";
      this.Quantity.MinimumWidth = 6;
      this.Quantity.Name = "Quantity";
      this.Quantity.Width = 125;
      // 
      // UnitName
      // 
      this.UnitName.DataPropertyName = "UnitName";
      this.UnitName.HeaderText = "J.m.";
      this.UnitName.MinimumWidth = 6;
      this.UnitName.Name = "UnitName";
      this.UnitName.Width = 125;
      // 
      // NoteFullText
      // 
      this.NoteFullText.DataPropertyName = "NoteFullText";
      this.NoteFullText.HeaderText = "Uwagi";
      this.NoteFullText.MinimumWidth = 6;
      this.NoteFullText.Name = "NoteFullText";
      this.NoteFullText.Width = 125;
      // 
      // ListMaterialReceipt
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Data_dgv);
      this.Controls.Add(this.panel1);
      this.Name = "ListMaterialReceipt";
      this.Size = new System.Drawing.Size(1920, 1080);
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView Data_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseAdmissionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAdmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteFullText;
    }
}
