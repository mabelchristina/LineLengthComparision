using System;

namespace LineLengthComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = new Line().Length(4, 2, 4, 2);
            Console.WriteLine("Length of the line is:" + length);
            Console.ReadLine();
        }
    }
}