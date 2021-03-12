using System.Collections.Generic;

namespace LINQ
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title ="A", Price = 5},
                new Book() {Title ="B", Price = 9.99f},
                new Book() {Title ="C", Price = 12},
                new Book() {Title ="D", Price = 7},
                new Book() {Title ="E", Price = 9}
            };
        }
    }
}
