using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace admin.bookstore.EntityFrameworkCore
{
    public static class bookstoreDbContextModelCreatingExtensions
    {
        public static void Configurebookstore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(bookstoreConsts.DbTablePrefix + "YourEntities", bookstoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}