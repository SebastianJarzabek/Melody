using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public interface ISuppliersRepository
  {
    List<Supplier> GetSuppliers();
  }
}