using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Operation
    {
        public void StartOperation(string restart)
        {
            try
            {
                do
                {

                    double num1;
                    double num2;
                    double result;
                    string arithmeticOperator;
                    string[] arithmeticOperators = new string[5] {"+", "-","/","*", "%"};




                    ResultPrinter printer = new ResultPrinter();

                    Console.WriteLine("------------------");
                    Console.WriteLine("Calculator Program");
                    Console.WriteLine("------------------");


                    Console.WriteLine("Hi, Kindly pick a mathematical operator");
                    Console.WriteLine("Enter an option: ");
                    Console.WriteLine("\t+: Add");
                    Console.WriteLine("\t-: Subtract");
                    Console.WriteLine("\t*: Multiply");
                    Console.WriteLine("\t/: Divide");
                    Console.WriteLine("\t%: Modulos");
                    Console.WriteLine("\tx: Exit");

                    arithmeticOperator = Console.ReadLine();
                    if(arithmeticOperator.ToUpper() == "X")
                    {
                        return;
                    }
                    if (!arithmeticOperators.Contains(arithmeticOperator)){ 
                        throw new Exception("Invalid Operator");
                    }
          

                    Console.Write("Please enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Calculator calc = new Calculator();

                    switch (arithmeticOperator)
                    {
                        case "+":
                            result = calc.addNumbers(num1, num2);
                            printer.print(result);
                            break;

                        case "-":
                            result = calc.subtractNumbers(num1, num2);
                            printer.print(result);
                            break;

                        case "*":
                            result = calc.multiplyNumbers(num1, num2);
                            printer.print(result);
                            break;

                        case "/":
                            result = calc.divideNumbers(num1, num2);
                            printer.print(result);
                            break;

                        case "%":
                            result = calc.modulusNumbers(num1, num2);
                            printer.print(result);
                            break;
                    }

                    Console.WriteLine("Do you want to continue? (Y/N)");
                    restart = Console.ReadLine().ToUpper();
                    if (restart == "N")
                    {
                        return;
                    }
                } while (restart == "Y");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Do you want to continue? (Y/N)");
                restart = Console.ReadLine().ToUpper();
                if (restart == "N")
                {
                    return;
                }
                StartOperation(restart);
            }
        }
    }
}
