using System.Windows.Forms;

namespace Melody.View.Controls
{
  partial class ListContractors_panel
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
      this.Search_btn = new System.Windows.Forms.Button();
      this.Refresh_btn = new System.Windows.Forms.Button();
      this.IdDestiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HouseNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ApartamentNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ZipCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.WebsideColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Data_dgv
      // 
      this.Data_dgv.AllowUserToOrderColumns = true;
      this.Data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDestiny,
            this.Name,
            this.Contract,
            this.HouseNumberColumn,
            this.ApartamentNumberColumn,
            this.ZipCodeColumn,
            this.CityColumn,
            this.CountryColumn,
            this.PhoneNumberColumn,
            this.EmailColumn,
            this.WebsideColumn});
      this.Data_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Data_dgv.Location = new System.Drawing.Point(0, 62);
      this.Data_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Data_dgv.Name = "Data_dgv";
      this.Data_dgv.RowHeadersWidth = 51;
      this.Data_dgv.RowTemplate.Height = 24;
      this.Data_dgv.Size = new System.Drawing.Size(1920, 1019);
      this.Data_dgv.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.Search_btn);
      this.panel1.Controls.Add(this.Refresh_btn);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1920, 62);
      this.panel1.TabIndex = 2;
      // 
      // Search_btn
      // 
      this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Search_btn.Location = new System.Drawing.Point(221, 26);
      this.Search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Search_btn.Name = "Search_btn";
      this.Search_btn.Size = new System.Drawing.Size(200, 30);
      this.Search_btn.TabIndex = 2;
      this.Search_btn.Text = "Szukaj";
      this.Search_btn.UseVisualStyleBackColor = true;
      // 
      // Refresh_btn
      // 
      this.Refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Refresh_btn.Location = new System.Drawing.Point(16, 26);
      this.Refresh_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Refresh_btn.Name = "Refresh_btn";
      this.Refresh_btn.Size = new System.Drawing.Size(200, 30);
      this.Refresh_btn.TabIndex = 0;
      this.Refresh_btn.Text = "Odśwież";
      this.Refresh_btn.UseVisualStyleBackColor = true;
      this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
      // 
      // IdDestiny
      // 
      this.IdDestiny.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.IdDestiny.DataPropertyName = "IdDestiny";
      this.IdDestiny.HeaderText = "Id";
      this.IdDestiny.MinimumWidth = 6;
      this.IdDestiny.Name = "IdDestiny";
      this.IdDestiny.Visible = false;
      this.IdDestiny.Width = 48;
      // 
      // Name
      // 
      this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Name.DataPropertyName = "NameColumn";
      this.Name.HeaderText = "Nazwa";
      this.Name.MinimumWidth = 6;
      this.Name.Name = "Name";
      this.Name.Visible = false;
      this.Name.Width = 79;
      // 
      // Contract
      // 
      this.Contract.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Contract.DataPropertyName = "StreetColumn";
      this.Contract.HeaderText = "Ulica";
      this.Contract.MinimumWidth = 6;
      this.Contract.Name = "Contract";
      this.Contract.Visible = false;
      this.Contract.Width = 68;
      // 
      // HouseNumberColumn
      // 
      this.HouseNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.HouseNumberColumn.HeaderText = "Nr. domu";
      this.HouseNumberColumn.MinimumWidth = 6;
      this.HouseNumberColumn.Name = "HouseNumberColumn";
      this.HouseNumberColumn.Width = 95;
      // 
      // ApartamentNumberColumn
      // 
      this.ApartamentNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ApartamentNumberColumn.HeaderText = "Nr. lokalu";
      this.ApartamentNumberColumn.MinimumWidth = 6;
      this.ApartamentNumberColumn.Name = "ApartamentNumberColumn";
      this.ApartamentNumberColumn.Width = 97;
      // 
      // ZipCodeColumn
      // 
      this.ZipCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.ZipCodeColumn.HeaderText = "Kod pocztowy";
      this.ZipCodeColumn.MinimumWidth = 6;
      this.ZipCodeColumn.Name = "ZipCodeColumn";
      this.ZipCodeColumn.Width = 124;
      // 
      // CityColumn
      // 
      this.CityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CityColumn.HeaderText = "Miasto";
      this.CityColumn.MinimumWidth = 6;
      this.CityColumn.Name = "CityColumn";
      this.CityColumn.Width = 78;
      // 
      // CountryColumn
      // 
      this.CountryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CountryColumn.HeaderText = "Kraj";
      this.CountryColumn.MinimumWidth = 6;
      this.CountryColumn.Name = "CountryColumn";
      this.CountryColumn.Width = 62;
      // 
      // PhoneNumberColumn
      // 
      this.PhoneNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.PhoneNumberColumn.HeaderText = "Nr. telefonu";
      this.PhoneNumberColumn.MinimumWidth = 6;
      this.PhoneNumberColumn.Name = "PhoneNumberColumn";
      this.PhoneNumberColumn.Width = 111;
      // 
      // EmailColumn
      // 
      this.EmailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.EmailColumn.HeaderText = "E-mail";
      this.EmailColumn.MinimumWidth = 6;
      this.EmailColumn.Name = "EmailColumn";
      this.EmailColumn.Width = 76;
      // 
      // WebsideColumn
      // 
      this.WebsideColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.WebsideColumn.HeaderText = "Strona www";
      this.WebsideColumn.MinimumWidth = 6;
      this.WebsideColumn.Name = "WebsideColumn";
      this.WebsideColumn.Width = 110;
      // 
      // ListContractors_panel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Data_dgv);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "ListContractors_panel";
      this.Size = new System.Drawing.Size(1920, 1081);
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView Data_dgv;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button Search_btn;
    private System.Windows.Forms.Button Refresh_btn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    private DataGridViewTextBoxColumn IdDestiny;
    private DataGridViewTextBoxColumn Name;
    private DataGridViewTextBoxColumn Contract;
    private DataGridViewTextBoxColumn HouseNumberColumn;
    private DataGridViewTextBoxColumn ApartamentNumberColumn;
    private DataGridViewTextBoxColumn ZipCodeColumn;
    private DataGridViewTextBoxColumn CityColumn;
    private DataGridViewTextBoxColumn CountryColumn;
    private DataGridViewTextBoxColumn PhoneNumberColumn;
    private DataGridViewTextBoxColumn EmailColumn;
    private DataGridViewTextBoxColumn WebsideColumn;
  }
}
