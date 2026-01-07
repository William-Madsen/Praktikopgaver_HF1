using System;

namespace The_same
{
    class Result_the_same
    {
        static void Main3(string[] args)
        {
            int a = tal1(2,2);
            int b = tal2(2,2);

            if (a == b)
            {
                Console.WriteLine("there are the same");
            }
            else 
            {
                Console.WriteLine("there difference");
            }
                    
        }

        static int tal1(int a, int b)
        {
            return a + b;
        }
        static int tal2(int a, int b)
        {
            return a * b;
        }
        
    }
}