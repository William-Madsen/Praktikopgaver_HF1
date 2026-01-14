namespace Sort_characters_descending;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skive et ord");
        string input = Console.ReadLine();
        
        var letters = input
            .OrderByDescending(c => c);

        Console.WriteLine(letters.ToArray());
    }
}