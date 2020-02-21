using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melody.Service.Entity;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IContractsRepository
  {
    List<Destiny> GetDestinies();
  }
}
