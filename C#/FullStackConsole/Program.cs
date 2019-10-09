using System;
using FullStackLibrary;
using FullStackLibrary.Models;

namespace FullStackConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FullStackLibrary.FullStackLibrary fullStackLibrary = new FullStackLibrary.FullStackLibrary();
            Console.WriteLine(fullStackLibrary.GetCircleSquare(new Circle(2)));
            Console.WriteLine(fullStackLibrary.GetTriangleSquare(new Triangle(4, 3, 5)));
            Console.ReadKey();
        }
    }
}
