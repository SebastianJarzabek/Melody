using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melody.Service.Entity;
using Melody.Service.DataAccess;

namespace Melody.View.Controls
{
  public partial class AddWarehouseIssue : UserControl
  {
    List<MaterialToWarehouseIssue> materialToWarehouseIssue = new List<MaterialToWarehouseIssue>();
    List<WarehouseIssue> orders = new List<WarehouseIssue>();
    private readonly IWarehouseIssueRepository _warehouseIssueRepository;
    private int LastWarehouseIssue;

    public AddWarehouseIssue(IOrderRepository orderRepository)
    {
      _warehouseIssueRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
      InitializeComponent();
      LastWarehouseIssue = _warehouseIssueRepository.CheckLastWarehouseIssue() + 1;
    }
      private void AddWarehouseIssue_panel_Paint(object sender, PaintEventArgs e)
    {
      AddWarehouseIssue_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddWarehouseIssue_panel.Size.Width / 2
      );
      AddWarehouseIssue_panel.Anchor = AnchorStyles.None;
    }

    private void AddOrder_Load(object sender, EventArgs e)
    {
      LastWarehouseIssue_tb.Text = LastWarehouseIssue.ToString();

      var datatableName = _warehouseIssueRepository.ComboboxSugest("name", "Employee");
      NameOrderingEmployeeIn_cb.ValueMember = "name";
      NameOrderingEmployeeIn_cb.DataSource = datatableName;

      var datatableName2 = _warehouseIssueRepository.ComboboxSugest("name", "Employee");
      NameReceivingEmployeeIn_cb.ValueMember = "name";
      NameReceivingEmployeeIn_cb.DataSource = datatableName2;

      var datatableSurname = _warehouseIssueRepository.ComboboxSugest("surname", "Employee");
      SurnameOrderingEmployeeIn_cb.ValueMember = "surname";
      SurnameOrderingEmployeeIn_cb.DataSource = datatableSurname;

      var datatableSurname2 = _warehouseIssueRepository.ComboboxSugest("surname", "Employee");
      SurnameReceivingEmployeeIn_cb.ValueMember = "surname";
      SurnameReceivingEmployeeIn_cb.DataSource = datatableSurname2;

      var datatableDestinyName = _warehouseIssueRepository.ComboboxSugest("name", "Destiny");
      DestinyName_cb.ValueMember = "name";
      DestinyName_cb.DataSource = datatableDestinyName;

      var datatableSupplierName = _warehouseIssueRepository.ComboboxSugest("name", "Supplier");
      NameSupplierIn_cb.ValueMember = "name";
      NameSupplierIn_cb.DataSource = datatableSupplierName;

      var datatableDestinyContract = _warehouseIssueRepository.ComboboxSugest("contract", "Destiny");
      DestinyContractNumber_cb.ValueMember = "contract";
      DestinyContractNumber_cb.DataSource = datatableDestinyContract;

      var datatableMaterialName = _warehouseIssueRepository.ComboboxSugest("name", "Material");
      MaterialName_cb.ValueMember = "name";
      MaterialName_cb.DataSource = datatableMaterialName;

      var datatableMaterialType = _warehouseIssueRepository.ComboboxSugest("type", "Material");
      MaterialType_cb.ValueMember = "type";
      MaterialType_cb.DataSource = datatableMaterialType;

      var datatableUnitName = _warehouseIssueRepository.ComboboxSugest("name", "Unit");
      MaterialUnitType_cb.ValueMember = "name";
      MaterialUnitType_cb.DataSource = datatableUnitName;
    }

    private void AddOrder_btn_Click(object sender, EventArgs e)
    {
      WarehouseIssueCollect();
      string isValidate = string.Empty;

      foreach (var item in orders)
      {
        isValidate += item.Validate();
        var validationResult = item.Validate();
        try
        {
          ClearErrorLabel();
          LastWarehouseIssue_tb.Text = LastWarehouseIssue.ToString();

          if (validationResult.IsValid)
          {
            _warehouseIssueRepository.AddOrder(item);
            MessageBox.Show($"Dodano do bazy danych zamówienie o numerze: {LastWarehouseIssue}.",
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
          MessageBox.Show($"Wystąpił błąd przy dodaniu zamówienie o numerze: {LastWarehouseIssue} do bazy. {ex}",
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

    private List<WarehouseIssue> WarehouseIssueCollect()
    {
      foreach (var item in materialToWarehouseIssue)
      {
        warehouseIssue.Add(new WarehouseIssue
        {
          WarehouseIssueNumber = LastWarehouseIssue
          ,
          DateOfOrder = dateOfOrderIn_dtp.Value
          ,
          OrderingEmployee = NameOrderingEmployeeIn_cb.Text + " " + SurnameOrderingEmployeeIn_cb.Text
          ,
          Supplier = new Supplier
          {
            Name = NameSupplierIn_cb.Text
          },
          Destiny = new Destiny
          {
            Name = DestinyName_cb.Text
            ,
            Contract = DestinyContractNumber_cb.Text
          },
          Material = new Material
          {
            Name = item.material.Name
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
          ,
          ReceivingEmployee = NameReceivingEmployeeIn_cb.Text + " " + SurnameReceivingEmployeeIn_cb.Text
          ,
          PlannedDateOfReceipt = DateOfReceiptIn_dtp.Value
        });
      }
      return warehouseIssue;
    }

    private void MaterialsToWarehouseIssue_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
      DateOfReceiptIn_dtp.Value = DateTime.Now;
      NameReceivingEmployeeIn_cb.Text = string.Empty;
      SurnameReceivingEmployeeIn_cb.Text = string.Empty;
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
  }
}
