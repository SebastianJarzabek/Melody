using log4net;
using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.SqlProceures;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Melody.Service
{
  class Program
  {
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    public static void Main(string[] args)
    {
      var execute = new SqlProceure();
      try
      {/////////////////////działa
        var pom = new Executor();
        var access = new Access
        {
          Login = "admin",
          Password = "admin",
        };

        var parameters = new { loginInparm = access.Login, passwordInParm = access.Password };

        var a = pom.GetFromDatabase<bool>(Log, execute.UsersLogin, parameters);
      }
      catch (Exception ex)
      {

        throw ex;

        string login = "     admin";
        string password = "admin    ";

        List<string> list = new List<string>();
        //list.Add(login);
        //list.Add(password);



        list.Add(TrimAccessParms.TrimParms(login));
        list.Add(TrimAccessParms.TrimParms(password));

        var newlist = new List<string>();
        newlist.Add("1");
        newlist.Add("Sebastian");
        newlist.Add("Jarząbek");

        Console.ReadKey();
      }
    }
  }
}
