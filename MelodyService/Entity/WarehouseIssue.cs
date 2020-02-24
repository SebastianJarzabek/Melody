using Melody.Service.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class WarehouseIssue
  {
    public int Id { get; set; }

    public DateTime DateOfReceipt { get; set; }

    public string ReceivingEmployee { get; set; }

    public string HostEmployee { get; set; }

    public Order Order { get; set; }

    public Destiny Destiny { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }

    public Note Note { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();

      if (DateOfReceipt < DateTime.Now.Subtract(TimeSpan.FromDays(7)))
      {
        errorMessages.Add("data odbioru, ");
      }
      if (HostEmployee.Length < 5)
      {
        errorMessages.Add("odbierający, ");
      }
      if (Quantity < 0)
      {
        errorMessages.Add("ilość odebrana, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
