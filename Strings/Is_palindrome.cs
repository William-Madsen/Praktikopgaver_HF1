namespace IS_Palindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skive et ord");
        string input = Console.ReadLine();
        
        Console.WriteLine(new string(input.Reverse().ToArray()).Equals(input));
    }
}