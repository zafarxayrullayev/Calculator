using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class InitialActions
    {
        public void PositiveOrNegative(int num)
        {
            string messageAboutPositibeOrNegative = num > 0
                ? "musbat"
                : "manfiy";
            Console.WriteLine($"{num} {messageAboutPositibeOrNegative} son");
        }
    }
}
