using System.Collections.Generic;
using System.Windows.Forms;
using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;

namespace Melody.View.Controls
{
  public partial class ListContract : UserControl
  {
    private readonly IContractsRepository _contractsRepository;

    private List<Destiny> _destinies;

    public ListContract(IContractsRepository contractsRepository)
    {
      InitializeComponent();

      _contractsRepository = contractsRepository;
      RefereshDestinies();
    }

    private void Refresh_btn_Click(object sender, System.EventArgs e)
    {
      RefereshDestinies();
    }

    private void RefereshDestinies()
    {
      _destinies = _contractsRepository.GetDestinies();
      Data_dgv.DataSource = null;
      Data_dgv.DataSource = _destinies;
    }
  }
}
