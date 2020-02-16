using Melody.Logic;
using Melody.Service.DataAccess;
using Melody.Service.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddOrder : UserControl
  {
    List<MaterialToOrder> materialToOrders = new List<MaterialToOrder>();
    Validators validators = new Validators();

    public AddOrder()
    {
      InitializeComponent();
    }

    private void AddOrder_panel_Paint(object sender, PaintEventArgs e)
    {
      AddOrder_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddOrder_panel.Size.Width / 2
      );
      AddOrder_panel.Anchor = AnchorStyles.None;
    }

    private void AddMaterialToList_btn_Click(object sender, EventArgs e)
    {
      try
      {
        var errorMessage = validators.IsIntValidate(MaterialQuantity_tb.Text);

        if (!string.IsNullOrEmpty(errorMessage))
        {
          MessageBox.Show(errorMessage, "Błąd",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
          Validation_lbl.Text = errorMessage;
          return;
        }

        var materialToOrder = new MaterialToOrder
        {
          material = new Material
          {
            Name = MaterialName_cb.Text,
            Type = MaterialType_cb.Text
          },
          unit = new Unit
          {
            Name = MaterialUnitType_cb.Text
          },
          Quantity = Convert.ToInt32(MaterialQuantity_tb.Text)
        };

        materialToOrders.Add(materialToOrder);
        MaterialsToOrder_dgv.Rows.Add(materialToOrder.material.Name, materialToOrder.material.Type, materialToOrder.unit.Name, materialToOrder.Quantity);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private void AddOrder_btn_Click(object sender, EventArgs e)
    {
      ///TODO: validacja, dodanie do bazy.
    }


    private void ClearOrder_btn_Click(object sender, EventArgs e)
    {
      dateOfOrderIn_dtp.Value = DateTime.Now;
      NameOrderingEmployeeIn_cb.Text = string.Empty;
      SurnameOrderingEmployeeIn_cb.Text = string.Empty;
      NameSupplierIn_cb.Text = string.Empty;
    }

    private void ClearDestiny_btn_Click(object sender, EventArgs e)
    {
      DestinyName_cb.Text = string.Empty;
      DestinyContractNumber_cb.Text = string.Empty;
    }

    private void ClearMaterial_btn_Click(object sender, EventArgs e)
    {
      MaterialName_cb.Text = string.Empty;
      MaterialQuantity_tb.Text = string.Empty;
      MaterialType_cb.Text = string.Empty;
      MaterialUnitType_cb.Text = string.Empty;
    }

    private void ClearNote_btn_Click(object sender, EventArgs e)
    {
      Note_rtb.Text = string.Empty;
    }

    private void ClearWarehouseAdmission_btn_Click(object sender, EventArgs e)
    {
      DateOfAdmissionIn_dtp.Value = DateTime.Now;
      NameHostEmployeeIn_cb.Text = string.Empty;
      SurnameHostEmployeeIn_cb.Text = string.Empty;
    }

    private void ClearWarehouseIssue_btn_Click(object sender, EventArgs e)
    {
      DateOfReceiptIn_dtp.Value = DateTime.Now;
      NameReceivingEmployeeIn_cb.Text = string.Empty;
      SurnameReceivingEmployeeIn_cb.Text = string.Empty;
    }

    private void ClearMaterialsToOrder_btn_Click(object sender, EventArgs e)
    {
      materialToOrders = null;
      MaterialsToOrder_dgv.Refresh();
      MaterialsToOrder_dgv.DataSource = materialToOrders;
    }

    private void MaterialsToOrder_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      MaterialsToOrder_dgv.DataSource = materialToOrders;
      MaterialsToOrder_dgv.Refresh();
    }

    private void AddOrder_Load(object sender, EventArgs e)
     {
      var exec = new Executor();
      var datatableName = exec.ComboboxSugest("name", "Employee");
      NameOrderingEmployeeIn_cb.ValueMember = "name";
      NameOrderingEmployeeIn_cb.DataSource = datatableName;

      var datatableName1 = exec.ComboboxSugest("name", "Employee");
      NameHostEmployeeIn_cb.ValueMember = "name";
      NameHostEmployeeIn_cb.DataSource = datatableName1;

      var datatableName2 = exec.ComboboxSugest("name", "Employee");
      NameReceivingEmployeeIn_cb.ValueMember = "name";
      NameReceivingEmployeeIn_cb.DataSource = datatableName2;

      var datatableSurname = exec.ComboboxSugest("surname", "Employee");
      SurnameOrderingEmployeeIn_cb.ValueMember = "surname";
      SurnameOrderingEmployeeIn_cb.DataSource = datatableSurname;

      var datatableSurname1 = exec.ComboboxSugest("surname", "Employee");
      SurnameHostEmployeeIn_cb.ValueMember = "surname";
      SurnameHostEmployeeIn_cb.DataSource = datatableSurname1;

      var datatableSurname2 = exec.ComboboxSugest("surname", "Employee");
      SurnameReceivingEmployeeIn_cb.ValueMember = "surname";
      SurnameReceivingEmployeeIn_cb.DataSource = datatableSurname2;

      var datatableDestinyName = exec.ComboboxSugest("name", "Destiny");
      DestinyName_cb.ValueMember = "name";
      DestinyName_cb.DataSource = datatableDestinyName;

      var datatableSupplierName = exec.ComboboxSugest("name", "Supplier");
      NameSupplierIn_cb.ValueMember = "name";
      NameSupplierIn_cb.DataSource = datatableSupplierName;

      var datatableDestinyContract = exec.ComboboxSugest("contract", "Destiny");
      DestinyContractNumber_cb.ValueMember = "contract";
      DestinyContractNumber_cb.DataSource = datatableDestinyContract;

      var datatableMaterialName = exec.ComboboxSugest("name", "Material");
      MaterialName_cb.ValueMember = "name";
      MaterialName_cb.DataSource = datatableMaterialName;

      var datatableMaterialType = exec.ComboboxSugest("type", "Material");
      MaterialType_cb.ValueMember = "type";
      MaterialType_cb.DataSource = datatableMaterialType;

      var datatableUnitName = exec.ComboboxSugest("name", "Unit");
      MaterialUnitType_cb.ValueMember = "name";
      MaterialUnitType_cb.DataSource = datatableUnitName;
    }
  }
}
