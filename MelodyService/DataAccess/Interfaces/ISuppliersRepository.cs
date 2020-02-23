using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public interface ISuppliersRepository
  {
    void AddSupplier(Supplier supplier);

    void UpdateSupplier(Supplier supplier);

    void DeleteSupplier(Supplier supplier);

    List<Supplier> GetSuppliers();
  }
}