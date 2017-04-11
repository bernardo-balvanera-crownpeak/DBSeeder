using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContextSeed
{
  /// <summary>
  /// The simple representation of a DbSeeder
  /// </summary>
  public interface IDbSeeder
  {
    void Seed();
  }
}
