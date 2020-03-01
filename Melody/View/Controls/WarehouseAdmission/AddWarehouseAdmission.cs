using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddWarehouseAdmission : UserControl
  {
    List<MaterialToOrder> materialToOrders = new List<MaterialToOrder>();
    List<WarehouseAdmission> warehouseAdmission = new List<WarehouseAdmission>();
    private readonly IMaterialReceiptRepository _materialReceiptRepository;
    private int warehouseAdmissionNumber;
    public AddWarehouseAdmission(IMaterialReceiptRepository materialReceiptRepository)
    {
      _materialReceiptRepository = materialReceiptRepository ?? throw new ArgumentNullException(nameof(materialReceiptRepository));
      InitializeComponent();
      warehouseAdmissionNumber = _materialReceiptRepository.CheckLast() + 1;
    }

    private void AddOrder_Load(object sender, EventArgs e)
    {
      warehouseAdmissionNumber_tb.Text = warehouseAdmissionNumber.ToString();

      var datatableName = _materialReceiptRepository.ComboboxSugest("name", "Employee");
      NameOrderingEmployeeIn_cb.ValueMember = "name";
      NameOrderingEmployeeIn_cb.DataSource = datatableName;

      var datatableName1 = _materialReceiptRepository.ComboboxSugest("name", "Employee");
      NameHostEmployeeIn_cb.ValueMember = "name";
      NameHostEmployeeIn_cb.DataSource = datatableName1;

      var datatableSurname = _materialReceiptRepository.ComboboxSugest("surname", "Employee");
      SurnameOrderingEmployeeIn_cb.ValueMember = "surname";
      SurnameOrderingEmployeeIn_cb.DataSource = datatableSurname;

      var datatableSurname1 = _materialReceiptRepository.ComboboxSugest("surname", "Employee");
      SurnameHostEmployeeIn_cb.ValueMember = "surname";
      SurnameHostEmployeeIn_cb.DataSource = datatableSurname1;

      var datatableSupplierName = _materialReceiptRepository.ComboboxSugest("name", "Supplier");
      NameSupplierIn_cb.ValueMember = "name";
      NameSupplierIn_cb.DataSource = datatableSupplierName;

      var datatableDestinyName = _materialReceiptRepository.ComboboxSugest("name", "Destiny");
      DestinyName_cb.ValueMember = "name";
      DestinyName_cb.DataSource = datatableDestinyName;

      var datatableDestinyContract = _materialReceiptRepository.ComboboxSugest("contract", "Destiny");
      DestinyContractNumber_cb.ValueMember = "contract";
      DestinyContractNumber_cb.DataSource = datatableDestinyContract;

      var datatableMaterialName = _materialReceiptRepository.ComboboxSugest("name", "Material");
      MaterialName_cb.ValueMember = "name";
      MaterialName_cb.DataSource = datatableMaterialName;

      var datatableMaterialType = _materialReceiptRepository.ComboboxSugest("type", "Material");
      MaterialType_cb.ValueMember = "type";
      MaterialType_cb.DataSource = datatableMaterialType;

      var datatableUnitName = _materialReceiptRepository.ComboboxSugest("name", "Unit");
      MaterialUnitType_cb.ValueMember = "name";
      MaterialUnitType_cb.DataSource = datatableUnitName;
    }

    private void AddWarehouseAdmission_panel_Paint(object sender, PaintEventArgs e)
    {
      AddWarehouseAdmission_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddWarehouseAdmission_panel.Size.Width / 2
      );
      AddWarehouseAdmission_panel.Anchor = AnchorStyles.None;
    }

    private void AddWarehouseAdmission_btn_Click(object sender, EventArgs e)
    {
      OrderCollect();
      string isValidate = string.Empty;

      foreach (var item in warehouseAdmission)
      {
        isValidate += item.Validate();
        var validationResult = item.Validate();
        try
        {
          ClearErrorLabel();
          warehouseAdmissionNumber_tb.Text = warehouseAdmissionNumber.ToString();

          if (validationResult.IsValid)
          {
            _materialReceiptRepository.AddWarehouseAdmission(item);
            MessageBox.Show($"Dodano do bazy danych zamówienie o numerze: {warehouseAdmissionNumber}.",
                            "Informacja",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
          else
          {
            Validation_lbl.Text = validationResult.ErrorMessageToDisplay;
            MessageBox.Show(validationResult.ErrorMessageToDisplay,
                          "Błąd",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
          }
        }
        catch (Exception ex)
        {
          Validation_lbl.Text = validationResult.ErrorMessageToDisplay;
          MessageBox.Show($"Wystąpił błąd przy dodaniu zamówienie o numerze: {warehouseAdmissionNumber} do bazy. {ex}",
                          "Błąd",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
          throw ex;
        }
        finally
        {
          Clear();
        }
      }
    }


    private void AddMaterialToList_btn_Click(object sender, EventArgs e)
    {
      try
      {
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

    private List<WarehouseAdmission> OrderCollect()
    {
      foreach (var item in materialToOrders)
      {
        warehouseAdmission.Add(new WarehouseAdmission
        {
          WarehouseAdmissionNumber = warehouseAdmissionNumber
          ,
          DateOfAdmission = dateOfOrderIn_dtp.Value
          ,
          HostEmployee = NameOrderingEmployeeIn_cb.Text + " " + SurnameOrderingEmployeeIn_cb.Text
          ,
          Supplier = new Supplier
          {
            Name = NameSupplierIn_cb.Text
          },
          Order = new Order
          {
            OrderNumber = Convert.ToInt32(OrderNumber_tb.Text)
          },
          Destiny = new Destiny
          {
            Name = DestinyName_cb.Text
            ,
            Contract = DestinyContractNumber_cb.Text
          },
          Material = new Material
          {
            Name = item.material.Name,
            Type = item.material.Type
          },
          Quantity = item.Quantity
          ,
          Unit = new Unit
          {
            Name = item.unit.Name
          }
          ,
          Note = new Note
          {
            NoteFullText = Note_rtb.Text
          }
        });
      }
      return warehouseAdmission;
    }

    private void MaterialsToOrder_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      MaterialsToOrder_dgv.DataSource = materialToOrders;
      MaterialsToOrder_dgv.Refresh();
    }

    private void Clear()
    {
      dateOfOrderIn_dtp.Value = DateTime.Now;
      NameOrderingEmployeeIn_cb.Text = string.Empty;
      SurnameOrderingEmployeeIn_cb.Text = string.Empty;
      NameSupplierIn_cb.Text = string.Empty;
      DestinyName_cb.Text = string.Empty;
      DestinyContractNumber_cb.Text = string.Empty;
      MaterialName_cb.Text = string.Empty;
      MaterialQuantity_tb.Text = string.Empty;
      MaterialType_cb.Text = string.Empty;
      MaterialUnitType_cb.Text = string.Empty;
      Note_rtb.Text = string.Empty;
      DateOfAdmissionIn_dtp.Value = DateTime.Now;
      NameHostEmployeeIn_cb.Text = string.Empty;
      SurnameHostEmployeeIn_cb.Text = string.Empty;
    }

    private void ClearErrorLabel()
    {
      if (string.IsNullOrWhiteSpace(Validation_lbl.Text))
      {
        Validation_lbl.Text = string.Empty;
      }
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

    private void ClearMaterialsToOrder_btn_Click(object sender, EventArgs e)
    {
      materialToOrders = null;
      MaterialsToOrder_dgv.Refresh();
      MaterialsToOrder_dgv.DataSource = materialToOrders;
    }
  }
}
