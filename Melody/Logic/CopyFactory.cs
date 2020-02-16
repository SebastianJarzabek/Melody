using System;
using System.Data;

namespace Melody.Logic
{
  public class CopyFactory : ICloneable
  {
    public DataTable dt;

    public CopyFactory(DataTable dt)
    {
      this.dt = dt;
    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }
  }
}

