using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculatorr
    {
        public decimal FirstNumber  { get; set; }
        public decimal SecondNumber  { get; set; }
        public void EnterTwoNumbers()
        {
            Console.Write("1-sonni kiriting : ");
            FirstNumber= Convert.ToDecimal(Console.ReadLine());
            Console.Write("2-sonni kiriting : ");
            SecondNumber = Convert.ToDecimal(Console.ReadLine());
        }

        public void WhichOnIsBigger()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("1st number is bigger");
            }
            else if(SecondNumber == FirstNumber) 
            {
                Console.WriteLine("equal"); 
            }
            else
            {
                Console.WriteLine("2nd number is bigger");
            }
        }

        public void SelectOperation(string operation)
        {
            
            switch (operation)
            {
                case "+" :
                    Console.WriteLine($"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}");
                    break;
                case "/":
                    Console.WriteLine($"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}");
                    break;
                default:
                    break;
            }
        }

        public void ShowMultiplicationTable()
        {
            Console.Write("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} karra \n");
                for (int j = 2; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
