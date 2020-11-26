using admin.bookstore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace admin.bookstore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class bookstoreController : AbpController
    {
        protected bookstoreController()
        {
            LocalizationResource = typeof(bookstoreResource);
        }
    }
}