using System.Threading;

namespace Homework
{
    public class Price
    {
        public Price(double first, uint second)
        {
            First = first;
            Second = second;
        }
        
        public double First { get; set; }
        public uint Second { get; set; }

        public double Cost()
        {
            double result = First * Second;
            return result;
        }
    
    }
}