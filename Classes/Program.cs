using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            var cookie = new HttpCookie();
            cookie["name"] = "KinCat";




            System.Console.ReadKey();
        }

        static void TryParseExample()
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {

                System.Console.WriteLine(number);
            }
            else
            {
                System.Console.WriteLine("Conversion failed");
            }

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine("The sum of 1,2,3 is {0}", calculator.Add(1, 2, 3));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                System.Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(new Point(100, 200));
                System.Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Argument is null.");
                throw;
            }
        }

        static void CreateClasses()
        {
            Person person = Person.Parse("John");
            person.Introduce("Peter");

            var customer = new Customer(1);
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }

    }
}
