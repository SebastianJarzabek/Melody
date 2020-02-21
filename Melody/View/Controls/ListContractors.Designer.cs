namespace Melody.View.Controls
{
  partial class ListContractors
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
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Data_dgv
      // 
      this.Data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDestiny,
            this.Name,
            this.Contract});
      this.Data_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Data_dgv.Location = new System.Drawing.Point(0, 50);
      this.Data_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Data_dgv.Name = "Data_dgv";
      this.Data_dgv.RowHeadersWidth = 51;
      this.Data_dgv.RowTemplate.Height = 24;
      this.Data_dgv.Size = new System.Drawing.Size(1440, 828);
      this.Data_dgv.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.Search_btn);
      this.panel1.Controls.Add(this.Refresh_btn);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1440, 50);
      this.panel1.TabIndex = 2;
      // 
      // Search_btn
      // 
      this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Search_btn.Location = new System.Drawing.Point(166, 21);
      this.Search_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Search_btn.Name = "Search_btn";
      this.Search_btn.Size = new System.Drawing.Size(150, 24);
      this.Search_btn.TabIndex = 2;
      this.Search_btn.Text = "Szukaj";
      this.Search_btn.UseVisualStyleBackColor = true;
      // 
      // Refresh_btn
      // 
      this.Refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Refresh_btn.Location = new System.Drawing.Point(12, 21);
      this.Refresh_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Refresh_btn.Name = "Refresh_btn";
      this.Refresh_btn.Size = new System.Drawing.Size(150, 24);
      this.Refresh_btn.TabIndex = 0;
      this.Refresh_btn.Text = "Odśwież";
      this.Refresh_btn.UseVisualStyleBackColor = true;
      // 
      // IdDestiny
      // 
      this.IdDestiny.DataPropertyName = "IdDestiny";
      this.IdDestiny.HeaderText = "Id";
      this.IdDestiny.Name = "IdDestiny";
      this.IdDestiny.Visible = false;
      // 
      // Name
      // 
      this.Name.DataPropertyName = "Name";
      this.Name.HeaderText = "Nazwa";
      this.Name.Name = "Name";
      this.Name.Visible = false;
      // 
      // Contract
      // 
      this.Contract.DataPropertyName = "Contract";
      this.Contract.HeaderText = "Numer kontraktu";
      this.Contract.Name = "Contract";
      this.Contract.Visible = false;
      // 
      // ListContractors
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Data_dgv);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Size = new System.Drawing.Size(1440, 878);
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView Data_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Refresh_btn;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdDestiny;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    private System.Windows.Forms.DataGridViewTextBoxColumn Contract;
  }
}
