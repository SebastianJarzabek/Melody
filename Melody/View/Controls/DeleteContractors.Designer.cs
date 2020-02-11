namespace Melody.View.Controls
{
  partial class DeleteContractors
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
      this.ContractorChild_panel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.DeleteContractor_btn = new System.Windows.Forms.Button();
      this.Contact_panel.SuspendLayout();
      this.ContractorChild_panel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Contact_panel
      // 
      this.Contact_panel.Controls.Add(this.ContractorChild_panel);
      this.Contact_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Contact_panel.Location = new System.Drawing.Point(0, 0);
      this.Contact_panel.Name = "Contact_panel";
      this.Contact_panel.Size = new System.Drawing.Size(1920, 1080);
      this.Contact_panel.TabIndex = 2;
      // 
      // ContractorChild_panel
      // 
      this.ContractorChild_panel.Controls.Add(this.groupBox1);
      this.ContractorChild_panel.Location = new System.Drawing.Point(305, 250);
      this.ContractorChild_panel.Name = "ContractorChild_panel";
      this.ContractorChild_panel.Size = new System.Drawing.Size(332, 112);
      this.ContractorChild_panel.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.DeleteContractor_btn);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(310, 101);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Podaj Kontrahenta do usunięcia:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(6, 30);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(300, 30);
      this.textBox1.TabIndex = 1;
      // 
      // DeleteContractor_btn
      // 
      this.DeleteContractor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DeleteContractor_btn.Location = new System.Drawing.Point(156, 66);
      this.DeleteContractor_btn.Name = "DeleteContractor_btn";
      this.DeleteContractor_btn.Size = new System.Drawing.Size(150, 30);
      this.DeleteContractor_btn.TabIndex = 0;
      this.DeleteContractor_btn.Text = "Usuń";
      this.DeleteContractor_btn.UseVisualStyleBackColor = true;
      // 
      // DeleteContractors
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Contact_panel);
      this.Name = "DeleteContractors";
      this.Size = new System.Drawing.Size(1920, 1080);
      this.Contact_panel.ResumeLayout(false);
      this.ContractorChild_panel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel Contact_panel;
        private System.Windows.Forms.Panel ContractorChild_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteContractor_btn;
    }
}
