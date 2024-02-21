using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Quantity { get; set; }

        public Book(int id, string name, string author, int categoryId, int quantity)
        {
            Id = id;
            Name = name;
            Author = author;
            CategoryId = categoryId;
            Quantity = quantity;
            PublishedDate = DateTime.Now;
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
