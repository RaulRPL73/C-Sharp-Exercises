using System;
//This program was made to select a house from harry potter
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This is the Sorting Hat. It will decide which house you truly belong to—just be honest with your answers!\n");
        Questions();
    }

    public static void Questions()
    {
        int answer = 0, Griffindor = 0, Slytherin = 0, Hufflepuff = 0, Ravenclaw = 0, result = 0;
        Console.WriteLine($"1. Which trait do you value most in yourself? 1.Courage 2.Determination 3.Kindness 4.Curiosity\n");
        answer = int.Parse(Console.ReadLine());
        if (answer == 1) { Griffindor++; }
        else if (answer == 2) { Slytherin++; }
        else if (answer == 3) { Hufflepuff++; }
        else if (answer == 4) { Ravenclaw++; }
        Console.WriteLine($"2. What would you do if you found a powerful magical artifact? 1.Use it to protect others 2.Keep it and study its secrets 3.Turn it in to the proper authorities 4.Research it and document everything\n");
        answer = int.Parse(Console.ReadLine());
        if (answer == 1) { Griffindor++; }
        else if (answer == 2) { Slytherin++; }
        else if (answer == 3) { Hufflepuff++; }
        else if (answer == 4) { Ravenclaw++; }
        Console.WriteLine($"3. What motivates you to succeed? 1.Doing what's right 2.Achieving greatness 3.Helping others 4.Gaining knowledge\n");
        answer = int.Parse(Console.ReadLine());
        if (answer == 1) { Griffindor++; }
        else if (answer == 2) { Slytherin++; }
        else if (answer == 3) { Hufflepuff++; }
        else if (answer == 4) { Ravenclaw++; }
        Console.WriteLine($"4. Which magical subject excites you the most? 1.Defense Against the Dark Arts 2.Potions 3.Care of Magical Creatures 4.Charms\n");
        answer = int.Parse(Console.ReadLine());
        if (answer == 1) { Griffindor++; }
        else if (answer == 2) { Slytherin++; }
        else if (answer == 3) { Hufflepuff++; }
        else if (answer == 4) { Ravenclaw++; }
        
        Decision(Griffindor, Slytherin, Hufflepuff, Ravenclaw);
    }

    public static void Decision(int G, int S, int H, int R)
    {
        Console.WriteLine("\nThe Sorting Hat is thinking...\n");
        
        int max = Math.Max(Math.Max(G, S), Math.Max(H, R));

        if (G == max)
            Console.WriteLine("🦁 You belong to GRYFFINDOR! Brave and daring!");
        else if (S == max)
            Console.WriteLine("🐍 You belong to SLYTHERIN! Ambitious and cunning!");
        else if (H == max)
            Console.WriteLine("🦡 You belong to HUFFLEPUFF! Loyal and hardworking!");
        else if (R == max)
            Console.WriteLine("🦅 You belong to RAVENCLAW! Wise and creative!");
    }
}