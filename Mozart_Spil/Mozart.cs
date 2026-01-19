using System;
using System.Media;

class MozartValse
{
    static void Main()
    {
        
        Random rnd = new Random();

        Console.WriteLine("Vælg instrument (Piano eller Mbira):");
        string input = Console.ReadLine();

        string instrument = "Piano"; // standard
        string basePath;

        if (input == "Piano")
        {
            instrument = "Piano";
        }
        else if (input == "Mbira")
        {
            instrument = "Mbira";
        }
        else
        {
            Console.WriteLine("Ugyldigt valg, bruger Piano.");
        }

        basePath = $"/Users/williamlundmadsen/Hvoedforlob_1/Mozaar/mozar/{instrument}t";
           

        // -------- Menuet --------
        for (int frase = 0; frase < 16; frase++)
        {
            int sum = rnd.Next(1, 7) + rnd.Next(1, 7);
            string file = $"{basePath}minuet{frase}-{sum}.wav";

            PlaySound(file);
        }

        // -------- Trio --------
        for (int frase = 0; frase < 16; frase++)
        {
            int dice = rnd.Next(1, 7);
            string file = $"{basePath}trio{frase}-{dice}.wav";

            PlaySound(file);
        }

        Console.WriteLine("Vals færdig ");
    }

    static void PlaySound(string path)
    { //Vriker kun på windows (.net 8.0)
        
        SoundPlayer player = new SoundPlayer(path);
        player.PlaySync();
    }
}
