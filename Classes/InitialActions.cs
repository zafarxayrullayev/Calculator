using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Classes_k
{
    public class InitialActions
    {
        public void PositiveOrNegative(decimal num)
        {
            string messageAboutPositibeOrNegative = num > 0
                ? "musbat"
                : "manfiy";
            Console.WriteLine($"{num} {messageAboutPositibeOrNegative} son");
        }

        public void WhichOnIsBigger(decimal firstNum, decimal secondNum)
        {
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

        public void SelectAction(string action, decimal firstNum, decimal secondNum)
        {
            
            switch (action)
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
        }

        public void ShowTable()
        {
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
