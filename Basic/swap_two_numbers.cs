namespace Swap_numbers
{
    class Swap_numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int temp = tal1; 
            tal1 = tal2;
            tal2 = temp;

            Console.WriteLine($"Efter byt: første = {tal1}, andet = {tal2}");
        }
    }
}