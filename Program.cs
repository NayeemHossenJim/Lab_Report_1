using System;

namespace Lab_Report_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 4, c = 4;
            Console.WriteLine("Enter the length of side 1 : " + a);
            Console.WriteLine("Enter the length of side 2 : " + b);
            Console.WriteLine("Enter the length of side 3 : " + c);
            string Triangle = (a == b && b == c) ? "Triangle Classification : Equilateral Triangle" :
                (a == b || b == c) ? "Triangle Classification : Isoscles Triangle" : 
                (a!=b && b!=c && a!=c) ? "Triangle Classification : Scalene Triangle" : " ";
            Console.WriteLine();
            Console.WriteLine(Triangle);
            Console.Read();
        }
    }
}
