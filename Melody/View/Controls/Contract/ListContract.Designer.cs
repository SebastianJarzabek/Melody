namespace Melody.View.Controls
{
  partial class ListContract
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
      this.IdDestiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NameColumne = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ContractColumne = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.Search_btn = new System.Windows.Forms.Button();
      this.Refresh_btn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Data_dgv
      // 
      this.Data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDestiny,
            this.NameColumne,
            this.ContractColumne});
      this.Data_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Data_dgv.Location = new System.Drawing.Point(0, 76);
      this.Data_dgv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.Data_dgv.Name = "Data_dgv";
      this.Data_dgv.RowHeadersWidth = 51;
      this.Data_dgv.RowTemplate.Height = 24;
      this.Data_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.Data_dgv.Size = new System.Drawing.Size(1920, 1005);
      this.Data_dgv.TabIndex = 3;
      // 
      // IdDestiny
      // 
      this.IdDestiny.DataPropertyName = "IdDestiny";
      this.IdDestiny.HeaderText = "Column1";
      this.IdDestiny.MinimumWidth = 6;
      this.IdDestiny.Name = "IdDestiny";
      this.IdDestiny.Visible = false;
      this.IdDestiny.Width = 125;
      // 
      // NameColumne
      // 
      this.NameColumne.DataPropertyName = "Name";
      this.NameColumne.HeaderText = "Nazwa";
      this.NameColumne.MinimumWidth = 6;
      this.NameColumne.Name = "NameColumne";
      this.NameColumne.Width = 125;
      // 
      // ContractColumne
      // 
      this.ContractColumne.DataPropertyName = "Contract";
      this.ContractColumne.HeaderText = "Numer kontraktu";
      this.ContractColumne.MinimumWidth = 6;
      this.ContractColumne.Name = "ContractColumne";
      this.ContractColumne.Width = 125;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.Search_btn);
      this.panel1.Controls.Add(this.Refresh_btn);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1920, 76);
      this.panel1.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(209, 43);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(400, 27);
      this.textBox1.TabIndex = 6;
      // 
      // Search_btn
      // 
      this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Search_btn.Location = new System.Drawing.Point(615, 41);
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
      this.Refresh_btn.Location = new System.Drawing.Point(3, 41);
      this.Refresh_btn.Name = "Refresh_btn";
      this.Refresh_btn.Size = new System.Drawing.Size(200, 30);
      this.Refresh_btn.TabIndex = 4;
      this.Refresh_btn.Text = "Odśwież";
      this.Refresh_btn.UseVisualStyleBackColor = true;
      // 
      // ListContract
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Data_dgv);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "ListContract";
      this.Size = new System.Drawing.Size(1920, 1081);
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView Data_dgv;
        private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdDestiny;
    private System.Windows.Forms.DataGridViewTextBoxColumn NameColumne;
    private System.Windows.Forms.DataGridViewTextBoxColumn ContractColumne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Refresh_btn;
    }
}
