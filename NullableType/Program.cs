using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable is a generic type
            Nullable<DateTime> date = null;

            // Shortcut
            DateTime? date2 = null;

            Console.WriteLine( "GetValueOrDefault: ", date.GetValueOrDefault());
            Console.WriteLine( "HasValue: ", date.HasValue);
            Console.WriteLine( "Value: ", date.Value);

            // Assigning Nullable to a Non-nullable and back to Nullable
            DateTime? date3 = new DateTime(2014, 1, 11);
            DateTime date4 = date.GetValueOrDefault();
            DateTime? date5 = date4;

            // Null Coalescing Operator Example
            DateTime? date6 = null;
            DateTime date7;

            if (date6 != null)
                date7 = date.GetValueOrDefault();
            else
                date7 = DateTime.Now;

            DateTime date8 = date6 ?? DateTime.Now;


        }
    }
}
