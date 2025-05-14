using System;
class Program
{
    public static void Main(string[] args)
    {
        //x,y,x,y,.......,x,y, that's how the robot moves
        int[] cordinates = {1,-5,6,2,2};
        int[] place = location(cordinates);
        Console.WriteLine("The robot ended on the location x="+place[0]+" y="+place[1]);
    }

    public static int [] location(int [] location)
    {
        int x=0, y=0, index=0;
        foreach(int value in location)
        {
            if(index%2==0)
            {
                x=value+x;
            }
            else
            {
                y=value+y;
            }
            index++;
        }
        return new int[] {x,y};
    }  
}