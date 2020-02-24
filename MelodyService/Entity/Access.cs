using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Access
  {
    public int Id { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Login.Length < 5)
      {
        errorMessages.Add("Login, ");
      }

      if (Password.Length<5)
      {
        errorMessages.Add("hasło, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}