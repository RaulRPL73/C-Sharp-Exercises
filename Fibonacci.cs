using System;
using System.Collections.Generic;
// Program inspired by a previous Java implementation of Fibonacci number checking.

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Write a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = CheckPrime(number);         // Determines if number is only divisible by 1 and itself
        bool isFibonacci = CheckFibonacci(number); // Determines if number appears in the Fibonacci sequence
        bool isEven = number % 2 == 0;             // Checks if number is divisible by 2

        Console.Write($"{number} ");
        Console.Write(isPrime ? "is prime, " : "is not a prime number, ");
        Console.Write(isFibonacci ? "is Fibonacci, " : "is not a Fibonacci number, ");
        Console.WriteLine(isEven ? "and is even." : "and is odd.");
    }

    // Returns true if the number is a prime (greater than 1 and divisible only by 1 and itself)
    public static bool CheckPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    // Returns true if the number exists in the Fibonacci sequence
    public static bool CheckFibonacci(int num)
    {
        int a = 0, b = 1;
        while (a <= num)
        {
            if (a == num) return true;
            int temp = a;
            a = b;
            b = temp + b;
        }
        return false;
    }
}