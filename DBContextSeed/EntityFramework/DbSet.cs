using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContextSeed.EntityFramework
{
  public class DbSet<T>
  {
    public void AddRange(T[] items) { }
  }
}
