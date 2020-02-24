using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Destiny
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Contract { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Name.Length < 5)
      {
        errorMessages.Add("nazwa kontraktu, ");
      }

      if (Contract.Length < 5)
      {
        errorMessages.Add("nr. kontraktu, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
