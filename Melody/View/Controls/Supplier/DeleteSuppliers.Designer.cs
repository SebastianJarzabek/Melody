namespace Melody.View.Controls
{
  partial class DeleteSuppliers
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
      this.DeleteContractor_panel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.DeleteConcractor_btn = new System.Windows.Forms.Button();
      this.Name_tb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Parent_panel.SuspendLayout();
      this.DeleteContractor_panel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Parent_panel
      // 
      this.Parent_panel.Controls.Add(this.DeleteContractor_panel);
      this.Parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Parent_panel.Location = new System.Drawing.Point(0, 0);
      this.Parent_panel.Name = "Parent_panel";
      this.Parent_panel.Size = new System.Drawing.Size(1920, 1080);
      this.Parent_panel.TabIndex = 1;
      // 
      // DeleteContractor_panel
      // 
      this.DeleteContractor_panel.Controls.Add(this.groupBox1);
      this.DeleteContractor_panel.Location = new System.Drawing.Point(370, 180);
      this.DeleteContractor_panel.Name = "DeleteContractor_panel";
      this.DeleteContractor_panel.Size = new System.Drawing.Size(358, 266);
      this.DeleteContractor_panel.TabIndex = 0;
      this.DeleteContractor_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteContractor_panel_Paint);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Clear_btn);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.DeleteConcractor_btn);
      this.groupBox1.Controls.Add(this.Name_tb);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(345, 255);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Usuń kontrahenta";
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
      // DeleteConcractor_btn
      // 
      this.DeleteConcractor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DeleteConcractor_btn.Location = new System.Drawing.Point(189, 219);
      this.DeleteConcractor_btn.Name = "DeleteConcractor_btn";
      this.DeleteConcractor_btn.Size = new System.Drawing.Size(150, 30);
      this.DeleteConcractor_btn.TabIndex = 2;
      this.DeleteConcractor_btn.Text = "Usuń";
      this.DeleteConcractor_btn.UseVisualStyleBackColor = true;
      this.DeleteConcractor_btn.Click += new System.EventHandler(this.DeleteConcractor_btn_Click);
      // 
      // Name_tb
      // 
      this.Name_tb.Location = new System.Drawing.Point(88, 87);
      this.Name_tb.Name = "Name_tb";
      this.Name_tb.Size = new System.Drawing.Size(200, 30);
      this.Name_tb.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 94);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nazwa:";
      // 
      // DeleteSuppliers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Parent_panel);
      this.Name = "DeleteSuppliers";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.Parent_panel.ResumeLayout(false);
      this.DeleteContractor_panel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel Parent_panel;
        private System.Windows.Forms.Panel DeleteContractor_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteConcractor_btn;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label1;
    }
}
