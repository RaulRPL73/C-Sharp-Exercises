using System;
//This program generates a number between 0 and 100 without using random as a method
class Program
{
    public static void Main(string[] args)
    {
        int number = 0;
        number = generator(number);
        Console.WriteLine($"The number generated is: {number}");
    }

    public static int generator(int number)
    {
        int minimum = 0, maximum = 100;
        /*This line grabs the current date and time from the system and retrieves its tick count and becuase it detects
        how many ticks can pass between now and midniight we use long to support it*/
        long ticks = DateTime.Now.Ticks;
        int n = (int)(ticks % (maximum - minimum + 1)) + minimum;
        return n;
    }
}