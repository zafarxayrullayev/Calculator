using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
