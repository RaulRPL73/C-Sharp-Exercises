using System;
using System.Collections.Generic;

//This code is to simulate a scneario of a tennis game
class Program
{
    public static void Main(string[] args)
    {
        int player1 = 0, player2 = 1;
        List<string> turns = new List<string>();
        game(player1, player2, turns);
    }

    //Shows how is the game playing out, who's winning
    public static void game(int p1, int p2, List<string> turns)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++) // Turns past
        {
            //Creates a random scenario
            int randomPlayer = random.Next(0, 2);

            if (randomPlayer == p1)
                turns.Add("p1");
            else
                turns.Add("p2");
        }

        winner(turns);
    }

    //Shows you who's the winner
   public static void winner(List<string> turns)
    {
        int pointP1 = 0, pointP2 = 0;
        bool deuce = false;
        string advantage = "";

        foreach (string value in turns)
        {
            // Before getting into deduce or advantage it has to have a score
            if ((pointP1 == 40 && pointP2 < 40 && value == "p1") ||
                (pointP2 == 40 && pointP1 < 40 && value == "p2"))
            {
                Console.WriteLine($"Player {(value == "p1" ? "1" : "2")} wins the game!");
                break;
            }

            //If there's no tie
            if (!deuce)
            {
                if (value == "p1")
                    pointP1 = (pointP1 == 30) ? 40 : pointP1 + 15;
                else
                    pointP2 = (pointP2 == 30) ? 40 : pointP2 + 15;

                Console.WriteLine($"{(pointP1 == 0 ? "Love" : pointP1)} - {(pointP2 == 0 ? "Love" : pointP2)}");

                if (pointP1 == 40 && pointP2 == 40)
                {
                    deuce = true;
                    Console.WriteLine("Deuce");
                }
            }

            else
            {
                if (advantage == "")
                {
                    advantage = value;
                    Console.WriteLine($"Advantage {advantage.ToUpper()}");
                }
                else if (advantage == value)
                {
                    Console.WriteLine($"{advantage.ToUpper()} wins the game!");
                    break;
                }
                else
                {
                    advantage = "";
                    Console.WriteLine("Deuce");
                }
            }
        }
    }
}
