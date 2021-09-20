using System;

namespace LineLengthComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double length1 = new Line().Length(4, 2, 4, 2);
            double length2 = new Line().Length(4, 4, 4, 4);
            if (length1.Equals(length2))
            {
                Console.WriteLine("Both lengths are equal");
            }
            else
            {
                Console.WriteLine("lengths are not equal");
            }
        }
    }
}
