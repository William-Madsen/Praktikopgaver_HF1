using System;
using System.Linq;

enum Cat
{   // Hvad der er at vælge imellem
    Ones, Twos, Threes, Fours, Fives, Sixes,
    ThreeKind, FourKind, FullHouse,
    SmallStraight, LargeStraight, Yahtzee, Chance
}

class Program
{
    static Random rng = new Random();

    static void Main()
    {
        // starter spillet
        int?[] score = new int?[13];

        Console.WriteLine("Yahtzee\n");

        // køre kune 13 runder
        for (int round = 1; round <= 13; round++)
        {
            Console.WriteLine($"\n--- Runde {round}/13 ---");

            // roll dice og hold array
            int[] dice = new int[5];
            bool[] hold = new bool[5];

            // roller dice maks 3 gange
            for (int roll = 1; roll <= 3; roll++)
            {
                Roll(dice, hold);
                PrintDice(dice, hold);
                
                if (roll == 3) break;

                // hjælp til usernen for at sige hvad han kan vælge
                Console.Write("Hold (fx 135) | ENTER = ingen | s = scor: ");
                string input = (Console.ReadLine() ?? "").ToLower();
                if (input == "s") break;

                Array.Fill(hold, false);
                foreach (char c in input.Where(char.IsDigit))
                    if (c >= '1' && c <= '5')
                        hold[c - '1'] = true;
            }

            // hæjlp til at vælge hvor man kan sætte sin tal ind henne
            Console.WriteLine("\nVælg kategori:");
            for (int i = 0; i < 13; i++)
                if (score[i] == null)
                    Console.WriteLine($"[{i}] {(Cat)i,-14} → {Score((Cat)i, dice)}");

            int choice = ReadChoice(score);
            score[choice] = Score((Cat)choice, dice);

            Console.WriteLine($"✓ {(Cat)choice} = {score[choice]} point");
        }

        // giver en sum og slutter spillet
        int upper = score.Take(6).Sum(x => x ?? 0);
        int bonus = upper >= 63 ? 50 : 0;

        Console.WriteLine("\n--- Slut ---");
        Console.WriteLine($"Upper: {upper}  Bonus: {bonus}");
        Console.WriteLine($"TOTAL: {score.Sum(x => x ?? 0) + bonus}");
    }

    // ---- hjælp til spillern ----

    static void Roll(int[] d, bool[] hold)
    {
        for (int i = 0; i < 5; i++)
            if (!hold[i]) d[i] = rng.Next(1, 7);
    }

    static void PrintDice(int[] d, bool[] h)
    {
        for (int i = 0; i < 5; i++)
            Console.Write($"[{i + 1}:{d[i]}{(h[i] ? "*" : "")}] ");
        Console.WriteLine();
    }

    static int ReadChoice(int?[] s)
    {
        while (true)
        {
            Console.Write("Dit valg: ");
            if (int.TryParse(Console.ReadLine(), out int x) &&
                x >= 0 && x < 13 && s[x] == null)
                return x;
            Console.WriteLine("Ugyldigt valg.");
        }
    }

    static int Score(Cat cat, int[] d)
    {
        int[] c = new int[7];
        int sum = d.Sum();
        foreach (int v in d) c[v]++;

        bool Has(int n) => c.Any(x => x >= n);
        bool FullHouse() => c.Any(x => x == 3) && c.Any(x => x == 2);
        bool Small() => new[] { 1, 2, 3, 4 }.All(x => c[x] > 0) ||
                        new[] { 2, 3, 4, 5 }.All(x => c[x] > 0) ||
                        new[] { 3, 4, 5, 6 }.All(x => c[x] > 0);
        
        bool Large() => new[] { 1, 2, 3, 4, 5 }.All(x => c[x] == 1) ||
                        new[] { 2, 3, 4, 5, 6 }.All(x => c[x] == 1);

        return cat switch
        {
            Cat.Ones => c[1] * 1,
            Cat.Twos => c[2] * 2,
            Cat.Threes => c[3] * 3,
            Cat.Fours => c[4] * 4,
            Cat.Fives => c[5] * 5,
            Cat.Sixes => c[6] * 6,
            Cat.ThreeKind => Has(3) ? sum : 0,
            Cat.FourKind => Has(4) ? sum : 0,
            Cat.FullHouse => FullHouse() ? 25 : 0,
            Cat.SmallStraight => Small() ? 30 : 0,
            Cat.LargeStraight => Large() ? 40 : 0,
            Cat.Yahtzee => Has(5) ? 50 : 0,
            Cat.Chance => sum,
            _ => 0
        };
    }
}
