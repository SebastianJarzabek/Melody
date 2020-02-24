using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Adress
  {
    public int Id { get; set; }

    public string Street { get; set; }

    public string HouseNumber { get; set; }

    public string ApartmentNumber { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string Country { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Street.Length < 5)
      {
        errorMessages.Add("ulica, ");
      }

      if (HouseNumber.Length < 5)
      {
        errorMessages.Add("nr. domu, ");
      }

      if (ApartmentNumber.Length < 5)
      {
        errorMessages.Add("nr. lokalu, ");
      }

      if (City.Length < 5)
      {
        errorMessages.Add("miasto, ");
      }

      if (ZipCode.Length < 5)
      {
        errorMessages.Add("kod-pocztowy, ");
      }

      if (Country.Length < 5)
      {
        errorMessages.Add("kraj, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
