using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class ReturnFizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(WriteFizzBuzz(i));
            }
        }

        public static string WriteFizzBuzz(int number)
        {
            if (number <= 0 || number > 100)
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 100 inclusive.");

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
