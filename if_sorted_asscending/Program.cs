namespace third_one;

public class Third
{ 
    static void Main()
    {
        int[]IfSortedAscending = [3, 7 ,10];
        
        if (IfSortedAscending[0] <  IfSortedAscending[1] && IfSortedAscending[1] <  IfSortedAscending[2])
        {
            Console.WriteLine("Den er sorted");
        }
        else
        {
            Console.WriteLine("Den er ikke sorted");
        }
    }
}