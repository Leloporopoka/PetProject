using Data.Database;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace Logic.Tests.DatabaseUtils
{
    public class SqliteDbContext : WorldMoodDbContext
    {
        private readonly DbConnection _connection;
        public SqliteDbContext()
         : base(new DbContextOptionsBuilder<WorldMoodDbContext>()
             .UseSqlite(new SqliteConnection("Filename=:memory:"))
             .EnableSensitiveDataLogging()
             .ConfigureWarnings(x =>
             {
                 x.Ignore(InMemoryEventId.TransactionIgnoredWarning);
                 x.Log(RelationalEventId.MultipleCollectionIncludeWarning);
             })
             .Options)
        {
            _connection = Database.GetDbConnection();
            _connection.Open();

            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public override void Dispose()
        {
            Database.EnsureDeleted();
            _connection?.Dispose();
            base.Dispose();
        }
    }
}
