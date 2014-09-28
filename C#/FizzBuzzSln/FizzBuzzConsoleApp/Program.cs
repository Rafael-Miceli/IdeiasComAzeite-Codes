using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsoleApp
{
    public class FizzBuzzConsole
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int number = 1; number <= 100; number++)
            {
                Console.WriteLine(fizzBuzz.Validate(number));
            }
        }

        
    }

    public class FizzBuzz
    {
        public bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        public bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        public bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

        public string Validate(int number)
        {
            if (IsFizzBuzz(number))
            {
                return "FizzBuzz";
            }
            if (IsBuzz(number))
            {
                return "Buzz";
            }
            if (IsFizz(number))
            {
                return "Fizz";
            }
            
            return number.ToString();
            
        }
    }
}
