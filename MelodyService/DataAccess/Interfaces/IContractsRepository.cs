using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IContractsRepository
  {
    void AddDestiny(Destiny destiny);

    void UpdateDestiny(Destiny destiny);

    void DeleteDestiny(Destiny destiny);

    List<Destiny> GetDestinies();
  }
}
