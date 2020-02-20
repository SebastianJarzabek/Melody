namespace Melody.View.Panel
{
  partial class Contact
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
      this.Contact_panel = new System.Windows.Forms.Panel();
      this.ContactChild_palen = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.Contact_panel.SuspendLayout();
      this.ContactChild_palen.SuspendLayout();
      this.SuspendLayout();
      // 
      // Contact_panel
      // 
      this.Contact_panel.BackgroundImage = global::Melody.Properties.Resources.Login;
      this.Contact_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.Contact_panel.Controls.Add(this.ContactChild_palen);
      this.Contact_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Contact_panel.Location = new System.Drawing.Point(0, 0);
      this.Contact_panel.Name = "Contact_panel";
      this.Contact_panel.Size = new System.Drawing.Size(1920, 1080);
      this.Contact_panel.TabIndex = 0;
      // 
      // ContactChild_palen
      // 
      this.ContactChild_palen.BackColor = System.Drawing.Color.SkyBlue;
      this.ContactChild_palen.Controls.Add(this.label5);
      this.ContactChild_palen.Controls.Add(this.label4);
      this.ContactChild_palen.Controls.Add(this.label3);
      this.ContactChild_palen.Controls.Add(this.label2);
      this.ContactChild_palen.Controls.Add(this.label6);
      this.ContactChild_palen.Location = new System.Drawing.Point(300, 250);
      this.ContactChild_palen.Name = "ContactChild_palen";
      this.ContactChild_palen.Size = new System.Drawing.Size(600, 250);
      this.ContactChild_palen.TabIndex = 5;
      this.ContactChild_palen.Paint += new System.Windows.Forms.PaintEventHandler(this.ContactChild_palen_Paint);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(43, 148);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(168, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "Tel: +48 794-331-279";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(42, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(520, 25);
      this.label4.TabIndex = 3;
      this.label4.Text = "Wyższa Szkoła Informatyki i Zarządzania \"COPERNICUS\"";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(43, 128);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(312, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "E-mail: sebastian.jarzabek@outlook.com";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(43, 108);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(126, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nr indexu: 6200";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(42, 83);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(186, 25);
      this.label6.TabIndex = 0;
      this.label6.Text = "Sebastian Jarząbek";
      // 
      // Contact
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Contact_panel);
      this.Name = "Contact";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.Contact_panel.ResumeLayout(false);
      this.ContactChild_palen.ResumeLayout(false);
      this.ContactChild_palen.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel Contact_panel;
        private System.Windows.Forms.Panel ContactChild_palen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
