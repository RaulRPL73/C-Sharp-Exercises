class Program
{
    public static void Main(string[] args)
    {
        int[] waterDrop = {4,0,3,6,1,3};
        if(positives(waterDrop))
        {
            string [,] bulding = drop(waterDrop);
            print(bulding);
        }
    }

    //Prints the matrix
    public static void print(string [,] bulding)
    {
        int rows = bulding.GetLength(0);
        int cols = bulding.GetLength(1);

        for (int row=0;row<rows;row++)
        {
            for (int col=0;col<cols;col++)
            {
                Console.Write(bulding[row,col]);
            }
            Console.WriteLine();
        }
    }
    
    //Creates the walls the protects the bulding where the water can't reach and where it can
    public static string[,] drop(int[] waterDrop)
    {
        int maxHeight = 0;
        string water = "💧", wall = "⏹";
        foreach(int value in waterDrop)
        {
            if(value>maxHeight)
            {
                maxHeight=value;
            }
        }

        string[,] bulding = new string[maxHeight, waterDrop.Length];

        for (int i=0;i<waterDrop.Length;i++)
        {
            for (int j=0;j<maxHeight;j++)
            {
                if ((maxHeight-j)<=waterDrop[i])
                {
                    bulding[j,i] = wall;
                }
                else
                {
                    bulding[j,i] = " ";
                }
            }
        }

        for (int row = 0; row < maxHeight; row++)
        {
            for (int col = 0; col < waterDrop.Length; col++)
            {
                if (bulding[row, col] == " ")
                {
                    bulding[row, col] = water;
                }
            }
        }

        return bulding;
    }

    //Verifies there's no negative in the drops of water
    public static bool positives(int[] water)
    {
        foreach (int value in water)
        {
            if (value < 0)
            {
                return false;
            }
        }
    return true;
    }
}