using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class ContactDetails
  {
    public int Id { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string Webside { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (PhoneNumber.Length < 7)
      {
        errorMessages.Add("nr. telefonu, ");
      }

      if (Email.Length < 5)
      {
        errorMessages.Add("adres e-mail, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
