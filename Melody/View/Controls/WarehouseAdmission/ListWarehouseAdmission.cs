using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity.EntityToView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class ListMaterialReceipt : UserControl
  {
    private IMaterialReceiptRepository _materialReceiptRepository;
    private List<MaterialReceiptView> _materialReceipts;
    public ListMaterialReceipt(IMaterialReceiptRepository materialReceiptRepository)
    {
      InitializeComponent();
      _materialReceiptRepository = materialReceiptRepository ?? throw new ArgumentNullException(nameof(materialReceiptRepository));
      RefreshMaterialReceipt();
    }

    private void RefreshMaterialReceipt()
    {
      _materialReceipts = _materialReceiptRepository.GetWarehouseAdmission();
              Data_dgv.DataSource = null;
      Data_dgv.DataSource = _materialReceipts;
    }

    private void Refresh_btn_Click(object sender, EventArgs e)
    {
      RefreshMaterialReceipt();
    }
  }
}
