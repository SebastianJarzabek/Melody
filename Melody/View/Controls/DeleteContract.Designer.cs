namespace Melody.View.Controls
{
  partial class DeleteContract
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
      this.DeleteContract_panel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.Contract_tb = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.DeleteConcract_btn = new System.Windows.Forms.Button();
      this.Name_tb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Parent_panel.SuspendLayout();
      this.DeleteContract_panel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Parent_panel
      // 
      this.Parent_panel.Controls.Add(this.DeleteContract_panel);
      this.Parent_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Parent_panel.Location = new System.Drawing.Point(0, 0);
      this.Parent_panel.Name = "Parent_panel";
      this.Parent_panel.Size = new System.Drawing.Size(1920, 1080);
      this.Parent_panel.TabIndex = 0;
      // 
      // DeleteContract_panel
      // 
      this.DeleteContract_panel.Controls.Add(this.groupBox1);
      this.DeleteContract_panel.Location = new System.Drawing.Point(370, 180);
      this.DeleteContract_panel.Name = "DeleteContract_panel";
      this.DeleteContract_panel.Size = new System.Drawing.Size(358, 266);
      this.DeleteContract_panel.TabIndex = 0;
      this.DeleteContract_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteContract_panel_Paint);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Clear_btn);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.Contract_tb);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.DeleteConcract_btn);
      this.groupBox1.Controls.Add(this.Name_tb);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(345, 255);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Usuń kontrakt";
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
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(6, 130);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 20);
      this.label3.TabIndex = 5;
      this.label3.Text = "Lub:";
      // 
      // Contract_tb
      // 
      this.Contract_tb.Location = new System.Drawing.Point(88, 152);
      this.Contract_tb.Name = "Contract_tb";
      this.Contract_tb.Size = new System.Drawing.Size(200, 30);
      this.Contract_tb.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(6, 159);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Kontrakt:";
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
      // DeleteContract
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Parent_panel);
      this.Name = "DeleteContract";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.Parent_panel.ResumeLayout(false);
      this.DeleteContract_panel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel Parent_panel;
        private System.Windows.Forms.Panel DeleteContract_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contract_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteConcract_btn;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_btn;
    }
}
