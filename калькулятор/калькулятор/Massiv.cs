using System.Globalization;
using System;

namespace Massiv
   
    {
        class Math
        {
            public static double Sum(double a, double b)
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
                if (b == 0)
                {
                    throw new DivideByZeroException("Division by zero!");
                }
                return a / b;
            }
            public static int IntDiv(int a, int b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Division by zero!");
                }
                return a / b;
            }
            public static double Percent(double number, double percent)
            {
                return number * percent / 100;
            }

     
            public static double DePercent(double part, double percent)
            {
                if (percent == 0)
                {
                    throw new DivideByZeroException("The percentage cannot be 0!");
                }
                return part * 100 / percent;
            }
            public static int Count(List<double> numbers)
            {
                int count = 0;
                foreach (double n in numbers)
                {
                    count++;
                }
                return count;
            }
            public static double Max(List<double> numbers)
            {
                double max = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                return max;
            }

            public static double Min(List<double> numbers)
            {
                double min = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return min;
            }

        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("The factorial of a negative number does not exist!");
            }
            if (n > 20)
            {

                throw new ArgumentException("The number is too large; an overflow will occur!");
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
          
        public double[] SortDesscending(double[] numbers)
        { 
            double[] rezult =(double[])numbers.Clone();
            Array.Sort(rezult);
            Array.Reverse(rezult);
            return rezult;
        }
    }
}
