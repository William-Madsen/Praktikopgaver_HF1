namespace Absolute_value;

public class Divisible
{
    static void Main (String[] args)
    {
        DivisibleDivisor(15, 30);

    }

    static void DivisibleDivisor(int num1, int num2)
    {
        if (num1 % 2 == 0 && num1 % 3 == 0)
        {
            Console.WriteLine("num1 are divisible by 2 or 3");
        }
        else if (num2 % 2 == 0 && num2 % 3 == 0)
        {
            Console.WriteLine("num2 are divisible by 2 or 3");
        }
        else
        {
            int sum = num1 + num2;
            Console.WriteLine($"there cant be divisible by 2 or 3 and the sum is {sum}");
        }
    }
    


}
