using System;

namespace Elementary
{
    class Elementary_operations
    {
        static void Main2(string[] args)
        {
            int a = Add(2, 3);
            int b = Sub(2, 3);
            int c = mul(2, 5);
            int  d = div(2, 6);
            
            Console.WriteLine($"Resultatet er: add ={a} + Sub ={b} + Mul ={c} + Div ={d}");

        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int mul(int a, int b)
        {
            return a * b;
        }
        static int div(int a, int b)
        {
            return a / b;
        }
        
        
        
        
        
        
    }
}