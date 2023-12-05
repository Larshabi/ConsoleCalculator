using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string restart = "Y";
            Operation startOperation = new Operation();
            startOperation.StartOperation(restart);
        }
    }
}
