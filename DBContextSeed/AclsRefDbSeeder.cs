using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContextSeed.EntityFramework;
using DBContextSeed.Models;

namespace DBContextSeed
{

  /// <summary>
  /// An example of a Database seeder that will issue a INSERT_INDENTITY command before seeding any data.
  /// </summary>
  /// <seealso cref="DBContextSeed.DBSeederWithIdentity{DBContextSeed.Models.Acls}" />
  public class AclsRefDbSeeder : DBSeederWithIdentity<Acls>
  {
    protected AclsRefDbSeeder(DbSet<Acls> dbSet, string tableName, Database database) : base(dbSet, tableName, database)
    {
      
    }

    /// <summary>
    /// Gets the seed data.
    /// </summary>
    /// <returns>The actual data required to seed this table in particular.</returns>
    protected override Acls[] GetSeedData()
    {
      // Return data as it is now inside EnsureSeedData();
      throw new NotImplementedException();
    }
  }
}
