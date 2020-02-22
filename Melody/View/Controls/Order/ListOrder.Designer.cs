namespace Melody.View.Controls
{
  partial class ListOrder
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.Data_dgv = new System.Windows.Forms.DataGridView();
      this.Refresh_btn = new System.Windows.Forms.Button();
      this.Search_btn = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.Search_btn);
      this.panel1.Controls.Add(this.Refresh_btn);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1920, 62);
      this.panel1.TabIndex = 0;
      // 
      // Data_dgv
      // 
      this.Data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Data_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Data_dgv.Location = new System.Drawing.Point(0, 62);
      this.Data_dgv.Name = "Data_dgv";
      this.Data_dgv.RowHeadersWidth = 51;
      this.Data_dgv.RowTemplate.Height = 24;
      this.Data_dgv.Size = new System.Drawing.Size(1920, 1018);
      this.Data_dgv.TabIndex = 1;
      // 
      // Refresh_btn
      // 
      this.Refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Refresh_btn.Location = new System.Drawing.Point(16, 26);
      this.Refresh_btn.Name = "Refresh_btn";
      this.Refresh_btn.Size = new System.Drawing.Size(200, 30);
      this.Refresh_btn.TabIndex = 0;
      this.Refresh_btn.Text = "Odśwież";
      this.Refresh_btn.UseVisualStyleBackColor = true;
      // 
      // Search_btn
      // 
      this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Search_btn.Location = new System.Drawing.Point(222, 26);
      this.Search_btn.Name = "Search_btn";
      this.Search_btn.Size = new System.Drawing.Size(200, 30);
      this.Search_btn.TabIndex = 2;
      this.Search_btn.Text = "Szukaj";
      this.Search_btn.UseVisualStyleBackColor = true;
      // 
      // ListOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Data_dgv);
      this.Controls.Add(this.panel1);
      this.Name = "ListOrder";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.DataGridView Data_dgv;
    }
}
