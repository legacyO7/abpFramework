using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace admin.bookstore.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class bookstoreMigrationsDbContextFactory : IDesignTimeDbContextFactory<bookstoreMigrationsDbContext>
    {
        public bookstoreMigrationsDbContext CreateDbContext(string[] args)
        {
            bookstoreEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<bookstoreMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new bookstoreMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../admin.bookstore.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
