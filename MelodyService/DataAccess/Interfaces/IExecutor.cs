using log4net;
using Melody.Service.Entity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IExecutor
  {
    void InsertIntoDatabase(string storedProcedureName, object parameters);
    void DeleteFromDatabase(string storedProcedureName, object parameters);

    List<T> GetListFromDatabase<T>(string storedProcedureName, object parameters);

    T GetFromDatabase<T>(string storedProcedureName, object parameters);

    void GetFromDatabase(string storedProcedureName, object parameters);

    ObservableCollection<T> GetObservableCollectionFromDatabase<T>(string storedProcedureName, object parameters);
    
    DataTable ComboboxSugest(string column, string table);
    int CheckLastOrder(string lastOrderNumber);
  }
}