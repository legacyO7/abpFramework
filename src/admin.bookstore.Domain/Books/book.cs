using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace admin.bookstore.Books
{
    public class book : AuditedAggregateRoot<Guid>
    {
        public String name { get; set; }
        
        public BookType type { get; set; }
        
        public DateTime publishDate { get; set; }
        
        public float price { get; set; }

    }
}