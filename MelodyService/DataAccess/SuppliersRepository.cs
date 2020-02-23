using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public class SuppliersRepository : ISuppliersRepository
  {
    private readonly IExecutor _executor;

    public SuppliersRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public void AddSupplier(Supplier supplier)
    {
      var parameters = new
      {
        name = supplier.Name,
        streetIn = supplier.Adress.Street,
        houseNumberIn = supplier.Adress.HouseNumber,
        apartmentNumberIn = supplier.Adress.ApartmentNumber,
        cityIn = supplier.Adress.City,
        zipCodeIn = supplier.Adress.ZipCode,
        countryIn = supplier.Adress.Country,
        phoneNumberIn = supplier.ContactDetails.PhoneNumber,
        emailIn = supplier.ContactDetails.Email,
        websideIn = supplier.ContactDetails.Webside
      };

      _executor.InsertIntoDatabase(new SqlProcedure().AddSupplier, parameters);
    }

    public void UpdateSupplier(Supplier supplier)
    {
      var parameters = new
      {
        IdSupplier = supplier.Id,
        name = supplier.Name,
        streetIn = supplier.Adress.Street,
        houseNumberIn = supplier.Adress.HouseNumber,
        apartmentNumberIn = supplier.Adress.ApartmentNumber,
        cityIn = supplier.Adress.City,
        zipCodeIn = supplier.Adress.ZipCode,
        countryIn = supplier.Adress.Country,
        phoneNumberIn = supplier.ContactDetails.PhoneNumber,
        emailIn = supplier.ContactDetails.Email,
        websideIn = supplier.ContactDetails.Webside
      };

      _executor.InsertIntoDatabase(new SqlProcedure().UpdateSupplier, parameters);
    }

    public void DeleteSupplier(Supplier supplier)
    {
      var parameters = new
      {
        name = supplier.Name
      };
      _executor.DeleteFromDatabase(new SqlProcedure().DeleteSupplier, parameters);
    }

    public List<Supplier> GetSuppliers() => _executor.GetListFromDatabase<Supplier>(new SqlProcedure().GetAllSupplier, null);
  }
}
