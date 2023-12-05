using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Calculator:ICalculator
    {
        
        public double addNumbers(double num1, double num2) { return num1 + num2; }

        public double subtractNumbers(double num1, double num2) { return num1 - num2; }

        public double multiplyNumbers(double num1, double num2) { return num1 * num2; }

        public double divideNumbers(double num1, double num2) { return num1 / num2; }

        public double modulusNumbers(double num1, double num2) { return num1 % num2; }
    
}
}
