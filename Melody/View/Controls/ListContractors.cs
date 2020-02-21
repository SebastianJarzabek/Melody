﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Melody.Service.DataAccess;
using Melody.Service.Entity;

namespace Melody.View.Controls
{
  public partial class ListContractors_panel : UserControl
  {
    private readonly ISuppliersRepository _suppliersRepository;
    private List<Supplier> _suppliers;

    public ListContractors_panel(ISuppliersRepository suppliersRepository)
    {
      InitializeComponent();
      _suppliersRepository = suppliersRepository;
      ReferesSuppliers();
    }

    public ListContractors_panel()
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
