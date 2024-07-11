using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedOperatorsProject
{
    internal class Program
    {
        public const int DIVISOR = 2;
        static void Main(string[] args)
        {
            //int number1 = 10, number2 = 20, number3 = 0;

            //number3 = number1+++number1;
            //Console.WriteLine(number3);
            //Console.WriteLine(number1);

            //number3 = number1++ + --number2;
            //Console.WriteLine(number3);
            //Console.WriteLine(number1);
            //Console.WriteLine(number2);

            //number3 = number1++ + ++number1;
            //Console.WriteLine(number3);
            //Console.WriteLine(number1);

            Console.Write("Enter a number to check if it is a perfect number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckPerfectNumber(inputNumber));
        }
        
        static string CheckPerfectNumber(int number)
        {
            int iterator = 1;
            int sum = 0;
            while (iterator <= number / 2)
            {
                if (number % iterator == 0)
                    sum += iterator;
                iterator++;
            }

            return sum == number ? "It is a Perect Number." : "It is not a Perfect Number.";
        }
    }
}
