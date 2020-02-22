namespace Melody.View.Controls
{
  partial class EditContract
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
      this.EditContract_gb = new System.Windows.Forms.GroupBox();
      this.Validation_lbl = new System.Windows.Forms.Label();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.EditContract_btn = new System.Windows.Forms.Button();
      this.Contract_tb = new System.Windows.Forms.TextBox();
      this.Name_tb = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.EditContract_gb.SuspendLayout();
      this.SuspendLayout();
      // 
      // EditContract_gb
      // 
      this.EditContract_gb.Controls.Add(this.Validation_lbl);
      this.EditContract_gb.Controls.Add(this.Clear_btn);
      this.EditContract_gb.Controls.Add(this.label1);
      this.EditContract_gb.Controls.Add(this.EditContract_btn);
      this.EditContract_gb.Controls.Add(this.Contract_tb);
      this.EditContract_gb.Controls.Add(this.Name_tb);
      this.EditContract_gb.Controls.Add(this.label2);
      this.EditContract_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditContract_gb.Location = new System.Drawing.Point(8, 8);
      this.EditContract_gb.Name = "EditContract_gb";
      this.EditContract_gb.Size = new System.Drawing.Size(376, 287);
      this.EditContract_gb.TabIndex = 8;
      this.EditContract_gb.TabStop = false;
      this.EditContract_gb.Text = "Edytuj Kontrakt";
      this.EditContract_gb.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateContract_gb_Paint);
      // 
      // Validation_lbl
      // 
      this.Validation_lbl.AutoSize = true;
      this.Validation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Validation_lbl.ForeColor = System.Drawing.Color.Red;
      this.Validation_lbl.Location = new System.Drawing.Point(7, 126);
      this.Validation_lbl.Name = "Validation_lbl";
      this.Validation_lbl.Size = new System.Drawing.Size(0, 20);
      this.Validation_lbl.TabIndex = 7;
      // 
      // Clear_btn
      // 
      this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Clear_btn.Location = new System.Drawing.Point(59, 241);
      this.Clear_btn.Name = "Clear_btn";
      this.Clear_btn.Size = new System.Drawing.Size(150, 30);
      this.Clear_btn.TabIndex = 4;
      this.Clear_btn.Text = "Wyczyść";
      this.Clear_btn.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(7, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Nazwa:";
      // 
      // EditContract_btn
      // 
      this.EditContract_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditContract_btn.Location = new System.Drawing.Point(210, 241);
      this.EditContract_btn.Name = "EditContract_btn";
      this.EditContract_btn.Size = new System.Drawing.Size(150, 30);
      this.EditContract_btn.TabIndex = 3;
      this.EditContract_btn.Text = "Edytuj";
      this.EditContract_btn.UseVisualStyleBackColor = true;
      // 
      // Contract_tb
      // 
      this.Contract_tb.Location = new System.Drawing.Point(159, 76);
      this.Contract_tb.Name = "Contract_tb";
      this.Contract_tb.Size = new System.Drawing.Size(200, 30);
      this.Contract_tb.TabIndex = 2;
      // 
      // Name_tb
      // 
      this.Name_tb.Location = new System.Drawing.Point(160, 40);
      this.Name_tb.Name = "Name_tb";
      this.Name_tb.Size = new System.Drawing.Size(200, 30);
      this.Name_tb.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(5, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(137, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Numer kontraktu:";
      // 
      // EditContract
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.EditContract_gb);
      this.Name = "EditContract";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.EditContract_gb.ResumeLayout(false);
      this.EditContract_gb.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.GroupBox EditContract_gb;
        private System.Windows.Forms.Label Validation_lbl;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditContract_btn;
        private System.Windows.Forms.TextBox Contract_tb;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label2;
    }
}
