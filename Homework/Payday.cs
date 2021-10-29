using System;

namespace Homework
{
    public class Payday
    {
        public Payday(double first, int second)
        {
            First = first;
            Second = second;
        }

        public Payday() { }
        
        
        public double First { get; set; }
        public int Second { get; set; }
        

        private readonly int MonthsDay = 30;

        
        public double Summa()
        {
            double result = First / MonthsDay * Second;

            return result;
        }


        public static void DisplayFormuls()
        {
            Console.WriteLine("First / MonthsDay * Second");
        }
    }
    
    public class PaydayStatic
    {
        public PaydayStatic(double first, int second)
        {
            First = first;
            Second = second;
        }

        public PaydayStatic() { }
        
        
        public static double First { get; set; }
        public static int Second { get; set; }
        

        private static readonly int MonthsDay = 30;

        
        public static double Summa()
        {
            double result = First / MonthsDay * Second;

            return result;
        }


        public static void DisplayFormuls()
        {
            Console.WriteLine("First / MonthsDay * Second");
        }
    }



    class People
    {
        public People(string name, int bYear)
        {
            Name = name;
            Age = 2021 - bYear;
        }

        public string Name { get; set; }
        public int Age { get; set; }


        public void Display()
        {
            Console.WriteLine("Человек: " + Name + " (" + Age + ")");
        }
    }
    
    
    class PeopleStatic
    {
        public static string Name { get; set; }
        public static int Age { get; set; }


        public static void Display()
        {
            Console.WriteLine("Человек: " + Name + " (" + Age + ")");
        }
    }
    
    
}