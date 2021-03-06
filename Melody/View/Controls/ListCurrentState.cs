﻿using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Melody.View.Panel
{
  public partial class CurrentState : UserControl
  {
    private IInventoryLevelRepository _inventoryLevelRepository;
    private List<InventoryLevelView> _inventoryLevels;

    public CurrentState(IInventoryLevelRepository inventoryLevelRepository)
    {
      InitializeComponent();
      _inventoryLevelRepository = inventoryLevelRepository;
      RefereshDestinies();
    }

    private void Refresh_btn_Click(object sender, System.EventArgs e)
    {
      RefereshDestinies();
    }

    private void RefereshDestinies()
    {
      _inventoryLevels = _inventoryLevelRepository.GetInventoryLevel();
      Data_dgv.DataSource = null;
      Data_dgv.DataSource = _inventoryLevels;
    }
  }
}
