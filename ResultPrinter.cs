using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class ResultPrinter
    {
        public void print(double result)
        {
            Console.WriteLine($"Result: {Convert.ToString(result)}");
        }
    }
}
