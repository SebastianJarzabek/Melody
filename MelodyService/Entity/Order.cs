using Melody.Service.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Order
  {
    public int IdOrder { get; set; }

    public int OrderNumber { get; set; }

    public DateTime DateOfOrder { get; set; }

    public string OrderingEmployee { get; set; }

    public Supplier Supplier { get; set; }

    public Destiny Destiny { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }

    public Note Note { get; set; }

    public string ReceivingEmployee { get; set; }

    public DateTime PlannedDateOfReceipt { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (DateOfOrder < DateTime.Now.Subtract(TimeSpan.FromDays(7)))
      {
        errorMessages.Add("data zamówienia, ");
      }
      if (OrderingEmployee.Length < 5)
      {
        errorMessages.Add("zamawiający, ");
      }
      if (Quantity < 0)
      {
        errorMessages.Add("ilość zamawiana, ");
      }
      if (PlannedDateOfReceipt < DateTime.Now.Subtract(TimeSpan.FromDays(1)))
      {
        errorMessages.Add("data odbioru, ");
      }
      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
