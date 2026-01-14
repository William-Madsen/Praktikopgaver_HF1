namespace revert_words_order;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skive et ord");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');
        words = words.Reverse().ToArray();
        Console.WriteLine("", words);
    }
}