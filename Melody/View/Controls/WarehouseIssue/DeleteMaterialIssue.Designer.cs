namespace Melody.View.Controls
{
  partial class DeleteMaterialIssue
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
      this.DeleteMaterialIssue_gb = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.DeleteMaterialIssue_btn = new System.Windows.Forms.Button();
      this.MaterialIssueId_tb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.DeleteMaterialIssue_panel = new System.Windows.Forms.Panel();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.DeleteMaterialIssue_gb.SuspendLayout();
      this.DeleteMaterialIssue_panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // DeleteMaterialIssue_gb
      // 
      this.DeleteMaterialIssue_gb.Controls.Add(this.Clear_btn);
      this.DeleteMaterialIssue_gb.Controls.Add(this.label4);
      this.DeleteMaterialIssue_gb.Controls.Add(this.DeleteMaterialIssue_btn);
      this.DeleteMaterialIssue_gb.Controls.Add(this.MaterialIssueId_tb);
      this.DeleteMaterialIssue_gb.Controls.Add(this.label1);
      this.DeleteMaterialIssue_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DeleteMaterialIssue_gb.Location = new System.Drawing.Point(3, 3);
      this.DeleteMaterialIssue_gb.Name = "DeleteMaterialIssue_gb";
      this.DeleteMaterialIssue_gb.Size = new System.Drawing.Size(339, 249);
      this.DeleteMaterialIssue_gb.TabIndex = 2;
      this.DeleteMaterialIssue_gb.TabStop = false;
      this.DeleteMaterialIssue_gb.Text = "Usuń materiał";
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
      // DeleteMaterialIssue_btn
      // 
      this.DeleteMaterialIssue_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DeleteMaterialIssue_btn.Location = new System.Drawing.Point(183, 213);
      this.DeleteMaterialIssue_btn.Name = "DeleteMaterialIssue_btn";
      this.DeleteMaterialIssue_btn.Size = new System.Drawing.Size(150, 30);
      this.DeleteMaterialIssue_btn.TabIndex = 2;
      this.DeleteMaterialIssue_btn.Text = "Usuń";
      this.DeleteMaterialIssue_btn.UseVisualStyleBackColor = true;
      this.DeleteMaterialIssue_btn.Click += new System.EventHandler(this.DeleteMaterialIssue_btn_Click);
      // 
      // MaterialIssueId_tb
      // 
      this.MaterialIssueId_tb.Location = new System.Drawing.Point(133, 87);
      this.MaterialIssueId_tb.Name = "MaterialIssueId_tb";
      this.MaterialIssueId_tb.Size = new System.Drawing.Size(200, 30);
      this.MaterialIssueId_tb.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 94);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nazwe:";
      // 
      // DeleteMaterialIssue_panel
      // 
      this.DeleteMaterialIssue_panel.Controls.Add(this.DeleteMaterialIssue_gb);
      this.DeleteMaterialIssue_panel.Location = new System.Drawing.Point(474, 222);
      this.DeleteMaterialIssue_panel.Name = "DeleteMaterialIssue_panel";
      this.DeleteMaterialIssue_panel.Size = new System.Drawing.Size(345, 255);
      this.DeleteMaterialIssue_panel.TabIndex = 3;
      this.DeleteMaterialIssue_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteMaterialIssue_panel_Paint);
      // 
      // Clear_btn
      // 
      this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Clear_btn.Location = new System.Drawing.Point(6, 213);
      this.Clear_btn.Name = "Clear_btn";
      this.Clear_btn.Size = new System.Drawing.Size(150, 30);
      this.Clear_btn.TabIndex = 8;
      this.Clear_btn.Text = "Wyczyść";
      this.Clear_btn.UseVisualStyleBackColor = true;
      // 
      // DeleteMaterialIssue
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.DeleteMaterialIssue_panel);
      this.Name = "DeleteMaterialIssue";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.DeleteMaterialIssue_gb.ResumeLayout(false);
      this.DeleteMaterialIssue_gb.PerformLayout();
      this.DeleteMaterialIssue_panel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.GroupBox DeleteMaterialIssue_gb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteMaterialIssue_btn;
        private System.Windows.Forms.TextBox MaterialIssueId_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DeleteMaterialIssue_panel;
        private System.Windows.Forms.Button Clear_btn;
    }
}
