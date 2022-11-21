using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            Console.Write("1-sonni kiriting : ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-sonni kiriting : ");
            secondNum= Convert.ToInt32(Console.ReadLine());

            string message =
                firstNum >= 0
                ? "1st number is positive"
                : "1st number is negative";

            Console.WriteLine(message);

            if (secondNum > firstNum)
            {
                Console.WriteLine("Second number is older");
            }
            else if (secondNum == firstNum)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("First number is older");
            }

            Console.WriteLine("2 ta son ustida amallar, '+, -, /, *, %'");
            string amal = Console.ReadLine();
            switch (amal)
            {
                case "+":
                    Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                    break;
                case "-":
                    Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                    break;
                case "*":
                    Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                    break;
                case "/":
                    Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                    break;
                case "%":
                    Console.WriteLine($"{firstNum} % {secondNum} = {firstNum % secondNum}");
                    break;
                default:
                    break;
            }

            //Console.WriteLine("2 ta son ustida amallar, '+, -, /, *, %'");
            //string amal = Console.ReadLine();
            //string result = amal switch
            //{
            //    "+" => $"{firstNum} + {secondNum} = {firstNum + secondNum}",
            //    _ => "bundayi yo'q"
            //} ;

            int counter = 0;
            while (counter < firstNum)
            {
                Console.WriteLine(counter);
                counter += 2;
            }

        }
    }
}
