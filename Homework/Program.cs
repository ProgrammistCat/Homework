using System;
using Microsoft.VisualBasic;

namespace Homework
{
    class Program
    {
        static void TestException()
        {
            throw new Exception("TestMessage");
        }
        
        
        static void Main(string[] args)
        {

            // 1
            // -
            // 2
            //
            
            // Payday payday = new Payday();
            // payday.First = 2500;
            // payday.Second = 20;
            //
            // double sum = payday.Summa();
            //
            // Console.WriteLine(sum);
            
            //
            // Payday payday = new Payday(2500, 20);
            //
            // double sum = payday.Summa();
            //
            // Console.WriteLine(sum);
            //
            // PaydayStatic paydayStatic = new PaydayStatic(2500, 20);
            //
            // double sumtwo = PaydayStatic.Summa();


            Drob drobone = new Drob(5, 7, 8);
            Drob drobtwo = new Drob(8, 4, 4);
            Drob.Sum(drobone, drobtwo);
            

            // //Задача №1:
            //
            // Console.Write("1-ое число (дробное): ");
            // string text = Console.ReadLine();
            // double first = Convert.ToDouble(text);
            //
            // Console.Write("2-ое число (целое): ");
            // text = Console.ReadLine();
            // int second = Int32.Parse(text);
            //
            // double result = Power(first, second);
            // Console.WriteLine(result);



            // People people1 = new People("Test1", 2010);
            // People people2 = new People("Test2", 2005);
            //
            //
            // PeopleStatic.Name = "Test3";
            // PeopleStatic.Age = 15;
            // PeopleStatic.Display();
            //
            // PeopleStatic.Name = "Test4";
            // PeopleStatic.Age = 17;
            // PeopleStatic.Display();

            Price price = new Price(25, 5);
            double cost = price.Cost();
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