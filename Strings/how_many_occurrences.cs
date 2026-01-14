namespace How_many_occurrences;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skive et ord");
        string input = Console.ReadLine();
        
        Console.WriteLine("Skive et ord du vil match med");
        string input2 = Console.ReadLine();
        
        string matcher = input2;
        
        string[] words = input.Split(" ");
        int cont = 0;
        foreach (string word in words)
        {
            if (word == matcher) cont++;
        }
        Console.WriteLine(cont);
    }
}