using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculator
    {
        public double n;
        public double m;
        public string symbol;
        //public Calculator()
        //{
        //    this.n = n;
        //    this.m = m;
        //    this.symbol = symbol;
        //}
        public double Calculation()
        {
            double result = 0;
            this.n =n;
            this.m = m;
            this.symbol = symbol;
            Console.WriteLine("Enter first number");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbol");
            symbol = Console.ReadLine();
            Console.WriteLine("Enter second number");
            m = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                case "+":
                    result = n + m;
                    break;
                case "-":
                    result = n - m;
                    break;
                case "*":
                    result = n * m;
                    break;
                case "/":
                    result = n / m;
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
            return result;
        }
    }
}
