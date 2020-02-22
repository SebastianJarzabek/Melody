namespace Melody.View.Panel
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
      this.AboutMeChild_panel = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.AboutMe_panel.SuspendLayout();
      this.AboutMeChild_panel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // AboutMe_panel
      // 
      this.AboutMe_panel.BackgroundImage = global::Melody.Properties.Resources.Login;
      this.AboutMe_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.AboutMe_panel.Controls.Add(this.AboutMeChild_panel);
      this.AboutMe_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AboutMe_panel.Location = new System.Drawing.Point(0, 0);
      this.AboutMe_panel.Name = "AboutMe_panel";
      this.AboutMe_panel.Size = new System.Drawing.Size(1920, 1080);
      this.AboutMe_panel.TabIndex = 0;
      // 
      // AboutMeChild_panel
      // 
      this.AboutMeChild_panel.BackColor = System.Drawing.SystemColors.Control;
      this.AboutMeChild_panel.Controls.Add(this.label2);
      this.AboutMeChild_panel.Controls.Add(this.pictureBox1);
      this.AboutMeChild_panel.Controls.Add(this.label1);
      this.AboutMeChild_panel.Location = new System.Drawing.Point(600, 400);
      this.AboutMeChild_panel.Name = "AboutMeChild_panel";
      this.AboutMeChild_panel.Size = new System.Drawing.Size(600, 250);
      this.AboutMeChild_panel.TabIndex = 1;
      this.AboutMeChild_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutMeChild_panel_Paint);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(5, 224);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "2020r.";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
      this.pictureBox1.Image = global::Melody.Properties.Resources.me;
      this.pictureBox1.Location = new System.Drawing.Point(439, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(158, 109);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 3);
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
      this.Size = new System.Drawing.Size(1920, 1080);
      this.AboutMe_panel.ResumeLayout(false);
      this.AboutMeChild_panel.ResumeLayout(false);
      this.AboutMeChild_panel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel AboutMe_panel;
        private System.Windows.Forms.Panel AboutMeChild_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
