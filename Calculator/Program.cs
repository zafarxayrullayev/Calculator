using Classes_k;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum, secondNum;
            Console.Write("1-sonni kiriting : ");
            firstNum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("2-sonni kiriting : ");
            secondNum= Convert.ToDecimal(Console.ReadLine());

            InitialActions actions = new InitialActions(); // create object
            actions.PositiveOrNegative(firstNum); // method
            actions.WhichOnIsBigger(firstNum, secondNum);// method

            

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
            //};


            // karra jadval

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

        }
    }
}
