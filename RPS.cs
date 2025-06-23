using System;

//This program works with rock paper and scissors but with 2 new elements, lizard and Spoc
class Program
{
    public static void Main(string[] args)
    {
        string[,] rounds = new string[3, 2]
        {
            { "🗿", "✂️" },
            { "✂️", "🗿" },
            { "📄", "✂️" }
        };
        game(rounds);
    }

    public static void game(string[,] games)
    {
        //Here's how the game playes out, how you can win against the other
        Dictionary<string, string> rounds = new Dictionary<string, string>
        {
            { "✂️📄", "Player1 wins" },
            { "📄🗿", "Player1 wins" },
            { "🗿🦎", "Player1 wins" },
            { "🦎🖖", "Player1 wins" },
            { "🖖✂️", "Player1 wins" },
            { "✂️🦎", "Player1 wins" },
            { "🦎📄", "Player1 wins" },
            { "📄🖖", "Player1 wins" },
            { "🖖🗿", "Player1 wins" },
            { "🗿✂️", "Player1 wins" },
            { "📄✂️", "Player2 wins" },
            { "🗿📄", "Player2 wins" },
            { "🦎🗿", "Player2 wins" },
            { "🖖🦎", "Player2 wins" },
            { "✂️🖖", "Player2 wins" },
            { "🦎✂️", "Player2 wins" },
            { "📄🦎", "Player2 wins" },
            { "🖖📄", "Player2 wins" },
            { "🗿🖖", "Player2 wins" },
            { "✂️🗿", "Player2 wins" },
            { "✂️✂️", "It's a tie" },
            { "📄📄", "It's a tie" },
            { "🗿🗿", "It's a tie" },
            { "🦎🦎", "It's a tie" },
            { "🖖🖖", "It's a tie" }
        };

        //Cehcks for how manu rows it has instead of how many elements there are
        int totalRounds = games.GetLength(0);

        for (int i = 0; i < totalRounds; i++)
        {
            string p1 = games[i, 0];
            string p2 = games[i, 1];
            string key = p1 + p2;

            if (rounds.ContainsKey(key))
            {
                Console.WriteLine($"{p1} vs {p2}  {rounds[key]}");
            }
            else
            {
                Console.WriteLine($"{p1} vs {p2}  There's no result for the game");
            }
        }

    }
}
