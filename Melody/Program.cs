﻿using Dapper.FluentMap.Configuration;
using log4net;
using Melody;
using Melody.Service.DataAccess;
using Melody.View.Controls;
using Melody.View.Window;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Melody
{
  static class Program
  {
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    [STAThread]
    static void Main()
    {
      try
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Main());
        OnFirstStart.InitAccess();
      }
      catch (Exception ex)
      {
        Log.Error(ex);
      }
      
    }
  }
}
