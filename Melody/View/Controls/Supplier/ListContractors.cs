using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;

namespace Melody.View.Controls
{
  public partial class ListContractors : UserControl
  {
    private readonly ISuppliersRepository _suppliersRepository;
    private List<SupplierView> _suppliers;

    public ListContractors(ISuppliersRepository suppliersRepository)
    {
      InitializeComponent();
      _suppliersRepository = suppliersRepository;
      ReferesSuppliers();
    }

    public ListContractors()
    {
    }

    private void Refresh_btn_Click(object sender, EventArgs e)
    {
      ReferesSuppliers();
    }

    private void ReferesSuppliers()
    {
      _suppliers = _suppliersRepository.GetSuppliers();
      Data_dgv.DataSource = null;
      Data_dgv.DataSource = _suppliers;
    }
  }
}
