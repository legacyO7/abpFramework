using admin.bookstore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace admin.bookstore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(bookstoreEntityFrameworkCoreDbMigrationsModule),
        typeof(bookstoreApplicationContractsModule)
        )]
    public class bookstoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
