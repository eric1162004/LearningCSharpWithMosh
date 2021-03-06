/* Lambda Expression is an anonymous method
 * - no access modifier
 * - no name
 * - no return statement
 */

using System.Collections.Generic;

namespace Lambda
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Title 1", Price = 5 },
                new Book() { Title = "Title 2", Price = 7 },
                new Book() { Title = "Title 3", Price = 17 }
            };
        }
    }
}
