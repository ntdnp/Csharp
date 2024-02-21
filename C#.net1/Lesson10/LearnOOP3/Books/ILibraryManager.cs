using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3.Books
{
    public interface ILibraryManager
    {
        void ShowBook();
        void AddBook(CreateBookViewModel model);
        void SearchBook(string keyword);
        void BorrowBook(string keyword);
        void GetBookBack(string keyword);
    }
    public class LibraryManager : ILibraryManager
    {
        private List<Book> listBooks;
        private readonly List<Category> categories;
        public LibraryManager()
        {
            listBooks = new List<Book>();
            categories = new List<Category>() { new Category(1, "music"), new Category(2, "cook") };
        }
        public void AddBook(CreateBookViewModel model)
        {
            var currentBook = listBooks.FirstOrDefault(s => s.Id == model.Id);
            if (currentBook != null)
            {
                Console.WriteLine($" this id ={model.Id} has existed");
                return;


            }
            var book = new Book(model.Id, model.Name, model.Author, model.CategoryId, model.Quantity);
            listBooks.Add(book);
            Console.WriteLine($" this book ={model.Name} is added to library");
        }

        public void BorrowBook(string keyword)
        {
            var book = listBooks.FirstOrDefault(s => s.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {

                book.Quantity--;
                Console.WriteLine($"Borrow book {book.Name} success");

            }
            else
            {
                Console.WriteLine($"book is not found");
            }
        }

        public void GetBookBack(string keyword)
        {

        }

        public void SearchBook(string keyword)
        {

        }

        public void ShowBook()
        {
            var bookVm = from b in listBooks
                         join c in categories
                         on b.CategoryId equals c.Id
                         select new BookViewModel
                         {
                             Id = b.Id,
                             Name = b.Name,
                             CategoryIdName = c.Name,
                             PublishedDate = b.PublishedDate,
                             Quantity = b.Quantity,
                             Author = b.Author,
                         };
            var result = bookVm.ToList();
        }

    }
}
