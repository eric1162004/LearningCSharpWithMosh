using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    /// <summary>
    ///  Generic Constraints
    ///  where T : IComparable 
    ///  where T : Product
    ///  where T : struct .. T must be a value type ie int, float.. 
    ///  where T : class
    ///  where T: new()  .. T must have a default ctor
    /// </summary>


    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("has vaule ?"+number.HasValue);
            Console.WriteLine("Value?"+number.GetValueOrDefault());

            Console.ReadLine();
        }
    }
}
