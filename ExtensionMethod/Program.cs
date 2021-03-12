using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example - how to create extension method
            string post = "This is a very long blog post.";
            var ShortenedPost = post.Shorten(5);
            Console.WriteLine(ShortenedPost);

            // Example - shows using IEnumerable extension method
            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18};
            var max = numbers.Max();
            Console.WriteLine(max);


            Console.ReadLine();
        }
    }

    
}
