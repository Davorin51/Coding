using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Triangle equal = new Triangle(3);

            Console.WriteLine(equal.A);
            Console.WriteLine(equal.B);
            Console.WriteLine(equal.C);


        }
    }
}
