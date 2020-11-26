using Volo.Abp.Modularity;

namespace admin.bookstore
{
    [DependsOn(
        typeof(bookstoreApplicationModule),
        typeof(bookstoreDomainTestModule)
        )]
    public class bookstoreApplicationTestModule : AbpModule
    {

    }
}