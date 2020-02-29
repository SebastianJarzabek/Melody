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
    List<Order> orders = new List<Order>();
    private readonly IOrderRepository _orderRepository;
    private int orderNumber;

    public AddOrder(IOrderRepository orderRepository)
    {
      _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
      InitializeComponent();
      orderNumber = _orderRepository.CheckLast() + 1;
    }

    private void AddOrder_Load(object sender, EventArgs e)
    {
      OrderNumber_tb.Text = orderNumber.ToString();

      var datatableName = _orderRepository.ComboboxSugest("name", "Employee");
      NameOrderingEmployeeIn_cb.ValueMember = "name";
      NameOrderingEmployeeIn_cb.DataSource = datatableName;

      var datatableName1 = _orderRepository.ComboboxSugest("name", "Employee");
      NameHostEmployeeIn_cb.ValueMember = "name";
      NameHostEmployeeIn_cb.DataSource = datatableName1;

      var datatableName2 = _orderRepository.ComboboxSugest("name", "Employee");
      NameReceivingEmployeeIn_cb.ValueMember = "name";
      NameReceivingEmployeeIn_cb.DataSource = datatableName2;

      var datatableSurname = _orderRepository.ComboboxSugest("surname", "Employee");
      SurnameOrderingEmployeeIn_cb.ValueMember = "surname";
      SurnameOrderingEmployeeIn_cb.DataSource = datatableSurname;

      var datatableSurname1 = _orderRepository.ComboboxSugest("surname", "Employee");
      SurnameHostEmployeeIn_cb.ValueMember = "surname";
      SurnameHostEmployeeIn_cb.DataSource = datatableSurname1;

      var datatableSurname2 = _orderRepository.ComboboxSugest("surname", "Employee");
      SurnameReceivingEmployeeIn_cb.ValueMember = "surname";
      SurnameReceivingEmployeeIn_cb.DataSource = datatableSurname2;

      var datatableDestinyName = _orderRepository.ComboboxSugest("name", "Destiny");
      DestinyName_cb.ValueMember = "name";
      DestinyName_cb.DataSource = datatableDestinyName;

      var datatableSupplierName = _orderRepository.ComboboxSugest("name", "Supplier");
      NameSupplierIn_cb.ValueMember = "name";
      NameSupplierIn_cb.DataSource = datatableSupplierName;

      var datatableDestinyContract = _orderRepository.ComboboxSugest("contract", "Destiny");
      DestinyContractNumber_cb.ValueMember = "contract";
      DestinyContractNumber_cb.DataSource = datatableDestinyContract;

      var datatableMaterialName = _orderRepository.ComboboxSugest("name", "Material");
      MaterialName_cb.ValueMember = "name";
      MaterialName_cb.DataSource = datatableMaterialName;

      var datatableMaterialType = _orderRepository.ComboboxSugest("type", "Material");
      MaterialType_cb.ValueMember = "type";
      MaterialType_cb.DataSource = datatableMaterialType;

      var datatableUnitName = _orderRepository.ComboboxSugest("name", "Unit");
      MaterialUnitType_cb.ValueMember = "name";
      MaterialUnitType_cb.DataSource = datatableUnitName;
    }

    private void AddOrder_panel_Paint(object sender, PaintEventArgs e)
    {
      AddOrder_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddOrder_panel.Size.Width / 2
      );
      AddOrder_panel.Anchor = AnchorStyles.None;
    }

    private void AddOrder_btn_Click(object sender, EventArgs e)
    {
      OrderCollect();
      string isValidate = string.Empty;

      foreach (var item in orders)
      {
        isValidate += item.Validate();
        var validationResult = item.Validate();
        try
        {
          ClearErrorLabel();
          OrderNumber_tb.Text = _orderRepository.CheckLast().ToString();

          if (validationResult.IsValid)
          {
            _orderRepository.AddOrder(item);
            MessageBox.Show($"Dodano do bazy danych zamówienie o numerze: {orderNumber}.",
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
          MessageBox.Show($"Wystąpił błąd przy dodaniu zamówienie o numerze: {orderNumber} do bazy. {ex}",
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

    private List<Order> OrderCollect()
    {
      foreach (var item in materialToOrders)
      {
        orders.Add(new Order
        {
          OrderNumber = orderNumber
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
      return orders;
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
  }
}