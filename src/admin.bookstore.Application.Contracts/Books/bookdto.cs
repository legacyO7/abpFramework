using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

namespace admin.bookstore.Books
{
    public class bookdto :AuditedEntity<Guid>, IEntityDto<Guid>
    {
        public String name { get; set; }
        
        public BookType type { get; set; }
        
        public DateTime publishDate { get; set; }
        
        public float price { get; set; }

        public Guid Id { get; set; }
    }
}