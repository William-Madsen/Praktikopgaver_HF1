using System;

namespace Modulo_operations
{
    class Modulo_op
    {
        static void Main4(string[] args)
        {
            int result = modulo (8, 5, 2);
            Console.WriteLine($"Resultatet er: {result}");
        }

        static int modulo (int a, int b, int c)
        {
            int sum = a % b; 
            int Number = sum / c;  
            return Number;
        }
    }
}