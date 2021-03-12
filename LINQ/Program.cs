using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.Where(b => b.Price < 10);

            // LINQ Query Operator
            var cheaperBooks = 
                    from b in books
                    where b.Price < 10
                    orderby b.Title
                    select b.Title;

            // LINQ Methods can be chained
            var orderedByTitle = books
                                                    .OrderBy(b => b.Title)
                                                    .Select(b => b.Title);

            foreach(var b in orderedByTitle)
                Console.WriteLine(b);

            // Other Examples
            var result1 = books.Single(book => book.Title == "A");
            var result2= books.SingleOrDefault(b => b.Title == "A");
           
            var result3 = books.FirstOrDefault(b => b.Title == "A");
            var result4 = books.LastOrDefault(b => b.Title == "A");

            var result5 = books.Skip(2).Take(3);

            var result6 = books.Count();
            var result7 = books.Max(b=>b.Price);
            var result8 = books.Sum(b=>b.Price);
            var result9 = books.Average(b=>b.Price);

  


            Console.ReadLine();

        }
    }
}
