using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using admin.bookstore.Data;
using Volo.Abp.DependencyInjection;

namespace admin.bookstore.EntityFrameworkCore
{
    public class EntityFrameworkCorebookstoreDbSchemaMigrator
        : IbookstoreDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorebookstoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the bookstoreMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<bookstoreMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}