namespace Compress_string;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Skive et ord");
        string input = Console.ReadLine();
        
        string result = "";
        char lastChar = input[0];
        int count = 0;

        foreach (char c in input)
        {
            if (lastChar != c)
            {
                result += lastChar;
                result += count;
                count = 0;
                lastChar = c;
            }
            count++;
        }
        result += lastChar;
        result += count;
        Console.WriteLine(result);
    }
}