using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2,1,2,3,3,4,2,4};
        bumeral(numbers);
    }

    static void bumeral(int[] numbers)
    {
        int index=0;
        foreach(int value in numbers)
        {
            if (index>0 && index<numbers.Length-1)
            {
                if(numbers[index-1]==numbers[index+1])
                {
                    Console.WriteLine("The numbers: "+numbers[index-1]+" "+value+" "+numbers[index+1]+" are bumeral");
                }
            }
            index++;
        }
    }
    
}
