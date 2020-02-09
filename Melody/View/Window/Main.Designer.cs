﻿namespace Melody.View.Window
{
  partial class Main
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
      this.MainMenu_ms = new System.Windows.Forms.MenuStrip();
      this.ContactDetails_msmi = new System.Windows.Forms.ToolStripMenuItem();
      this.Contractors_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.AddContractors = new System.Windows.Forms.ToolStripMenuItem();
      this.EditContractors = new System.Windows.Forms.ToolStripMenuItem();
      this.ListContractors = new System.Windows.Forms.ToolStripMenuItem();
      this.DeleteContractors = new System.Windows.Forms.ToolStripMenuItem();
      this.Employees_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.AddEmployee = new System.Windows.Forms.ToolStripMenuItem();
      this.EditEmployee = new System.Windows.Forms.ToolStripMenuItem();
      this.ListEmployee = new System.Windows.Forms.ToolStripMenuItem();
      this.DeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
      this.Contract_msmi = new System.Windows.Forms.ToolStripMenuItem();
      this.AddContract = new System.Windows.Forms.ToolStripMenuItem();
      this.EditContract = new System.Windows.Forms.ToolStripMenuItem();
      this.ListContract = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.DeleteContract = new System.Windows.Forms.ToolStripMenuItem();
      this.Goods_msmi = new System.Windows.Forms.ToolStripMenuItem();
      this.MaterialReceipt_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.AddMaterialReceipt = new System.Windows.Forms.ToolStripMenuItem();
      this.EditMaterialReceipt = new System.Windows.Forms.ToolStripMenuItem();
      this.ListMaterialReceipt = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.DeleteMaterialReceipt = new System.Windows.Forms.ToolStripMenuItem();
      this.CurrentState_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.MaterialIssue_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.AddMaterialIssue = new System.Windows.Forms.ToolStripMenuItem();
      this.EditMaterialIssue = new System.Windows.Forms.ToolStripMenuItem();
      this.ListMaterialIssue = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.DeleteMaterialIssue = new System.Windows.Forms.ToolStripMenuItem();
      this.Order_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.AddOrder = new System.Windows.Forms.ToolStripMenuItem();
      this.EditOrder = new System.Windows.Forms.ToolStripMenuItem();
      this.ListOrder = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.DeleteOrder = new System.Windows.Forms.ToolStripMenuItem();
      this.Help_msmi = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutMe_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.Contact_smi = new System.Windows.Forms.ToolStripMenuItem();
      this.Close_msmi = new System.Windows.Forms.ToolStripMenuItem();
      this.Main_Panel = new System.Windows.Forms.Panel();
      this.MainMenu_ms.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainMenu_ms
      // 
      this.MainMenu_ms.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MainMenu_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContactDetails_msmi,
            this.Contract_msmi,
            this.Goods_msmi,
            this.Help_msmi,
            this.Close_msmi});
      this.MainMenu_ms.Location = new System.Drawing.Point(0, 0);
      this.MainMenu_ms.Name = "MainMenu_ms";
      this.MainMenu_ms.Size = new System.Drawing.Size(1200, 28);
      this.MainMenu_ms.TabIndex = 0;
      this.MainMenu_ms.Text = "menuStrip1";
      // 
      // ContactDetails_msmi
      // 
      this.ContactDetails_msmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Contractors_smi,
            this.Employees_smi});
      this.ContactDetails_msmi.Name = "ContactDetails_msmi";
      this.ContactDetails_msmi.Size = new System.Drawing.Size(141, 24);
      this.ContactDetails_msmi.Text = "Dane Kontaktowe";
      // 
      // Contractors_smi
      // 
      this.Contractors_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContractors,
            this.EditContractors,
            this.ListContractors,
            this.DeleteContractors});
      this.Contractors_smi.Name = "Contractors_smi";
      this.Contractors_smi.Size = new System.Drawing.Size(224, 26);
      this.Contractors_smi.Text = "Kontrahenci";
      this.Contractors_smi.Click += new System.EventHandler(this.Contractor_smi_Click);
      // 
      // AddContractors
      // 
      this.AddContractors.Name = "AddContractors";
      this.AddContractors.Size = new System.Drawing.Size(224, 26);
      this.AddContractors.Text = "Dodaj";
      this.AddContractors.Click += new System.EventHandler(this.AddContractors_Click);
      // 
      // EditContractors
      // 
      this.EditContractors.Name = "EditContractors";
      this.EditContractors.Size = new System.Drawing.Size(224, 26);
      this.EditContractors.Text = "Edytuj";
      this.EditContractors.Click += new System.EventHandler(this.EditContractors_Click);
      // 
      // ListContractors
      // 
      this.ListContractors.Name = "ListContractors";
      this.ListContractors.Size = new System.Drawing.Size(224, 26);
      this.ListContractors.Text = "Lista";
      this.ListContractors.Click += new System.EventHandler(this.ListContractors_Click);
      // 
      // DeleteContractors
      // 
      this.DeleteContractors.Name = "DeleteContractors";
      this.DeleteContractors.Size = new System.Drawing.Size(224, 26);
      this.DeleteContractors.Text = "Usuń";
      this.DeleteContractors.Click += new System.EventHandler(this.DeleteContractors_Click);
      // 
      // Employees_smi
      // 
      this.Employees_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEmployee,
            this.EditEmployee,
            this.ListEmployee,
            this.DeleteEmployee});
      this.Employees_smi.Name = "Employees_smi";
      this.Employees_smi.Size = new System.Drawing.Size(224, 26);
      this.Employees_smi.Text = "Pracownicy";
      this.Employees_smi.Click += new System.EventHandler(this.Employees_smi_Click);
      // 
      // AddEmployee
      // 
      this.AddEmployee.Name = "AddEmployee";
      this.AddEmployee.Size = new System.Drawing.Size(133, 26);
      this.AddEmployee.Text = "Dodaj";
      // 
      // EditEmployee
      // 
      this.EditEmployee.Name = "EditEmployee";
      this.EditEmployee.Size = new System.Drawing.Size(133, 26);
      this.EditEmployee.Text = "Edytuj";
      // 
      // ListEmployee
      // 
      this.ListEmployee.Name = "ListEmployee";
      this.ListEmployee.Size = new System.Drawing.Size(133, 26);
      this.ListEmployee.Text = "Lista";
      // 
      // DeleteEmployee
      // 
      this.DeleteEmployee.Name = "DeleteEmployee";
      this.DeleteEmployee.Size = new System.Drawing.Size(133, 26);
      this.DeleteEmployee.Text = "Usuń";
      // 
      // Contract_msmi
      // 
      this.Contract_msmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContract,
            this.EditContract,
            this.ListContract,
            this.toolStripMenuItem1,
            this.DeleteContract});
      this.Contract_msmi.Name = "Contract_msmi";
      this.Contract_msmi.Size = new System.Drawing.Size(86, 24);
      this.Contract_msmi.Text = "Kontrakty";
      this.Contract_msmi.Click += new System.EventHandler(this.Contract_msmi_Click);
      // 
      // AddContract
      // 
      this.AddContract.Name = "AddContract";
      this.AddContract.Size = new System.Drawing.Size(224, 26);
      this.AddContract.Text = "Dodaj";
      // 
      // EditContract
      // 
      this.EditContract.Name = "EditContract";
      this.EditContract.Size = new System.Drawing.Size(224, 26);
      this.EditContract.Text = "Edytuj";
      // 
      // ListContract
      // 
      this.ListContract.Name = "ListContract";
      this.ListContract.Size = new System.Drawing.Size(224, 26);
      this.ListContract.Text = "Lista";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
      // 
      // DeleteContract
      // 
      this.DeleteContract.Name = "DeleteContract";
      this.DeleteContract.Size = new System.Drawing.Size(224, 26);
      this.DeleteContract.Text = "Usuń";
      // 
      // Goods_msmi
      // 
      this.Goods_msmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaterialReceipt_smi,
            this.CurrentState_smi,
            this.MaterialIssue_smi,
            this.Order_smi});
      this.Goods_msmi.Name = "Goods_msmi";
      this.Goods_msmi.Size = new System.Drawing.Size(71, 24);
      this.Goods_msmi.Text = "Towary";
      // 
      // MaterialReceipt_smi
      // 
      this.MaterialReceipt_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMaterialReceipt,
            this.EditMaterialReceipt,
            this.ListMaterialReceipt,
            this.toolStripMenuItem2,
            this.DeleteMaterialReceipt});
      this.MaterialReceipt_smi.Name = "MaterialReceipt_smi";
      this.MaterialReceipt_smi.Size = new System.Drawing.Size(224, 26);
      this.MaterialReceipt_smi.Text = "Przyjęcia";
      this.MaterialReceipt_smi.Click += new System.EventHandler(this.MaterialRecipt_smi_Click);
      // 
      // AddMaterialReceipt
      // 
      this.AddMaterialReceipt.Name = "AddMaterialReceipt";
      this.AddMaterialReceipt.Size = new System.Drawing.Size(133, 26);
      this.AddMaterialReceipt.Text = "Dodaj";
      // 
      // EditMaterialReceipt
      // 
      this.EditMaterialReceipt.Name = "EditMaterialReceipt";
      this.EditMaterialReceipt.Size = new System.Drawing.Size(133, 26);
      this.EditMaterialReceipt.Text = "Edytuj";
      // 
      // ListMaterialReceipt
      // 
      this.ListMaterialReceipt.Name = "ListMaterialReceipt";
      this.ListMaterialReceipt.Size = new System.Drawing.Size(133, 26);
      this.ListMaterialReceipt.Text = "Lista";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
      // 
      // DeleteMaterialReceipt
      // 
      this.DeleteMaterialReceipt.Name = "DeleteMaterialReceipt";
      this.DeleteMaterialReceipt.Size = new System.Drawing.Size(133, 26);
      this.DeleteMaterialReceipt.Text = "Usuń";
      // 
      // CurrentState_smi
      // 
      this.CurrentState_smi.Name = "CurrentState_smi";
      this.CurrentState_smi.Size = new System.Drawing.Size(224, 26);
      this.CurrentState_smi.Text = "Stan";
      this.CurrentState_smi.Click += new System.EventHandler(this.CurrentState_smi_Click);
      // 
      // MaterialIssue_smi
      // 
      this.MaterialIssue_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMaterialIssue,
            this.EditMaterialIssue,
            this.ListMaterialIssue,
            this.toolStripMenuItem3,
            this.DeleteMaterialIssue});
      this.MaterialIssue_smi.Name = "MaterialIssue_smi";
      this.MaterialIssue_smi.Size = new System.Drawing.Size(224, 26);
      this.MaterialIssue_smi.Text = "Wydania";
      this.MaterialIssue_smi.Click += new System.EventHandler(this.MaterialIssue_smi_Click);
      // 
      // AddMaterialIssue
      // 
      this.AddMaterialIssue.Name = "AddMaterialIssue";
      this.AddMaterialIssue.Size = new System.Drawing.Size(133, 26);
      this.AddMaterialIssue.Text = "Dodaj";
      // 
      // EditMaterialIssue
      // 
      this.EditMaterialIssue.Name = "EditMaterialIssue";
      this.EditMaterialIssue.Size = new System.Drawing.Size(133, 26);
      this.EditMaterialIssue.Text = "Edytuj";
      // 
      // ListMaterialIssue
      // 
      this.ListMaterialIssue.Name = "ListMaterialIssue";
      this.ListMaterialIssue.Size = new System.Drawing.Size(133, 26);
      this.ListMaterialIssue.Text = "Lista";
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 6);
      // 
      // DeleteMaterialIssue
      // 
      this.DeleteMaterialIssue.Name = "DeleteMaterialIssue";
      this.DeleteMaterialIssue.Size = new System.Drawing.Size(133, 26);
      this.DeleteMaterialIssue.Text = "Usuń";
      // 
      // Order_smi
      // 
      this.Order_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOrder,
            this.EditOrder,
            this.ListOrder,
            this.toolStripMenuItem4,
            this.DeleteOrder});
      this.Order_smi.Name = "Order_smi";
      this.Order_smi.Size = new System.Drawing.Size(224, 26);
      this.Order_smi.Text = "Zamówienia";
      this.Order_smi.Click += new System.EventHandler(this.Order_smi_Click);
      // 
      // AddOrder
      // 
      this.AddOrder.Name = "AddOrder";
      this.AddOrder.Size = new System.Drawing.Size(133, 26);
      this.AddOrder.Text = "Dodaj";
      // 
      // EditOrder
      // 
      this.EditOrder.Name = "EditOrder";
      this.EditOrder.Size = new System.Drawing.Size(133, 26);
      this.EditOrder.Text = "Edytuj";
      // 
      // ListOrder
      // 
      this.ListOrder.Name = "ListOrder";
      this.ListOrder.Size = new System.Drawing.Size(133, 26);
      this.ListOrder.Text = "Lista";
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(130, 6);
      // 
      // DeleteOrder
      // 
      this.DeleteOrder.Name = "DeleteOrder";
      this.DeleteOrder.Size = new System.Drawing.Size(133, 26);
      this.DeleteOrder.Text = "Usuń";
      // 
      // Help_msmi
      // 
      this.Help_msmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMe_smi,
            this.Contact_smi});
      this.Help_msmi.Name = "Help_msmi";
      this.Help_msmi.Size = new System.Drawing.Size(69, 24);
      this.Help_msmi.Text = "Pomoc";
      // 
      // AboutMe_smi
      // 
      this.AboutMe_smi.Name = "AboutMe_smi";
      this.AboutMe_smi.Size = new System.Drawing.Size(224, 26);
      this.AboutMe_smi.Text = "O mnie";
      this.AboutMe_smi.Click += new System.EventHandler(this.AboutMe_smi_Click);
      // 
      // Contact_smi
      // 
      this.Contact_smi.Name = "Contact_smi";
      this.Contact_smi.Size = new System.Drawing.Size(224, 26);
      this.Contact_smi.Text = "Kontakt";
      this.Contact_smi.Click += new System.EventHandler(this.Contact_smi_Click);
      // 
      // Close_msmi
      // 
      this.Close_msmi.Name = "Close_msmi";
      this.Close_msmi.Size = new System.Drawing.Size(64, 24);
      this.Close_msmi.Text = "Wyjdź";
      this.Close_msmi.Click += new System.EventHandler(this.Close_msmi_Click);
      // 
      // Main_Panel
      // 
      this.Main_Panel.BackgroundImage = global::Melody.Properties.Resources.Login;
      this.Main_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Main_Panel.Location = new System.Drawing.Point(0, 28);
      this.Main_Panel.Name = "Main_Panel";
      this.Main_Panel.Size = new System.Drawing.Size(1200, 675);
      this.Main_Panel.TabIndex = 1;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 703);
      this.Controls.Add(this.Main_Panel);
      this.Controls.Add(this.MainMenu_ms);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.MainMenu_ms;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Melody";
      this.TopMost = true;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.MainMenu_ms.ResumeLayout(false);
      this.MainMenu_ms.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu_ms;
        private System.Windows.Forms.ToolStripMenuItem ContactDetails_msmi;
        private System.Windows.Forms.ToolStripMenuItem Contractors_smi;
        private System.Windows.Forms.ToolStripMenuItem AddContractors;
        private System.Windows.Forms.ToolStripMenuItem EditContractors;
        private System.Windows.Forms.ToolStripMenuItem ListContractors;
        private System.Windows.Forms.ToolStripMenuItem DeleteContractors;
        private System.Windows.Forms.ToolStripMenuItem Employees_smi;
        private System.Windows.Forms.ToolStripMenuItem AddEmployee;
        private System.Windows.Forms.ToolStripMenuItem EditEmployee;
        private System.Windows.Forms.ToolStripMenuItem ListEmployee;
        private System.Windows.Forms.ToolStripMenuItem DeleteEmployee;
        private System.Windows.Forms.ToolStripMenuItem Contract_msmi;
        private System.Windows.Forms.ToolStripMenuItem AddContract;
        private System.Windows.Forms.ToolStripMenuItem EditContract;
        private System.Windows.Forms.ToolStripMenuItem ListContract;
        private System.Windows.Forms.ToolStripMenuItem DeleteContract;
        private System.Windows.Forms.ToolStripMenuItem Goods_msmi;
        private System.Windows.Forms.ToolStripMenuItem MaterialReceipt_smi;
        private System.Windows.Forms.ToolStripMenuItem AddMaterialReceipt;
        private System.Windows.Forms.ToolStripMenuItem EditMaterialReceipt;
        private System.Windows.Forms.ToolStripMenuItem ListMaterialReceipt;
        private System.Windows.Forms.ToolStripMenuItem DeleteMaterialReceipt;
        private System.Windows.Forms.ToolStripMenuItem CurrentState_smi;
        private System.Windows.Forms.ToolStripMenuItem MaterialIssue_smi;
        private System.Windows.Forms.ToolStripMenuItem AddMaterialIssue;
        private System.Windows.Forms.ToolStripMenuItem EditMaterialIssue;
        private System.Windows.Forms.ToolStripMenuItem ListMaterialIssue;
        private System.Windows.Forms.ToolStripMenuItem DeleteMaterialIssue;
        private System.Windows.Forms.ToolStripMenuItem Order_smi;
        private System.Windows.Forms.ToolStripMenuItem AddOrder;
        private System.Windows.Forms.ToolStripMenuItem EditOrder;
        private System.Windows.Forms.ToolStripMenuItem ListOrder;
        private System.Windows.Forms.ToolStripMenuItem DeleteOrder;
        private System.Windows.Forms.ToolStripMenuItem Help_msmi;
        private System.Windows.Forms.ToolStripMenuItem AboutMe_smi;
        private System.Windows.Forms.ToolStripMenuItem Contact_smi;
        private System.Windows.Forms.ToolStripMenuItem Close_msmi;
        private System.Windows.Forms.Panel Main_Panel;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
  }
}