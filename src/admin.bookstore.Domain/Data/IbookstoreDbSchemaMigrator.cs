using System.Threading.Tasks;

namespace admin.bookstore.Data
{
    public interface IbookstoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
