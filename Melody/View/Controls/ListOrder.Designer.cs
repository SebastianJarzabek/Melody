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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.Sidebar_panel = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.Search_btn = new System.Windows.Forms.Button();
      this.Search_tb = new System.Windows.Forms.TextBox();
      this.SearchPanel = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SearchPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(3, 93);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.Size = new System.Drawing.Size(1510, 984);
      this.dataGridView1.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.Sidebar_panel);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
      this.splitContainer1.Size = new System.Drawing.Size(1920, 1080);
      this.splitContainer1.SplitterDistance = 400;
      this.splitContainer1.TabIndex = 1;
      // 
      // Sidebar_panel
      // 
      this.Sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Sidebar_panel.Location = new System.Drawing.Point(0, 0);
      this.Sidebar_panel.Name = "Sidebar_panel";
      this.Sidebar_panel.Size = new System.Drawing.Size(400, 1080);
      this.Sidebar_panel.TabIndex = 3;
      this.Sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_panel_Paint);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.366014F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.63399F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1516, 1080);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.SearchPanel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1510, 84);
      this.panel1.TabIndex = 1;
      // 
      // Search_btn
      // 
      this.Search_btn.Dock = System.Windows.Forms.DockStyle.Right;
      this.Search_btn.Location = new System.Drawing.Point(298, 0);
      this.Search_btn.Name = "Search_btn";
      this.Search_btn.Size = new System.Drawing.Size(150, 25);
      this.Search_btn.TabIndex = 0;
      this.Search_btn.Text = "Szukaj";
      this.Search_btn.UseVisualStyleBackColor = true;
      // 
      // Search_tb
      // 
      this.Search_tb.Dock = System.Windows.Forms.DockStyle.Left;
      this.Search_tb.Location = new System.Drawing.Point(0, 0);
      this.Search_tb.Name = "Search_tb";
      this.Search_tb.Size = new System.Drawing.Size(300, 22);
      this.Search_tb.TabIndex = 1;
      // 
      // SearchPanel
      // 
      this.SearchPanel.Controls.Add(this.button1);
      this.SearchPanel.Controls.Add(this.textBox1);
      this.SearchPanel.Location = new System.Drawing.Point(531, 30);
      this.SearchPanel.Name = "SearchPanel";
      this.SearchPanel.Size = new System.Drawing.Size(448, 25);
      this.SearchPanel.TabIndex = 4;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Right;
      this.button1.Location = new System.Drawing.Point(298, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(150, 25);
      this.button1.TabIndex = 0;
      this.button1.Text = "Szukaj";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.textBox1.Location = new System.Drawing.Point(0, 0);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(300, 22);
      this.textBox1.TabIndex = 1;
      // 
      // ListOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "ListOrder";
      this.Size = new System.Drawing.Size(1920, 1080);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.SearchPanel.ResumeLayout(false);
      this.SearchPanel.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Sidebar_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Button Search_btn;
    private System.Windows.Forms.Panel SearchPanel;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
  }
}
