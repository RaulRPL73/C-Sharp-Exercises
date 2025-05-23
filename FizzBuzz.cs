//This code was made on the logic of fizz and buzz
class Program
{
    public static void Main(string[] args)
    {
        int number = 0;
        FizzBuzz(number);
    }

    public static void FizzBuzz(int number)
    {
        for (number = 1; number <= 100; number++)
        {
            //FizzBuzz because both numbers are devided between 5 and 3 and the result is 0 
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine(number + " fizzbuzz");
            }
            //Fizz because the number devided by 3 equals 0
            else if (number % 3 == 0)
            {
                Console.WriteLine(number + " fizz");
            }
            //Buzz because the number devided by 5 equals 0
            else if (number % 5 == 0)
            {
                Console.WriteLine(number + " buzz");
            }
        }
    }
}