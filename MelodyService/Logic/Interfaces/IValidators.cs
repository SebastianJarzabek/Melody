using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.Logic.Interfaces
{
  public interface IValidators
  {
    string TextBoxesValidate(Destiny destiny, Employee emp, Supplier supplier, List<DataClass> toValidate);

    string IsIntContractValidate(Destiny destiny);

    string EmailValidate(string email);

    string PhoneValidate(string phoneNumber);
  }
}
