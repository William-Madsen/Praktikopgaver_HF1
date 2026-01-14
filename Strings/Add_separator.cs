namespace Add_separator;

class Addseparator
{
    static void Main(string[] args)
    {
        // får userne til at enter et ord
        Console.WriteLine("enter a word");
        string input_string = Console.ReadLine();
        
        //får useren til fx at sige - eller ^ som skal være imellem
        Console.WriteLine("Hvad skal der være i mellem, fx - eller ^ ");
        string input_mellem = Console.ReadLine();

        // laver mellemrum og sætter usernes input imellem
        char[]chars = input_string.ToCharArray();
        string result = "";
        foreach (char c in chars)
        {
            result += c;
            result += input_mellem ;
        }
        Console.WriteLine(result); //retruner den til userne
    }
}