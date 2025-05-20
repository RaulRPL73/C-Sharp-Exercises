using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Today;
        int day = date.Day;
        present(day);
    }

    public static void present(int date)
    {
        Dictionary<int, string> gift = new Dictionary<int, string>
        {
            { 1, "Teddy Bear" },
            { 2, "Chocolate Box" },
            { 3, "Toy Train" },
            { 4, "Lego Set" },
            { 5, "Puzzle" },
            { 6, "Remote Car" },
            { 7, "Action Figure" },
            { 8, "Board Game" },
            { 9, "Story Book" },
            { 10, "Coloring Kit" },
            { 11, "Snow Globe" },
            { 12, "Socks" },
            { 13, "Scarf" },
            { 14, "Gloves" },
            { 15, "Hot Cocoa Mug" },
            { 16, "Music Box" },
            { 17, "T-shirt" },
            { 18, "Notebook" },
            { 19, "Pen Set" },
            { 20, "Candle" },
            { 21, "Snowman Figure" },
            { 22, "Slippers" },
            { 23, "Mini Lamp" },
            { 24, "Big Gift Box!" }
        };

        if (gift.ContainsKey(date))
        {
            Console.WriteLine("On the day: " + date + " you get a : " + gift[date]);
        }

        else
        {
            Console.WriteLine("Sorry, you don't get a present");
        }
    }
}


