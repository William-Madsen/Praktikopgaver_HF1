using System;

namespace Cube_of
{
    class Cube
    {
        static void Main5(string[] args)
        {
            int result = cube (2);
            Console.WriteLine($"Resultatet er: {result}");
        }

        static int cube (int a)
        {
            double Number = Math.Pow(a, 3);  
            return (int)Number;
        }
    }
}