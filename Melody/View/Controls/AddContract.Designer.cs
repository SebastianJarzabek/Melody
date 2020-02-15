namespace Melody.View.Controls
{
  partial class AddContract
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
      this.AddContract_panel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.AddContract_btn = new System.Windows.Forms.Button();
      this.Contract_tb = new System.Windows.Forms.TextBox();
      this.Name_tb = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.AddContract_panel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // AddContract_panel
      // 
      this.AddContract_panel.Controls.Add(this.groupBox1);
      this.AddContract_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AddContract_panel.Location = new System.Drawing.Point(0, 0);
      this.AddContract_panel.Name = "AddContract_panel";
      this.AddContract_panel.Size = new System.Drawing.Size(1920, 1080);
      this.AddContract_panel.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Clear_btn);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.AddContract_btn);
      this.groupBox1.Controls.Add(this.Contract_tb);
      this.groupBox1.Controls.Add(this.Name_tb);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(730, 381);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(339, 180);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dodaj Kontrakt";
      this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Nazwa:";
      // 
      // AddContract_btn
      // 
      this.AddContract_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AddContract_btn.Location = new System.Drawing.Point(183, 144);
      this.AddContract_btn.Name = "AddContract_btn";
      this.AddContract_btn.Size = new System.Drawing.Size(150, 30);
      this.AddContract_btn.TabIndex = 0;
      this.AddContract_btn.Text = "Dodaj";
      this.AddContract_btn.UseVisualStyleBackColor = true;
      this.AddContract_btn.Click += new System.EventHandler(this.AddContract_btn_Click);
      // 
      // Contract_tb
      // 
      this.Contract_tb.Location = new System.Drawing.Point(77, 99);
      this.Contract_tb.Name = "Contract_tb";
      this.Contract_tb.Size = new System.Drawing.Size(200, 30);
      this.Contract_tb.TabIndex = 4;
      // 
      // Name_tb
      // 
      this.Name_tb.Location = new System.Drawing.Point(77, 32);
      this.Name_tb.Name = "Name_tb";
      this.Name_tb.Size = new System.Drawing.Size(200, 30);
      this.Name_tb.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(7, 104);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Numer:";
      // 
      // Clear_btn
      // 
      this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Clear_btn.Location = new System.Drawing.Point(27, 144);
      this.Clear_btn.Name = "Clear_btn";
      this.Clear_btn.Size = new System.Drawing.Size(150, 30);
      this.Clear_btn.TabIndex = 6;
      this.Clear_btn.Text = "Wyczyść";
      this.Clear_btn.UseVisualStyleBackColor = true;
      this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
      // 
      // AddContract
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.AddContract_panel);
      this.Name = "AddContract";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.AddContract_panel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel AddContract_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddContract_btn;
        private System.Windows.Forms.TextBox Contract_tb;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_btn;
    }
}
