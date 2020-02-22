using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IContractsRepository
  {
    bool AddDestiny(object parm);

    bool UpdateDestinies(object parm);

    bool DeleteDestinies(object parm);

    List<Destiny> GetDestinies();
  }
}
