﻿namespace Melody.View.Panel
{
  partial class AboutMe
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
      this.AboutMe_panel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.AboutMe_panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // AboutMe_panel
      // 
      this.AboutMe_panel.Controls.Add(this.label1);
      this.AboutMe_panel.Location = new System.Drawing.Point(240, 223);
      this.AboutMe_panel.Name = "AboutMe_panel";
      this.AboutMe_panel.Size = new System.Drawing.Size(607, 220);
      this.AboutMe_panel.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(18, 33);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(10);
      this.label1.Size = new System.Drawing.Size(570, 145);
      this.label1.TabIndex = 0;
      this.label1.Text = "Jestem studentem 7 semestru \r\nw Wyższej Szkoły Informatyki i Zarządzania\r\n\"COPERN" +
    "ICUS\".\r\n\r\nJest to projekt systemu magazynowego do pracy inżynierskiej.\r\n";
      // 
      // AboutMe
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.AboutMe_panel);
      this.Name = "AboutMe";
      this.Size = new System.Drawing.Size(965, 618);
      this.AboutMe_panel.ResumeLayout(false);
      this.AboutMe_panel.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel AboutMe_panel;
        private System.Windows.Forms.Label label1;
    }
}
