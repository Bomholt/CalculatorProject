using System;

namespace CalculatorProject
{
    public class Calculator : ICalculator
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Divide(double value1, double value2)
        {
            return value1/value2;
        }

        public double Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        public double Multiply(double value1, double value2)
        {
            throw new NotImplementedException();
        }

        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}
