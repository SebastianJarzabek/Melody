using Dapper;
using Melody.Service.Entity;
using Melody.Service.SqlProceures;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Melody.Service
{
  class Program
  {
    public static void Main(string[] args)
    {
      string sql = "SELECT * FROM Invoice WHERE InvoiceID = @InvoiceID; SELECT * FROM InvoiceItem WHERE InvoiceID = @InvoiceID;";

      //using (var connection =My.ConnectionFactory())
      //{
      //  connection.Open();

      //  using (var multi = connection.QueryMultiple(sql, new { InvoiceID = 1 }))
      //  {
      //    var invoice = multi.Read<Employee>().First();
      //    var invoiceItems = multi.Read<InvoiceItem>().ToList();
      //  }
      //}





      DataSet dataset = new DataSet();
      var pom = new SqlProceure();
      using (SqlConnection connection =
       new SqlConnection("Data Source=SEBASTIAN;Initial Catalog=MelodyDb;Integrated Security=True;"))
      {
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = new SqlCommand(
            "Exec " + pom.GetAllEmployee, connection);
        adapter.Fill(dataset);


        adapter.ToString();


        var result = GetListFromDatabase<Employee>(pom.GetAllEmployee);


        result.ToString();
        // var pom1 =  new ObservableCollection<Destiny>(result);
      }
    }
    private static object GetListFromDatabase<T>(string getDestiny)
    {
      try
      {
        using (var connection = new SqlConnection("Data Source=SEBASTIAN;Initial Catalog=MelodyDb;Integrated Security=True;"))
        {
          return connection.Query<T>(getDestiny, null, null, true, null, commandType: CommandType.StoredProcedure).ToList();
        }
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

  }
}
