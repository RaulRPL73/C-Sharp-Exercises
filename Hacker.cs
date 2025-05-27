//This program was made to convert any letters into numbers where they look almost the same, ex: E=3
class Program
{
    public static void Main(string[] args)
    {
        string word = "Letter";
        string wordSent = word.ToLower();
        string result = string.Join("", numbers(wordSent));
        Console.WriteLine("The word has turned into: "+result);
    }

    public static string[] numbers(string word)
    {
        //Contains each representative word into number
        Dictionary<string, string> numbers = new Dictionary<string, string>
        {
            {"a", "4"},
            {"b", "8"},
            {"c", "("},
            {"e", "3"},
            {"g", "6"},
            {"h", "#"},
            {"i", "1"},
            {"l", "1"},
            {"o", "0"},
            {"s", "5"},
            {"t", "7"},
            {"z", "2"}
        };

        //Makes a array from the size of the word we are using
        string[] result = new string[word.Length];
        char[] wordChanged = word.ToCharArray();

        int index = 0;
        foreach (char value in wordChanged)
        {
            if (numbers.ContainsKey(value.ToString()))
            {
                result[index] = numbers[value.ToString()];
            }
            else
            {
                result[index] = value.ToString();
            }
            index++;
        }
        return result;
    }
}