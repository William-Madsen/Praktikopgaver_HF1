namespace third_one;

public class Third
{
    static void Main()
    {
        int IfNumberIsEven = 1248;

        if (IfNumberIsEven % 2 == 0)
        {
            Console.WriteLine($"number is even {IfNumberIsEven}");
        }
        else
        {
            Console.WriteLine($"number is not even {IfNumberIsEven}");
        }
    }
}