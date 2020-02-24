using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class InventoryLevel
  {
    public InventoryLevel()
    {
      var Material = new Material();
      var Unit = new Unit();
    }
    public int Id { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Quantity < 0)
      {
        errorMessages.Add("ilość, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
