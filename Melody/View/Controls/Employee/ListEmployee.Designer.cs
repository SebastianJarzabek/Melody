namespace Melody.View.Controls
{
  partial class ListEmployee
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
      this.Data_dgv = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.Search_btn = new System.Windows.Forms.Button();
      this.Refresh_btn = new System.Windows.Forms.Button();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.houseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.apartmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.zipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.webside = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Data_dgv
      // 
      this.Data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.surname,
            this.departament,
            this.position,
            this.login,
            this.password,
            this.street,
            this.houseNumber,
            this.apartmentNumber,
            this.city,
            this.zipCode,
            this.country,
            this.phoneNumber,
            this.email,
            this.webside});
      this.Data_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Data_dgv.Location = new System.Drawing.Point(0, 62);
      this.Data_dgv.Name = "Data_dgv";
      this.Data_dgv.RowHeadersWidth = 51;
      this.Data_dgv.RowTemplate.Height = 24;
      this.Data_dgv.Size = new System.Drawing.Size(1920, 1018);
      this.Data_dgv.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.Search_btn);
      this.panel1.Controls.Add(this.Refresh_btn);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1920, 62);
      this.panel1.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(209, 28);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(400, 27);
      this.textBox1.TabIndex = 6;
      // 
      // Search_btn
      // 
      this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Search_btn.Location = new System.Drawing.Point(615, 26);
      this.Search_btn.Name = "Search_btn";
      this.Search_btn.Size = new System.Drawing.Size(200, 30);
      this.Search_btn.TabIndex = 5;
      this.Search_btn.Text = "Szukaj";
      this.Search_btn.UseVisualStyleBackColor = true;
      // 
      // Refresh_btn
      // 
      this.Refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Refresh_btn.Location = new System.Drawing.Point(3, 26);
      this.Refresh_btn.Name = "Refresh_btn";
      this.Refresh_btn.Size = new System.Drawing.Size(200, 30);
      this.Refresh_btn.TabIndex = 4;
      this.Refresh_btn.Text = "Odśwież";
      this.Refresh_btn.UseVisualStyleBackColor = true;
      this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      this.Id.HeaderText = "Id";
      this.Id.MinimumWidth = 6;
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Width = 125;
      // 
      // name
      // 
      this.name.DataPropertyName = "Name";
      this.name.HeaderText = "Imię";
      this.name.MinimumWidth = 6;
      this.name.Name = "name";
      this.name.ReadOnly = true;
      this.name.Width = 125;
      // 
      // surname
      // 
      this.surname.DataPropertyName = "Surname";
      this.surname.HeaderText = "Nazwisko";
      this.surname.MinimumWidth = 6;
      this.surname.Name = "surname";
      this.surname.ReadOnly = true;
      this.surname.Width = 125;
      // 
      // departament
      // 
      this.departament.DataPropertyName = "Departament";
      this.departament.HeaderText = "Dział";
      this.departament.MinimumWidth = 6;
      this.departament.Name = "departament";
      this.departament.ReadOnly = true;
      this.departament.Width = 125;
      // 
      // position
      // 
      this.position.DataPropertyName = "Position";
      this.position.HeaderText = "Stanowisko";
      this.position.MinimumWidth = 6;
      this.position.Name = "position";
      this.position.ReadOnly = true;
      this.position.Width = 125;
      // 
      // login
      // 
      this.login.DataPropertyName = "Login";
      this.login.HeaderText = "Login";
      this.login.MinimumWidth = 6;
      this.login.Name = "login";
      this.login.ReadOnly = true;
      this.login.Width = 125;
      // 
      // password
      // 
      this.password.DataPropertyName = "Password";
      this.password.HeaderText = "Hasło";
      this.password.MinimumWidth = 6;
      this.password.Name = "password";
      this.password.ReadOnly = true;
      this.password.Width = 125;
      // 
      // street
      // 
      this.street.DataPropertyName = "Street";
      this.street.HeaderText = "Ulica";
      this.street.MinimumWidth = 6;
      this.street.Name = "street";
      this.street.ReadOnly = true;
      this.street.Width = 125;
      // 
      // houseNumber
      // 
      this.houseNumber.DataPropertyName = "HouseNumber";
      this.houseNumber.HeaderText = "Nr. domu";
      this.houseNumber.MinimumWidth = 6;
      this.houseNumber.Name = "houseNumber";
      this.houseNumber.ReadOnly = true;
      this.houseNumber.Width = 125;
      // 
      // apartmentNumber
      // 
      this.apartmentNumber.DataPropertyName = "ApartmentNumber";
      this.apartmentNumber.HeaderText = "Nr. lokalu";
      this.apartmentNumber.MinimumWidth = 6;
      this.apartmentNumber.Name = "apartmentNumber";
      this.apartmentNumber.ReadOnly = true;
      this.apartmentNumber.Width = 125;
      // 
      // city
      // 
      this.city.DataPropertyName = "City";
      this.city.HeaderText = "Miasto";
      this.city.MinimumWidth = 6;
      this.city.Name = "city";
      this.city.ReadOnly = true;
      this.city.Width = 125;
      // 
      // zipCode
      // 
      this.zipCode.DataPropertyName = "ZipCode";
      this.zipCode.HeaderText = "Kod-pocztowy";
      this.zipCode.MinimumWidth = 6;
      this.zipCode.Name = "zipCode";
      this.zipCode.ReadOnly = true;
      this.zipCode.Width = 125;
      // 
      // country
      // 
      this.country.DataPropertyName = "Country";
      this.country.HeaderText = "Kraj";
      this.country.MinimumWidth = 6;
      this.country.Name = "country";
      this.country.ReadOnly = true;
      this.country.Width = 125;
      // 
      // phoneNumber
      // 
      this.phoneNumber.DataPropertyName = "PhoneNumber";
      this.phoneNumber.HeaderText = "Telefon";
      this.phoneNumber.MinimumWidth = 6;
      this.phoneNumber.Name = "phoneNumber";
      this.phoneNumber.ReadOnly = true;
      this.phoneNumber.Width = 125;
      // 
      // email
      // 
      this.email.DataPropertyName = "Email";
      this.email.HeaderText = "E-mail";
      this.email.MinimumWidth = 6;
      this.email.Name = "email";
      this.email.ReadOnly = true;
      this.email.Width = 125;
      // 
      // webside
      // 
      this.webside.DataPropertyName = "Webside";
      this.webside.HeaderText = "Strona internetowa";
      this.webside.MinimumWidth = 6;
      this.webside.Name = "webside";
      this.webside.ReadOnly = true;
      this.webside.Width = 125;
      // 
      // ListEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Data_dgv);
      this.Controls.Add(this.panel1);
      this.Name = "ListEmployee";
      this.Size = new System.Drawing.Size(1920, 1080);
      ((System.ComponentModel.ISupportInitialize)(this.Data_dgv)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView Data_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn departament;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn webside;
    }
}
