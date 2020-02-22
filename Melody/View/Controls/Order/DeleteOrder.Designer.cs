namespace Melody.View.Controls
{
  partial class DeleteOrder
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
      this.Parent_panel = new System.Windows.Forms.Panel();
      this.DeleteOrder_panel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.DeleteOrder_btn = new System.Windows.Forms.Button();
      this.OrderNumber_tb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Parent_panel.SuspendLayout();
      this.DeleteOrder_panel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Parent_panel
      // 
      this.Parent_panel.Controls.Add(this.DeleteOrder_panel);
      this.Parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Parent_panel.Location = new System.Drawing.Point(0, 0);
      this.Parent_panel.Name = "Parent_panel";
      this.Parent_panel.Size = new System.Drawing.Size(1920, 1080);
      this.Parent_panel.TabIndex = 1;
      // 
      // DeleteOrder_panel
      // 
      this.DeleteOrder_panel.Controls.Add(this.groupBox1);
      this.DeleteOrder_panel.Location = new System.Drawing.Point(370, 180);
      this.DeleteOrder_panel.Name = "DeleteOrder_panel";
      this.DeleteOrder_panel.Size = new System.Drawing.Size(358, 266);
      this.DeleteOrder_panel.TabIndex = 0;
      this.DeleteOrder_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteOrder_panel_Paint);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Clear_btn);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.DeleteOrder_btn);
      this.groupBox1.Controls.Add(this.OrderNumber_tb);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(345, 255);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Usuń zamówienie";
      this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteOrder_panel_Paint);
      this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // Clear_btn
      // 
      this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Clear_btn.Location = new System.Drawing.Point(6, 219);
      this.Clear_btn.Name = "Clear_btn";
      this.Clear_btn.Size = new System.Drawing.Size(150, 30);
      this.Clear_btn.TabIndex = 7;
      this.Clear_btn.Text = "Wyczyść";
      this.Clear_btn.UseVisualStyleBackColor = true;
      this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(6, 51);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(146, 20);
      this.label4.TabIndex = 6;
      this.label4.Text = "Aby usunąć podaj:";
      // 
      // DeleteOrder_btn
      // 
      this.DeleteOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DeleteOrder_btn.Location = new System.Drawing.Point(189, 219);
      this.DeleteOrder_btn.Name = "DeleteOrder_btn";
      this.DeleteOrder_btn.Size = new System.Drawing.Size(150, 30);
      this.DeleteOrder_btn.TabIndex = 2;
      this.DeleteOrder_btn.Text = "Usuń";
      this.DeleteOrder_btn.UseVisualStyleBackColor = true;
      this.DeleteOrder_btn.Click += new System.EventHandler(this.DeleteOrder_btn_Click);
      // 
      // OrderNumber_tb
      // 
      this.OrderNumber_tb.Location = new System.Drawing.Point(139, 87);
      this.OrderNumber_tb.Name = "OrderNumber_tb";
      this.OrderNumber_tb.Size = new System.Drawing.Size(200, 30);
      this.OrderNumber_tb.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 94);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(134, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nr. zamówienia: ";
      // 
      // DeleteOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Parent_panel);
      this.Name = "DeleteOrder";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteOrder_panel_Paint);
      this.Parent_panel.ResumeLayout(false);
      this.DeleteOrder_panel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel Parent_panel;
        private System.Windows.Forms.Panel DeleteOrder_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteOrder_btn;
        private System.Windows.Forms.TextBox OrderNumber_tb;
        private System.Windows.Forms.Label label1;
    }
}
