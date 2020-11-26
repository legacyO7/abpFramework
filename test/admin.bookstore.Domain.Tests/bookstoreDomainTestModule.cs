using admin.bookstore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace admin.bookstore
{
    [DependsOn(
        typeof(bookstoreEntityFrameworkCoreTestModule)
        )]
    public class bookstoreDomainTestModule : AbpModule
    {

    }
}