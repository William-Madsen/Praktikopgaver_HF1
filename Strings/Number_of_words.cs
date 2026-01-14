namespace Number_of_words;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skive et ord");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');
        Console.WriteLine(words.Length);
    }
}