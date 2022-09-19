using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static void Add(int num1, int num2)
        {
            Console.WriteLine (num1 + num2);
        }

        public static void Add(double num1, double num2)
        {
            Console.WriteLine (num1 + num2);
        }

        public static void Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if(isTrue)
            {
             sum = num1 + num2; 

                if(sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }

            } 

            Console.WriteLine (response);
        }
    }
}
