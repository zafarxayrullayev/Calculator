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
            
        }
    }
}
