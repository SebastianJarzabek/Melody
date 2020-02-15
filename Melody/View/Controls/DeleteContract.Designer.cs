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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
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
      this.DeleteContract_panel.Size = new System.Drawing.Size(311, 234);
      this.DeleteContract_panel.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(298, 225);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Usuń kontrakt";
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
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(88, 87);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(200, 30);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(138, 188);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(150, 30);
      this.button1.TabIndex = 2;
      this.button1.Text = "Usuń";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(88, 152);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(200, 30);
      this.textBox2.TabIndex = 4;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
