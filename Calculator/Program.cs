using Classes;
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


            Calculatorr calculate = new Calculatorr(); // create object
            calculate.EnterTwoNumbers(); // method
            calculate.WhichOnIsBigger(); // method
            Console.Write("2 ta son ustida amallar, '+, -, /, *, %' : ");
            string operation = Console.ReadLine(); // enter operation;
            calculate.SelectOperation(operation);
            calculate.ShowMultiplicationTable();

            //// karra jadval
            //actions.ShowTable();




        }
    }
}
