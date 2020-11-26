using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace admin.bookstore.EntityFrameworkCore
{
    [DependsOn(
        typeof(bookstoreEntityFrameworkCoreModule)
        )]
    public class bookstoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<bookstoreMigrationsDbContext>();
        }
    }
}
