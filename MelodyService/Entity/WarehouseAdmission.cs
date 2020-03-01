using Melody.Service.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class WarehouseAdmission
  {
    public int Id { get; set; }

    public int WarehouseAdmissionNumber { get; set; }

    public DateTime DateOfAdmission { get; set; }

    public string HostEmployee { get; set; }

    public Supplier Supplier { get; set; }

    public Order Order { get; set; }

    public Destiny Destiny { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }

    public Note Note { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (DateOfAdmission < DateTime.Now.Subtract(TimeSpan.FromDays(7)))
      {
        errorMessages.Add("data przyjęcia, ");
      }
      if (HostEmployee.Length < 5)
      {
        errorMessages.Add("przyjmujący, ");
      }
      if (Quantity < 0)
      {
        errorMessages.Add("ilość przyjęta, ");
      }
      
      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
