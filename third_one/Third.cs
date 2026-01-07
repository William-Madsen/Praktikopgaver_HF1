namespace third_one;

public class Third
{
    static void Main()
    {
        int[] tal_array = [2, 7, 12];
        int sumg = tal_array[0] * tal_array[1];
        int sump = tal_array[0] + tal_array[1];

        if (sumg > tal_array[2] || sump > tal_array[2])
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
} 
