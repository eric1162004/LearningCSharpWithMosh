using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            // obj.GetHashCode();
            
            // Using Reflection
            var methodInfo = obj.GetType().GetMethod("GetHarshCode");
            // methodInfo.Invoke(null);

            // Using dynamic
            dynamic excelObject = "mosh";
            // excelObject.Optimal();

            // Type resolve at runtime and can be changed to other type
            dynamic name = "Mosh";
            name = 6;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;


        }
    }
}
