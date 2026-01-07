using System;

namespace Add_Numbers
{
    class Numbers
    {
        static void Num(string[] args)
        {
            // Skiver Resultatet af rengestykke
            Console.WriteLine("Hej, der!");
            int result = AddAndMultiply(2, 4, 5);
            Console.WriteLine($"Resultatet er: {result}");
        }

        // renger ud hvad talet giver
        static int AddAndMultiply(int a, int b, int c)
        {
            int sum = a + b; //renger de 2 første tal ud
            int Number = sum * c;  // tag hvad de 2 første giver og ganger med det tredje tal
            return Number;
        }
    }
}