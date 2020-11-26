using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace admin.bookstore.Books
{
    public interface IBookAppService:ICrudAppService<bookdto,Guid,PagedAndSortedResultRequestDto,CreateUpdatebooksdto>
    {
        
    }
}