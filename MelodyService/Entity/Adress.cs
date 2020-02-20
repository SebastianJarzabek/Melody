﻿using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Adress
  {
    public int IdAdress { get; set; }

    public string Street { get; set; }

    public string HouseNumber { get; set; }

    public string ApartmentNumber { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string Country { get; set; }
  }
}
