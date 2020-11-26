using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace admin.bookstore.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(bookstoreHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class bookstoreConsoleApiClientModule : AbpModule
    {
        
    }
}
