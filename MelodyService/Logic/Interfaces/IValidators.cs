using Melody.Service.Entity;

namespace Melody.Service.Logic.Interfaces
{
  public interface IValidators
  {
    string IsIntContractValidate(Destiny destiny);

    string IsIntContractValidate(string textToCheck, string message);

    string EmailValidate(string email);

    string PhoneValidate(string phoneNumber);
  }
}
