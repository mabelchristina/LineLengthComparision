using System;

namespace LineLengthComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double length1 = new Line().Length(4, 4, 4, 4);
            double length2 = new Line().Length(4, 4, 4, 4);
            switch (length1.CompareTo(length2))
            {
                case 0:
                    Console.WriteLine("Lengths are equal");
                    break;
                case 1:
                    Console.WriteLine("Line 1 is greater");
                    break;
                default:
                    Console.WriteLine("Line 2 is greater");
                    break;
            }
        }
    }
}

