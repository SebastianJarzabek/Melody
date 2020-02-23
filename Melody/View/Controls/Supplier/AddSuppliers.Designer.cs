namespace Melody.View.Controls
{
  partial class AddSuppliers
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
      this.AddContractor_panel = new System.Windows.Forms.Panel();
      this.AddSuppliers_panel = new System.Windows.Forms.Panel();
      this.Validation_lbl = new System.Windows.Forms.Label();
      this.AddSuppliers_btn = new System.Windows.Forms.Button();
      this.General_gb = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.ClearGeneral_btn = new System.Windows.Forms.Button();
      this.Name_tb = new System.Windows.Forms.TextBox();
      this.Adress_gb = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.Street_tb = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.HouseNumber_tb = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.ClearAdress_btn = new System.Windows.Forms.Button();
      this.ApartamentNumber_tb = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.City_tb = new System.Windows.Forms.TextBox();
      this.Country_tb = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.ZipCode_tb = new System.Windows.Forms.TextBox();
      this.Contact_gb = new System.Windows.Forms.GroupBox();
      this.label14 = new System.Windows.Forms.Label();
      this.PhoneNumber_tb = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.Webside_tb = new System.Windows.Forms.TextBox();
      this.Email_tb = new System.Windows.Forms.TextBox();
      this.label16 = new System.Windows.Forms.Label();
      this.ClearContact_btn = new System.Windows.Forms.Button();
      this.AddContractor_panel.SuspendLayout();
      this.AddSuppliers_panel.SuspendLayout();
      this.General_gb.SuspendLayout();
      this.Adress_gb.SuspendLayout();
      this.Contact_gb.SuspendLayout();
      this.SuspendLayout();
      // 
      // AddContractor_panel
      // 
      this.AddContractor_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.AddContractor_panel.Controls.Add(this.AddSuppliers_panel);
      this.AddContractor_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AddContractor_panel.Location = new System.Drawing.Point(0, 0);
      this.AddContractor_panel.Name = "AddContractor_panel";
      this.AddContractor_panel.Size = new System.Drawing.Size(1920, 1080);
      this.AddContractor_panel.TabIndex = 0;
      // 
      // AddSuppliers_panel
      // 
      this.AddSuppliers_panel.Controls.Add(this.Validation_lbl);
      this.AddSuppliers_panel.Controls.Add(this.AddSuppliers_btn);
      this.AddSuppliers_panel.Controls.Add(this.General_gb);
      this.AddSuppliers_panel.Controls.Add(this.Adress_gb);
      this.AddSuppliers_panel.Controls.Add(this.Contact_gb);
      this.AddSuppliers_panel.Location = new System.Drawing.Point(260, 116);
      this.AddSuppliers_panel.Name = "AddSuppliers_panel";
      this.AddSuppliers_panel.Size = new System.Drawing.Size(1075, 600);
      this.AddSuppliers_panel.TabIndex = 7;
      this.AddSuppliers_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddSuppliers_panel_Paint);
      // 
      // Validation_lbl
      // 
      this.Validation_lbl.AutoSize = true;
      this.Validation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Validation_lbl.ForeColor = System.Drawing.Color.Red;
      this.Validation_lbl.Location = new System.Drawing.Point(20, 327);
      this.Validation_lbl.Name = "Validation_lbl";
      this.Validation_lbl.Size = new System.Drawing.Size(0, 20);
      this.Validation_lbl.TabIndex = 8;
      // 
      // AddSuppliers_btn
      // 
      this.AddSuppliers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AddSuppliers_btn.Location = new System.Drawing.Point(941, 327);
      this.AddSuppliers_btn.Name = "AddSuppliers_btn";
      this.AddSuppliers_btn.Size = new System.Drawing.Size(120, 30);
      this.AddSuppliers_btn.TabIndex = 7;
      this.AddSuppliers_btn.Text = "Dodaj";
      this.AddSuppliers_btn.UseVisualStyleBackColor = true;
      this.AddSuppliers_btn.Click += new System.EventHandler(this.AddSuppliers_btn_Click);
      // 
      // General_gb
      // 
      this.General_gb.Controls.Add(this.label1);
      this.General_gb.Controls.Add(this.ClearGeneral_btn);
      this.General_gb.Controls.Add(this.Name_tb);
      this.General_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.General_gb.Location = new System.Drawing.Point(11, 27);
      this.General_gb.Name = "General_gb";
      this.General_gb.Size = new System.Drawing.Size(526, 94);
      this.General_gb.TabIndex = 4;
      this.General_gb.TabStop = false;
      this.General_gb.Text = "Dodaj Kontrahenta";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(8, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 20);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nazwa:";
      // 
      // ClearGeneral_btn
      // 
      this.ClearGeneral_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ClearGeneral_btn.Location = new System.Drawing.Point(400, 60);
      this.ClearGeneral_btn.Name = "ClearGeneral_btn";
      this.ClearGeneral_btn.Size = new System.Drawing.Size(120, 30);
      this.ClearGeneral_btn.TabIndex = 1;
      this.ClearGeneral_btn.Text = " Wyczyść";
      this.ClearGeneral_btn.UseVisualStyleBackColor = true;
      this.ClearGeneral_btn.Click += new System.EventHandler(this.GeneralClear_btn_Click);
      // 
      // Name_tb
      // 
      this.Name_tb.Location = new System.Drawing.Point(220, 24);
      this.Name_tb.Name = "Name_tb";
      this.Name_tb.Size = new System.Drawing.Size(300, 30);
      this.Name_tb.TabIndex = 0;
      // 
      // Adress_gb
      // 
      this.Adress_gb.Controls.Add(this.label7);
      this.Adress_gb.Controls.Add(this.Street_tb);
      this.Adress_gb.Controls.Add(this.label8);
      this.Adress_gb.Controls.Add(this.HouseNumber_tb);
      this.Adress_gb.Controls.Add(this.label9);
      this.Adress_gb.Controls.Add(this.ClearAdress_btn);
      this.Adress_gb.Controls.Add(this.ApartamentNumber_tb);
      this.Adress_gb.Controls.Add(this.label10);
      this.Adress_gb.Controls.Add(this.City_tb);
      this.Adress_gb.Controls.Add(this.Country_tb);
      this.Adress_gb.Controls.Add(this.label12);
      this.Adress_gb.Controls.Add(this.label11);
      this.Adress_gb.Controls.Add(this.ZipCode_tb);
      this.Adress_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Adress_gb.Location = new System.Drawing.Point(537, 27);
      this.Adress_gb.Name = "Adress_gb";
      this.Adress_gb.Size = new System.Drawing.Size(526, 282);
      this.Adress_gb.TabIndex = 6;
      this.Adress_gb.TabStop = false;
      this.Adress_gb.Text = "Adres";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(8, 31);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(52, 20);
      this.label7.TabIndex = 16;
      this.label7.Text = "Ulica:";
      // 
      // Street_tb
      // 
      this.Street_tb.Location = new System.Drawing.Point(220, 24);
      this.Street_tb.Name = "Street_tb";
      this.Street_tb.Size = new System.Drawing.Size(300, 30);
      this.Street_tb.TabIndex = 0;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(8, 67);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(110, 20);
      this.label8.TabIndex = 18;
      this.label8.Text = "Numer domu:";
      // 
      // HouseNumber_tb
      // 
      this.HouseNumber_tb.Location = new System.Drawing.Point(220, 60);
      this.HouseNumber_tb.Name = "HouseNumber_tb";
      this.HouseNumber_tb.Size = new System.Drawing.Size(300, 30);
      this.HouseNumber_tb.TabIndex = 1;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(8, 103);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(112, 20);
      this.label9.TabIndex = 20;
      this.label9.Text = "Numer lokalu:";
      // 
      // ClearAdress_btn
      // 
      this.ClearAdress_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ClearAdress_btn.Location = new System.Drawing.Point(400, 243);
      this.ClearAdress_btn.Name = "ClearAdress_btn";
      this.ClearAdress_btn.Size = new System.Drawing.Size(120, 30);
      this.ClearAdress_btn.TabIndex = 6;
      this.ClearAdress_btn.Text = " Wyczyść";
      this.ClearAdress_btn.UseVisualStyleBackColor = true;
      this.ClearAdress_btn.Click += new System.EventHandler(this.AdressClear_btn_Click);
      // 
      // ApartamentNumber_tb
      // 
      this.ApartamentNumber_tb.Location = new System.Drawing.Point(220, 96);
      this.ApartamentNumber_tb.Name = "ApartamentNumber_tb";
      this.ApartamentNumber_tb.Size = new System.Drawing.Size(300, 30);
      this.ApartamentNumber_tb.TabIndex = 2;
      this.ApartamentNumber_tb.Text = "0";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(8, 139);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(64, 20);
      this.label10.TabIndex = 22;
      this.label10.Text = "Miasto:";
      // 
      // City_tb
      // 
      this.City_tb.Location = new System.Drawing.Point(220, 132);
      this.City_tb.Name = "City_tb";
      this.City_tb.Size = new System.Drawing.Size(300, 30);
      this.City_tb.TabIndex = 3;
      // 
      // Country_tb
      // 
      this.Country_tb.Location = new System.Drawing.Point(220, 203);
      this.Country_tb.Name = "Country_tb";
      this.Country_tb.Size = new System.Drawing.Size(300, 30);
      this.Country_tb.TabIndex = 5;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(8, 175);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(119, 20);
      this.label12.TabIndex = 24;
      this.label12.Text = "Kod-pocztowy:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(8, 210);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(44, 20);
      this.label11.TabIndex = 26;
      this.label11.Text = "Kraj:";
      // 
      // ZipCode_tb
      // 
      this.ZipCode_tb.Location = new System.Drawing.Point(220, 168);
      this.ZipCode_tb.Name = "ZipCode_tb";
      this.ZipCode_tb.Size = new System.Drawing.Size(300, 30);
      this.ZipCode_tb.TabIndex = 4;
      // 
      // Contact_gb
      // 
      this.Contact_gb.Controls.Add(this.label14);
      this.Contact_gb.Controls.Add(this.PhoneNumber_tb);
      this.Contact_gb.Controls.Add(this.label13);
      this.Contact_gb.Controls.Add(this.Webside_tb);
      this.Contact_gb.Controls.Add(this.Email_tb);
      this.Contact_gb.Controls.Add(this.label16);
      this.Contact_gb.Controls.Add(this.ClearContact_btn);
      this.Contact_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Contact_gb.Location = new System.Drawing.Point(11, 142);
      this.Contact_gb.Name = "Contact_gb";
      this.Contact_gb.Size = new System.Drawing.Size(526, 167);
      this.Contact_gb.TabIndex = 5;
      this.Contact_gb.TabStop = false;
      this.Contact_gb.Text = "Dane Kontaktowe";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(7, 31);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(128, 20);
      this.label14.TabIndex = 28;
      this.label14.Text = "Numer telefonu:";
      // 
      // PhoneNumber_tb
      // 
      this.PhoneNumber_tb.Location = new System.Drawing.Point(220, 24);
      this.PhoneNumber_tb.Name = "PhoneNumber_tb";
      this.PhoneNumber_tb.Size = new System.Drawing.Size(300, 30);
      this.PhoneNumber_tb.TabIndex = 0;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(9, 67);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(62, 20);
      this.label13.TabIndex = 30;
      this.label13.Text = "E-mail:";
      // 
      // Webside_tb
      // 
      this.Webside_tb.Location = new System.Drawing.Point(220, 96);
      this.Webside_tb.Name = "Webside_tb";
      this.Webside_tb.Size = new System.Drawing.Size(300, 30);
      this.Webside_tb.TabIndex = 2;
      this.Webside_tb.Text = "Brak";
      // 
      // Email_tb
      // 
      this.Email_tb.Location = new System.Drawing.Point(220, 60);
      this.Email_tb.Name = "Email_tb";
      this.Email_tb.Size = new System.Drawing.Size(300, 30);
      this.Email_tb.TabIndex = 1;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(9, 103);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(154, 20);
      this.label16.TabIndex = 32;
      this.label16.Text = "Strona internetowa:";
      // 
      // ClearContact_btn
      // 
      this.ClearContact_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ClearContact_btn.Location = new System.Drawing.Point(400, 132);
      this.ClearContact_btn.Name = "ClearContact_btn";
      this.ClearContact_btn.Size = new System.Drawing.Size(120, 30);
      this.ClearContact_btn.TabIndex = 3;
      this.ClearContact_btn.Text = " Wyczyść";
      this.ClearContact_btn.UseVisualStyleBackColor = true;
      this.ClearContact_btn.Click += new System.EventHandler(this.ClearContact_btn_Click);
      // 
      // AddSuppliers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.AddContractor_panel);
      this.Name = "AddSuppliers";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.AddContractor_panel.ResumeLayout(false);
      this.AddSuppliers_panel.ResumeLayout(false);
      this.AddSuppliers_panel.PerformLayout();
      this.General_gb.ResumeLayout(false);
      this.General_gb.PerformLayout();
      this.Adress_gb.ResumeLayout(false);
      this.Adress_gb.PerformLayout();
      this.Contact_gb.ResumeLayout(false);
      this.Contact_gb.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel AddContractor_panel;
        private System.Windows.Forms.Panel AddSuppliers_panel;
        private System.Windows.Forms.GroupBox General_gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearGeneral_btn;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.GroupBox Adress_gb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Street_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HouseNumber_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearAdress_btn;
        private System.Windows.Forms.TextBox ApartamentNumber_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox City_tb;
        private System.Windows.Forms.TextBox Country_tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ZipCode_tb;
        private System.Windows.Forms.GroupBox Contact_gb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PhoneNumber_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Webside_tb;
        private System.Windows.Forms.TextBox Email_tb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ClearContact_btn;
        private System.Windows.Forms.Label Validation_lbl;
        private System.Windows.Forms.Button AddSuppliers_btn;
    }
}
