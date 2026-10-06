using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    internal class Basic
    {
        public double subtraction(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double percent(double num1, float num2)
        {
            return (num1 * num2 / 100);
        }
        public double depercent(double num1, float num2)
        {
            return (num1 * num2 / 100);
        }
        public double multi(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double division(double num1, double num2)
        {
            return (num1 / num2);
        }
        public double division_remain(double num1, double num2)
        {
            return (num1 % num2);
        }
        public double division_exact(double num1, double num2)
        {
            int result = (int)(num1 / num2);
            return result;
        }
        public int factorial(int num1)
        {
            int result = 1;
            for (int i = 1; i <= num1; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}