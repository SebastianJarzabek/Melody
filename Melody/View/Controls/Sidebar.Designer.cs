namespace Melody.View.Controls
{
  partial class Sidebar
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
      this.Dodaj = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Dodaj
      // 
      this.Dodaj.Dock = System.Windows.Forms.DockStyle.Top;
      this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Dodaj.Location = new System.Drawing.Point(0, 0);
      this.Dodaj.Name = "Dodaj";
      this.Dodaj.Padding = new System.Windows.Forms.Padding(5);
      this.Dodaj.Size = new System.Drawing.Size(300, 40);
      this.Dodaj.TabIndex = 0;
      this.Dodaj.Text = "Dodaj zamówienie";
      this.Dodaj.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Top;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(0, 40);
      this.button2.Name = "button2";
      this.button2.Padding = new System.Windows.Forms.Padding(5);
      this.button2.Size = new System.Drawing.Size(300, 40);
      this.button2.TabIndex = 1;
      this.button2.Text = "Edytuj Zamówienie";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Top;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(0, 80);
      this.button3.Name = "button3";
      this.button3.Padding = new System.Windows.Forms.Padding(5);
      this.button3.Size = new System.Drawing.Size(300, 40);
      this.button3.TabIndex = 2;
      this.button3.Text = "Lista zamówień";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Dock = System.Windows.Forms.DockStyle.Top;
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(0, 120);
      this.button4.Name = "button4";
      this.button4.Padding = new System.Windows.Forms.Padding(5);
      this.button4.Size = new System.Drawing.Size(300, 40);
      this.button4.TabIndex = 3;
      this.button4.Text = "Usuń zamówienie";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // OrderSidebar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.Dodaj);
      this.Name = "OrderSidebar";
      this.Size = new System.Drawing.Size(300, 165);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
