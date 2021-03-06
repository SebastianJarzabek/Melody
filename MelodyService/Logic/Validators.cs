﻿using Melody.Service.Entity;
using Melody.Service.Logic.Interfaces;
using System;

namespace Melody.Service.Logic
{
  public class Validators : IValidators
  {

    public string PhoneValidate(string phoneNumber)
    {
      try
      {
        if (int.TryParse(phoneNumber, out int result))
        {
          return string.Empty;
        }
        else
        {
          return "Nieprawidłowy format numeru telefonu.\nNumer powinien sie składać tylko cyfr.";
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Validators.PhoneValidate. " + ex);
      }
    }

    public string EmailValidate(string email)
    {
      try
      {
        if (email.Contains("@") && email.Contains("."))
        {
          return string.Empty;
        }
        else
        {
          return $"Nieprawidłowy format adresu email.\nNumer powinien zwierać @ i .";
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Validators.EmailValidate. " + ex);
      }
    }

    //public string TextBoxesValidate(Destiny destiny, Employee emp, Supplier supplier, List<DataClass> toValidate)
    //{
    //  try
    //  {
    //    var obj = new Object();

    //    var stb = new StringBuilder();
    //    stb.AppendLine("Pole:");

    //    if (toValidate.Contains(DataClass.Access))
    //    {

    //      if (string.IsNullOrEmpty(emp.Access.Login)
    //      || string.IsNullOrEmpty(emp.Access.Password))
    //      {
    //        if (string.IsNullOrEmpty(emp.Access.Login))
    //        {
    //          stb.AppendLine(" login,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Access.Password))
    //        {
    //          stb.AppendLine(" hasło,");
    //        }
    //      }
    //    }

    //    if (toValidate.Contains(DataClass.Adress))
    //    {
    //      if (string.IsNullOrEmpty(emp.Adress.Street)
    //      || string.IsNullOrEmpty(emp.Adress.HouseNumber)
    //      || string.IsNullOrEmpty(emp.Adress.ApartmentNumber)
    //      || string.IsNullOrEmpty(emp.Adress.City)
    //      || string.IsNullOrEmpty(emp.Adress.ZipCode)
    //      || string.IsNullOrEmpty(emp.Adress.Country))
    //      {
    //        if (string.IsNullOrEmpty(emp.Adress.Street))
    //        {
    //          stb.AppendLine(" ulica,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Adress.HouseNumber))
    //        {
    //          stb.AppendLine(" numer domu,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Adress.ApartmentNumber))
    //        {
    //          stb.AppendLine(" numer lokalu,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Adress.Country))
    //        {
    //          stb.AppendLine(" miasto,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Adress.ZipCode))
    //        {
    //          stb.AppendLine(" kod-pocztowy,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Adress.Country))
    //        {
    //          stb.AppendLine(" kraj,");
    //        }
    //      }
    //    }

    //    if (toValidate.Contains(DataClass.ContactDetails))
    //    {
    //      if (string.IsNullOrEmpty(emp.ContactDetails.PhoneNumber)
    //      || string.IsNullOrEmpty(emp.ContactDetails.Email)
    //      || string.IsNullOrEmpty(emp.ContactDetails.Webside))
    //      {
    //        if (string.IsNullOrEmpty(emp.ContactDetails.PhoneNumber))
    //        {
    //          stb.AppendLine(" numer telefonu,");
    //        }
    //        if (string.IsNullOrEmpty(emp.ContactDetails.Email))
    //        {
    //          stb.AppendLine(" e-mail,");
    //        }
    //        if (string.IsNullOrEmpty(emp.ContactDetails.Webside))
    //        {
    //          stb.AppendLine(" strona internetowa,");
    //        }
    //      }
    //    }

    //    if (toValidate.Contains(DataClass.Destiny))
    //    {
    //      if (string.IsNullOrWhiteSpace(destiny.Name)
    //      || string.IsNullOrWhiteSpace(destiny.Contract))
    //      {

    //        if (string.IsNullOrWhiteSpace(destiny.Name))
    //        {
    //          stb.AppendLine(" Nazwa");
    //        }
    //        if (string.IsNullOrWhiteSpace(destiny.Contract))
    //        {
    //          stb.AppendLine(" Numer Kontraktu");
    //        }
    //      }
    //    }


    //    if (toValidate.Contains(DataClass.Employee))
    //    {
    //      if (string.IsNullOrEmpty(emp.Name)
    //      || string.IsNullOrEmpty(emp.Surname)
    //      || string.IsNullOrEmpty(emp.Departament)
    //      || string.IsNullOrEmpty(emp.Position))
    //      {
    //        if (string.IsNullOrEmpty(emp.Name))
    //        {
    //          stb.AppendLine(" imie,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Surname))
    //        {
    //          stb.AppendLine(" nazwisko,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Departament))
    //        {
    //          stb.AppendLine(" dział,");
    //        }
    //        if (string.IsNullOrEmpty(emp.Position))
    //        {
    //          stb.AppendLine(" stanowisko,");
    //        }
    //      }
    //    }


    //    if (toValidate.Contains(DataClass.InventoryLevel))
    //    {

    //    }


    //    if (toValidate.Contains(DataClass.Material))
    //    {

    //    }


    //    if (toValidate.Contains(DataClass.Note))
    //    {

    //    }


    //    if (toValidate.Contains(DataClass.Order))
    //    {

    //    }

    //    if (toValidate.Contains(DataClass.Supplier))
    //    {
    //      if (string.IsNullOrEmpty(supplier.Name))
    //      {
    //        stb.AppendLine(" nazwa,");
    //      }
    //    }

    //    if (toValidate.Contains(DataClass.Unit))
    //    {

    //    }
    //    if (toValidate.Contains(DataClass.WarehouseAdmission))
    //    {

    //    }
    //    if (toValidate.Contains(DataClass.WarehouseIssue))
    //    {

    //    }

    //    stb.Remove(stb.Length - 1, 1);
    //    stb.AppendLine("musi zostać uzupełnione.");

    //    if (stb.Length > 32)
    //    {
    //      return stb.ToString();
    //    }
    //    else
    //    {
    //      return string.Empty;
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    throw new Exception("Exception was occured in Validators. TextBoxesValidate. " + ex);
    //  }

    //}

    public string IsIntContractValidate(Destiny destiny)
    {
      try
      {
        if (!int.TryParse(destiny.Contract, out int result))
        {
          return "Nieprawidłowy format numeru Kontraktu.\nNumer powinien sie składać tylko cyfr.";
        }
        else
        {
          return string.Empty;
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Validators.IsIntContractValidate. " + ex);
      }
    }

    public string IsIntValidate(string intToCheck)
    {
      try
      {
        if (!int.TryParse(intToCheck, out int result))
        {
          return "Nieprawidłowy format liczbowy.\nPole powinno sie składać tylko cyfr.";
        }
        else
        {
          return string.Empty;
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Validators.IsIntValidate. " + ex);
      }
    }

    public string IsIntContractValidate(string textToCheck, string message)
    {
      try
      {
        if (!int.TryParse(textToCheck, out int result))
        {
          return $"Nieprawidłowy format {message}.\nNumer powinien sie składać tylko cyfr.";
        }
        else
        {
          return string.Empty;
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Validators.IsIntContractValidate. " + ex);
      }
    }
  }
}