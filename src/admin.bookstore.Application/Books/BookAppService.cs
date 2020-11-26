using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace admin.bookstore.Books
{
    public class BookAppService:CrudAppService<book,bookdto,Guid,PagedAndSortedResultRequestDto,CreateUpdatebooksdto>,IBookAppService
    {
        public BookAppService(IRepository<book, Guid> repository) : base(repository)
        {
            
        }
    }
}