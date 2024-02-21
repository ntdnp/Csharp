using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3.Books
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Quantity { get; set; }
    }
}
