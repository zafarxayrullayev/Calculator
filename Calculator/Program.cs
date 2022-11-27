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
            Console.Write("2 ta son ustida amallar, '+, -, /, *, %' : " );
            string action = Console.ReadLine(); // enter action;
            actions.SelectAction(action, firstNum, secondNum);  // method
            // karra jadval
            actions.ShowTable();




        }
    }
}
