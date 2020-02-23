using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IContractsRepository
  {
    void AddDestiny(Destiny destiny);

    void UpdateDestinies(object parm);

    void DeleteDestinies(Destiny destiny);

    List<Destiny> GetDestinies();
  }
}
