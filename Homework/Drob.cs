using System;

namespace Homework
{
    public class Drob
    {
        public Drob(int first, int second, int celoe)
        {
            First = first;
            Second = second;
            Celoe = celoe;
        }
        public int First { get; set; }
        public int Second { get; set; }
        public int Celoe { get; set; }

        public double DesyatDrob()
        {
            if (Celoe >= 1)
            {
                First += Celoe * Second;
            } 
            
            double result = First / Second; 
            
            return result;
        }


        public static Drob Sum(Drob first, Drob second)
        {
            Drob result = new Drob(0, 0, 0);

            int denominator = first.Second * second.Second;
            first.First *= second.Second;
            second.First *= first.Second;
            int numerator = first.First + second.First;
            int whole = first.Celoe + second.Celoe;

            first.Second = denominator;
            second.Second = denominator;

            result.First = numerator;
            result.Second = denominator;
            result.Celoe = whole;
            int choice = 0;

            if (numerator > denominator)
            {
                if (numerator % denominator == 0)
                {
                    result.Celoe += numerator / denominator;
                    result.First = 0;
                    choice = 1;
                }
                else
                {
                    result.First = numerator % denominator;
                    result.Celoe += (numerator - result.First) / denominator ;
                    choice = 2; 
                }
            } else if (numerator == denominator)
            {
                result.Celoe += 1;
                result.First = 0;
                choice = 1;
            }

            if (choice == 1)
            {
                Console.WriteLine(result.Celoe);
            }
            else
            {
                Console.WriteLine(
                    result.Celoe + " " + result.First + "/" + result.Second
                );
            }  
            
            return result;
        }
    }
}