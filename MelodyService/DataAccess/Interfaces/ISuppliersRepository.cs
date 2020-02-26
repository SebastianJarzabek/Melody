using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public interface ISuppliersRepository
  {
    void AddSupplier(Supplier supplier);

    void UpdateSupplier(Supplier supplier);

    void DeleteSupplier(Supplier supplier);

    List<SupplierView> GetSuppliers();
  }
}