using System;
using Microsoft.VisualBasic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №1:
            
            Console.Write("1-ое число (дробное): ");
            string text = Console.ReadLine();
            double first = Convert.ToDouble(text);
            
            Console.Write("2-ое число (целое): ");
            text = Console.ReadLine();
            int second = Int32.Parse(text);
            
            double result = Power(first, second);
            Console.WriteLine(result);
        }

        static double Power(double first, int second)
        {
            double firstnumber = first;

            if (second > 0)
            {
                for (int i = 0; i < second - 1; i++)
                {
                    first *= firstnumber;
                }
            }
            else if (second == 0)
            {
                first = 1;
            }
            else
            {
                second = second * -1;
                    
                for (int i = 0; i < second - 1; i++)
                {
                    first *= firstnumber;
                }

                first = 1 / first;
            }

            
            double result = first;
            return result;
        }
    }
}