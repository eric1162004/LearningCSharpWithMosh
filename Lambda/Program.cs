/* Lambda Expression is an anonymous method
 * - no access modifier
 * - no name
 * - no return statement
 */
using System;

namespace Lambda
{

    class Program
    {
        static void Main(string[] args)
        {
            // args => expression

            // () => ...
            // x => ...  
            // (x,y,z) => ..

            // Example 1
            Func<int, int> square = n => n*n;
            Console.WriteLine(square(1));

            // Ecample 2
            const int FACTOR = 5;
            Func<int, int> multipler = n => n * FACTOR;
            Console.WriteLine( multipler(10) );

            // Example 3
            var books = new BookRepository().GetBooks();
            books.FindAll(book => book.Price < 10);

        }


    }
}
