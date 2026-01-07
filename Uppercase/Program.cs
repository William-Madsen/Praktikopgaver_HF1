public class Uppercase_check
{
    static void Main(String[] args)
    {
        string input = "abC";
        if (input.All(char.IsUpper))
        {
            Console.WriteLine("All is uppercase");
        }
        else
        {
            Console.WriteLine("there is no uppercase");
        }
        
    }
    
}

