using System;

namespace Homework
{
    public class Summa
    {
        public Summa(uint first, uint second)
        {
            if (
                first == 1 || 
                first == 2 || 
                first == 5 || 
                first == 10 || 
                first == 50 || 
                first == 100 || 
                first == 500 ||
                first == 1000 ||
                first == 5000
                ) 
            {
                First = first;
            }
            else
            {
                throw new Exception();
            }
            
            Second = second;
        }
        public uint First { get; set; }
        public uint Second { get; set; }

        public uint SummaMoney()
        {
            uint result = First * Second;
            return result;
        }
    }
}