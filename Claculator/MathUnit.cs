using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claculator
{
    public static class MathUnit
    {

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static double Mul(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            if(a == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            else
            {
                return a / b;
            }
        }


        public static double Pow(double Value, int exponent)
        {
            if (exponent < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(exponent), "Exponent cannot be negative.");
            }

            if (exponent == 0)
            {
                return 1.0; 
            }

            double result = Value;
            for (int i = 1; i < exponent; i++)
            {
                result *= Value; 
            }

            return result;
        }


        public static double Sqrt(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Square root cannot be calculated for negative numbers.");
            }

            if (number == 0)
            {
                return 0.0; 
            }

            
            double guess = 1.0;

            while (true)
            {
                double newGuess = (guess + number / guess) / 2.0;

         
                if (Math.Abs(newGuess - guess) < 0.00001) 
                {
                    return newGuess;
                }

                guess = newGuess;
            }
        }


    }
}
