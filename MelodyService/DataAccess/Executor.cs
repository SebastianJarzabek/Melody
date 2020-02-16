using Dapper;
using log4net;
using Melody.Service.ConfigService;
using Melody.Service.ConfigService.Interfaces;
using Melody.Service.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Melody.Service.DataAccess
{
  public class Executor : IExecutor
  {
    private readonly IConfigServices _configService;

    public Executor()
    {
      _configService = new ConfigServices();
    }

    public ObservableCollection<T> GetObservableCollectionFromDatabase<T>(ILog log, string storedProcedureName, object parameters)
    {
      var result = GetListFromDatabase<T>(log, storedProcedureName, parameters);
      return new ObservableCollection<T>(result);
    }

    public List<T> GetListFromDatabase<T>(ILog log, string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          return connection.Query<T>(storedProcedureName, parameters, null, true, null, commandType: CommandType.StoredProcedure).ToList();
        }
      }
      catch (Exception ex)
      {
        log.Error(ex);
        throw;
      }
    }

    public T GetFromDatabase<T>(ILog log, string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          return connection.Query<T>("UsersLogin", parameters, null, true, null, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
      }
      catch (Exception ex)
      {
        log.Error(ex);
        throw;
      }
    }

    public void GetFromDatabase(ILog log, string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          connection.Query<dynamic>(storedProcedureName, parameters, null, true, null, commandType: CommandType.StoredProcedure);
        }
      }
      catch (Exception ex)
      {
        log.Error(ex);
        throw;
      }
    }

    public bool InsertIntoDatabase(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          var result = connection.Execute(storedProcedureName, parameters, null, null, CommandType.StoredProcedure);

          return IsSuccess(result);
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public bool DeleteFromDatabase(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          var result = connection.Execute(storedProcedureName, parameters, null, null, CommandType.StoredProcedure);

          return IsSuccess(result);
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public DataTable GetFromDatabase(string storedProcedureName)
    {
      var list = new List<object>();
      try
      {
        using (var sqlconnection = new SqlConnection(_configService.GetConnectionString()))
        {
          sqlconnection.Open();

          SqlCommand sqlCommand = new SqlCommand(storedProcedureName, sqlconnection);

          SqlDataReader reader;
          reader = sqlCommand.ExecuteReader();
          DataTable datatable = new DataTable();
          //datatable.Columns.Add(column, typeof(string));
          datatable.Load(reader);
          sqlconnection.Close();

          return datatable;
        }
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    public DataTable ComboboxSugest(string column, string table)
    {
      SqlConnection sqlconnection = new SqlConnection(_configService.GetConnectionString());
      sqlconnection.Open();

      SqlCommand sqlCommand = new SqlCommand($"SELECT DISTINCT [{column}] FROM MelodyDb.dbo.{table} ORDER BY [{column}] ASC", sqlconnection);

      SqlDataReader reader;
      reader = sqlCommand.ExecuteReader();
      DataTable datatable = new DataTable();
      datatable.Columns.Add(column, typeof(string));
      datatable.Load(reader);
      sqlconnection.Close();
      return datatable;
    }

    private bool IsSuccess(int result)
    {
      if (result >= 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}