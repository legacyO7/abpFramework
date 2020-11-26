using System;
using System.Threading.Tasks;
using admin.bookstore.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace admin.bookstore
{
    public class BookStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<book, Guid> _bookRepository;
       
               public BookStoreDataSeederContributor(IRepository<book, Guid> bookRepository)
               {
                   _bookRepository = bookRepository;
               }
       
               public async Task SeedAsync(DataSeedContext context)
               {
                   if (await _bookRepository.GetCountAsync() <= 0)
                   {
                       await _bookRepository.InsertAsync(
                           new book
                           {
                               name = "1984",
                               type = BookType.a,
                               publishDate =  new DateTime(1949, 6, 8),
                               price = 19.84f
                           },
                           autoSave: true
                       );
       
                       await _bookRepository.InsertAsync(
                           new book
                           {
                               name = "The Hitchhiker's Guide to the Galaxy",
                               type = BookType.d,
                               publishDate = new DateTime(1995, 9, 27),
                               price = 42.0f
                           },
                           autoSave: true
                       );
                   }
               }
           }
       }