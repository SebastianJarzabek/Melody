using Melody.Service.Entity;
using System;

namespace Melody.Service.Logic
{
  public static class TrimAccessParms
  {
    public static string TrimParms(string toTrimParm)
    {
      return toTrimParm.Trim();
    }

    public static Employee TrimParms(Employee emp)
    {
      emp.Access.Login = emp.Access.Login.Trim();
      emp.Access.Password = emp.Access.Password.Trim();

      return emp;
    }

    public static string TrimPassword(string pass)
    {
      return pass.Trim();
    }
  }
}