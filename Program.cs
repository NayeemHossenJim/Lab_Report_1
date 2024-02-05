using System;

namespace Lab_Report_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4, c = 5;
            Console.WriteLine("Enter the length of side 1 : " + a);
            Console.WriteLine("Enter the length of side 2 : " + b);
            Console.WriteLine("Enter the length of side 3 : " + c);
            Console.WriteLine();
            if (a == b && b == c)
            {
                Console.WriteLine("Triangle Classification : Equilateral Triangle");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Triangle Classification : Isoscles Triangle");
            }
            else
            {
                Console.WriteLine("Triangle Classification : Scalene Triangle");
            }
                Console.Read();
        }
    }
}
