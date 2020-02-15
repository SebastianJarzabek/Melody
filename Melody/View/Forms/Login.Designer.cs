namespace Melody.View.Window
{
  partial class Login
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Password_tb = new System.Windows.Forms.TextBox();
      this.PasswordValidation_lbl = new System.Windows.Forms.Label();
      this.LoginValidation_lbl = new System.Windows.Forms.Label();
      this.Clear_btn = new System.Windows.Forms.Button();
      this.Close_btn = new System.Windows.Forms.Button();
      this.Login_btn = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.Welcome_lbl = new System.Windows.Forms.Label();
      this.Login_tb = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Login_panel = new System.Windows.Forms.Panel();
      this.Login_panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // Password_tb
      // 
      this.Password_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.Password_tb.Location = new System.Drawing.Point(115, 118);
      this.Password_tb.Name = "Password_tb";
      this.Password_tb.PasswordChar = '*';
      this.Password_tb.Size = new System.Drawing.Size(380, 30);
      this.Password_tb.TabIndex = 1;
      // 
      // PasswordValidation_lbl
      // 
      this.PasswordValidation_lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.PasswordValidation_lbl.AutoSize = true;
      this.PasswordValidation_lbl.Location = new System.Drawing.Point(123, 153);
      this.PasswordValidation_lbl.Name = "PasswordValidation_lbl";
      this.PasswordValidation_lbl.Size = new System.Drawing.Size(0, 25);
      this.PasswordValidation_lbl.TabIndex = 10;
      // 
      // LoginValidation_lbl
      // 
      this.LoginValidation_lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.LoginValidation_lbl.AutoSize = true;
      this.LoginValidation_lbl.Location = new System.Drawing.Point(123, 86);
      this.LoginValidation_lbl.Name = "LoginValidation_lbl";
      this.LoginValidation_lbl.Size = new System.Drawing.Size(0, 25);
      this.LoginValidation_lbl.TabIndex = 9;
      // 
      // Clear_btn
      // 
      this.Clear_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Clear_btn.Location = new System.Drawing.Point(5, 180);
      this.Clear_btn.Name = "Clear_btn";
      this.Clear_btn.Padding = new System.Windows.Forms.Padding(2);
      this.Clear_btn.Size = new System.Drawing.Size(150, 40);
      this.Clear_btn.TabIndex = 5;
      this.Clear_btn.Text = "Wyczyść";
      this.Clear_btn.UseVisualStyleBackColor = true;
      this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
      // 
      // Close_btn
      // 
      this.Close_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Close_btn.Location = new System.Drawing.Point(345, 180);
      this.Close_btn.Name = "Close_btn";
      this.Close_btn.Padding = new System.Windows.Forms.Padding(2);
      this.Close_btn.Size = new System.Drawing.Size(150, 40);
      this.Close_btn.TabIndex = 3;
      this.Close_btn.Text = "Wyjdź";
      this.Close_btn.UseVisualStyleBackColor = true;
      this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
      // 
      // Login_btn
      // 
      this.Login_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Login_btn.Location = new System.Drawing.Point(189, 180);
      this.Login_btn.Name = "Login_btn";
      this.Login_btn.Padding = new System.Windows.Forms.Padding(2);
      this.Login_btn.Size = new System.Drawing.Size(150, 40);
      this.Login_btn.TabIndex = 2;
      this.Login_btn.Text = "Zaloguj";
      this.Login_btn.UseVisualStyleBackColor = true;
      this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
      // 
      // label3
      // 
      this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(7, 121);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 25);
      this.label3.TabIndex = 7;
      this.label3.Text = "Hasło:";
      // 
      // Welcome_lbl
      // 
      this.Welcome_lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.Welcome_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Welcome_lbl.AutoSize = true;
      this.Welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Welcome_lbl.Location = new System.Drawing.Point(125, 2);
      this.Welcome_lbl.Name = "Welcome_lbl";
      this.Welcome_lbl.Size = new System.Drawing.Size(231, 36);
      this.Welcome_lbl.TabIndex = 3;
      this.Welcome_lbl.Text = "Witaj w Melody";
      this.Welcome_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Login_tb
      // 
      this.Login_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.Login_tb.Location = new System.Drawing.Point(115, 53);
      this.Login_tb.Name = "Login_tb";
      this.Login_tb.Size = new System.Drawing.Size(380, 30);
      this.Login_tb.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(7, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 25);
      this.label2.TabIndex = 5;
      this.label2.Text = "Login:";
      // 
      // Login_panel
      // 
      this.Login_panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.Login_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Login_panel.Controls.Add(this.Password_tb);
      this.Login_panel.Controls.Add(this.PasswordValidation_lbl);
      this.Login_panel.Controls.Add(this.LoginValidation_lbl);
      this.Login_panel.Controls.Add(this.Clear_btn);
      this.Login_panel.Controls.Add(this.Close_btn);
      this.Login_panel.Controls.Add(this.Login_btn);
      this.Login_panel.Controls.Add(this.label3);
      this.Login_panel.Controls.Add(this.Welcome_lbl);
      this.Login_panel.Controls.Add(this.Login_tb);
      this.Login_panel.Controls.Add(this.label2);
      this.Login_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Login_panel.Location = new System.Drawing.Point(87, 92);
      this.Login_panel.MaximumSize = new System.Drawing.Size(500, 225);
      this.Login_panel.MinimumSize = new System.Drawing.Size(500, 225);
      this.Login_panel.Name = "Login_panel";
      this.Login_panel.Padding = new System.Windows.Forms.Padding(2);
      this.Login_panel.Size = new System.Drawing.Size(500, 225);
      this.Login_panel.TabIndex = 12;
      this.Login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_panel_Paint);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Melody.Properties.Resources.Login;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(782, 453);
      this.Controls.Add(this.Login_panel);
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Melody - logowanie";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Login_panel.ResumeLayout(false);
      this.Login_panel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox Password_tb;
    private System.Windows.Forms.Label PasswordValidation_lbl;
    private System.Windows.Forms.Label LoginValidation_lbl;
    private System.Windows.Forms.Button Clear_btn;
    private System.Windows.Forms.Button Close_btn;
    private System.Windows.Forms.Button Login_btn;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label Welcome_lbl;
    private System.Windows.Forms.TextBox Login_tb;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel Login_panel;
  }
}