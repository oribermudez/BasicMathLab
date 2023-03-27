using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTestingAProgram
{
    internal class BasicMath
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            double value = a / b;

            if (double.IsInfinity(value))
            {
                throw new DivideByZeroException();
            }

            return value;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
