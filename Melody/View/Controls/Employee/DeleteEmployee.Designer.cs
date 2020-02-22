namespace Melody.View.Controls
{
  partial class DeleteEmployee
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
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.Surname_tb = new System.Windows.Forms.TextBox();
      this.DeleteConcract_btn = new System.Windows.Forms.Button();
      this.Name_tb = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.DeleteEmployee_panel = new System.Windows.Forms.Panel();
      this.Parent_panel = new System.Windows.Forms.Panel();
      this.groupBox1.SuspendLayout();
      this.DeleteEmployee_panel.SuspendLayout();
      this.Parent_panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(9, 159);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(86, 20);
      this.label6.TabIndex = 3;
      this.label6.Text = "Nazwisko:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(9, 94);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(45, 20);
      this.label7.TabIndex = 0;
      this.label7.Text = "Imie:";
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
      // Surname_tb
      // 
      this.Surname_tb.Location = new System.Drawing.Point(139, 152);
      this.Surname_tb.Name = "Surname_tb";
      this.Surname_tb.Size = new System.Drawing.Size(200, 30);
      this.Surname_tb.TabIndex = 4;
      // 
      // DeleteConcract_btn
      // 
      this.DeleteConcract_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DeleteConcract_btn.Location = new System.Drawing.Point(189, 219);
      this.DeleteConcract_btn.Name = "DeleteConcract_btn";
      this.DeleteConcract_btn.Size = new System.Drawing.Size(150, 30);
      this.DeleteConcract_btn.TabIndex = 2;
      this.DeleteConcract_btn.Text = "Usuń";
      this.DeleteConcract_btn.UseVisualStyleBackColor = true;
      this.DeleteConcract_btn.Click += new System.EventHandler(this.DeleteConcract_btn_Click);
      // 
      // Name_tb
      // 
      this.Name_tb.Location = new System.Drawing.Point(139, 87);
      this.Name_tb.Name = "Name_tb";
      this.Name_tb.Size = new System.Drawing.Size(200, 30);
      this.Name_tb.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Clear_btn);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.Surname_tb);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.DeleteConcract_btn);
      this.groupBox1.Controls.Add(this.Name_tb);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(345, 255);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Usuń pracownika";
      // 
      // DeleteEmployee_panel
      // 
      this.DeleteEmployee_panel.Controls.Add(this.groupBox1);
      this.DeleteEmployee_panel.Location = new System.Drawing.Point(370, 180);
      this.DeleteEmployee_panel.Name = "DeleteEmployee_panel";
      this.DeleteEmployee_panel.Size = new System.Drawing.Size(358, 266);
      this.DeleteEmployee_panel.TabIndex = 0;
      this.DeleteEmployee_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteEmployee_panel_Paint);
      // 
      // Parent_panel
      // 
      this.Parent_panel.Controls.Add(this.DeleteEmployee_panel);
      this.Parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Parent_panel.Location = new System.Drawing.Point(0, 0);
      this.Parent_panel.Name = "Parent_panel";
      this.Parent_panel.Size = new System.Drawing.Size(1920, 1080);
      this.Parent_panel.TabIndex = 1;
      // 
      // DeleteEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Parent_panel);
      this.Name = "DeleteEmployee";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.DeleteEmployee_panel.ResumeLayout(false);
      this.Parent_panel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Surname_tb;
        private System.Windows.Forms.Button DeleteConcract_btn;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel DeleteEmployee_panel;
        private System.Windows.Forms.Panel Parent_panel;
    }
}
