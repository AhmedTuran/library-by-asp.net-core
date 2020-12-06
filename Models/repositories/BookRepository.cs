using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models.repositories
{
    public class BookRepository : BookStorRepository<book>
    {
        List<book> books;
        public BookRepository()
        {
            books = new List<book>()
            {
                new book
                {
                    id=1, title="Gaza project doc"
                }, 
                new book
                {
                    id=2, title="Rafah project doc"
                },
                new book
                {
                    id=3, title="Gaza project doc"
                }

            };

        }

        public void Add(book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = fined(id);
            books.Remove(book);
        }

        public book fined(int id)
        {
            var book = books.SingleOrDefault(b => b.id == id);
            return book;
        }

        public IList<book> list()
        {
            return books;
        }

        public void Update(int id,book newBook)
        {
            var book = fined(id);
            book.title = newBook.title;
            book.author = newBook.author;


        }
    }
}
