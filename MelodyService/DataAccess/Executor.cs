using Dapper;
using log4net;
using Melody.Service.ConfigService;
using Melody.Service.ConfigService.Interfaces;
using Melody.Service.DataAccess.Interfaces;
using System;
using System.Collections;
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

    public void InsertIntoDatabase(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          var pom = connection.Execute(storedProcedureName, parameters, null, null, CommandType.StoredProcedure);
          var a = pom.GetType();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public List<object> GetFromDatabase(string storedProcedureName, object parameters)
    {
      var list = new List<object>();
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          var reader = connection.ExecuteReader(storedProcedureName, parameters, null, null, CommandType.StoredProcedure);
          while (reader.Read())
          {
            list.Add(reader[0]);
          }

          return list;
        }
      }
      catch (Exception ex)
      {
        throw;
      }
    }
  }
}