using log4net;
using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.SqlProceures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Melody.Service
{
  class Program
  {
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    public static void Main(string[] args)
    {
      var list = new List<object>();
      using (SqlConnection connection = new SqlConnection(
               "Data Source=SEBASTIAN;Initial Catalog=MelodyDb;Integrated Security=True;"))
      {
        connection.Open();
        SqlCommand command = new SqlCommand("Exec GetEmployee 1, 'Sebastian', 'Jarząbek'", connection);
        SqlDataReader reader = command.ExecuteReader();
        DataTable schemaTable = reader.GetSchemaTable();

        foreach (DataRow row in schemaTable.Rows)
        {
          foreach (DataColumn column in schemaTable.Columns)
          {
            Console.WriteLine(String.Format("{0} = {1}",
               column.ColumnName, row[column]));
          }



          //SqlDataReader reader = command.ExecuteReader();
          //while (reader.Read())
          //{
          //  list.Add(reader[1]);
          //}
        }
        var pom = list.Count;






        var execute = new SqlProceure();
        try
        {
          var pom1 = new Executor();

          var a = pom1.GetFromDatabase(execute.GetInventoryLevel, null);
        }
        catch (Exception ex)
        {

          throw ex;
        }



        try
        {/////////////////////działa
          var pom12 = new Executor();
          var access = new Access
          {
            Login = "admin",
            Password = "admin",
          };

          var parameters = new { loginInparm = access.Login, passwordInParm = access.Password };

          var a = pom12.GetFromDatabase<bool>(Log, execute.UsersLogin, parameters);
        }
        catch (Exception ex)
        {

          throw ex;

          string login = "     admin";
          string password = "admin    ";

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
}
