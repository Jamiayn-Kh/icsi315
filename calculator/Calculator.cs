using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator : CalculatorBase, ICalculator
    {
        public double Add(double a, double b)
        {
            Result = a + b;
            return Result;
        }

        public double Subtract(double a, double b)
        {
            Result = a - b;
            return Result;
        }
    }

}
