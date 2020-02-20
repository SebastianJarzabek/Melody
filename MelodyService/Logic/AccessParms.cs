using Melody.Service.Entity;
using Melody.Service.Logic.Interfaces;
using System;

namespace Melody.Service.Logic
{
  public class TrimAccessParms : ITrimAccessParms
  {
    public string TrimParms(string toTrimParm)
    {
      try
      {
        return toTrimParm.Trim();
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in TrimAccessParms.TrimParms. " + ex);
      }
    }

    public Employee TrimParms(Employee emp)
    {
      try
      {
        emp.Access.Login = emp.Access.Login.Trim();
        emp.Access.Password = emp.Access.Password.Trim();
        return emp;
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in TrimAccessParms.TrimParms - Employee " + ex);
      }
    }

    public string TrimPassword(string pass)
    {
      try
      {
        return pass.Trim();
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in TrimAccessParms.TrimPassword. " + ex);
      }
    }
  }
}