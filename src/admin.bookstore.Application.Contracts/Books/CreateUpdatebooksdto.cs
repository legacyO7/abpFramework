using System;

namespace admin.bookstore.Books
{
    public class CreateUpdatebooksdto
    {
        public String name { get; set; }
        
        public BookType type { get; set; }
        
        public DateTime publishDate { get; set; }
        
        public float price { get; set; }
    }
}