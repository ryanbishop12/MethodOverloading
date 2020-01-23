using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(25, 46, true));
        }
        
        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static string Add(int a, int b, bool c)
        {
            int result = a + b;
            string bills = " dollar";
            if (c)
            {
                if (result > 1)
                    bills += "s";
                return result + bills;
            }
            return result.ToString();
        }
    }
}
