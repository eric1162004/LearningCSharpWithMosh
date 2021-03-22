using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
