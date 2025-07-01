using System;
//This program was made to detect is a word can be a heterogram, isogram or a pangram
class Program
{
    public static void Main(string[] args)
    {
        string word = "Holaa";
        
        if (Heterograma(word)) { Console.WriteLine($"{word} Is a Heterogram"); }
        else { Console.WriteLine($"{word} Is not a Heterogram"); }

        if (Isograma(word)) { Console.WriteLine($"{word} Is a Isogram"); }
        else { Console.WriteLine($"{word} Is not a Isogram"); }

        if (Pangrama(word)) { Console.WriteLine($"{word} Is a Pangram"); }
        else { Console.WriteLine($"{word} Is not a Pangram"); }
    }

    //Full alphabeth
    static Dictionary<char, char> letters = new Dictionary<char, char>
    {
        { 'A','A' }, { 'B','B' },
        { 'C','C' }, { 'D','D' },
        { 'E','E' }, { 'F','F' },
        { 'G','G' }, { 'H','H' },
        { 'I','I' }, { 'J','J' },
        { 'K','K' }, { 'L','L' },
        { 'M','M' }, { 'N','N' },
        { 'O','O' }, { 'P','P' },
        { 'Q','Q' }, { 'R','R' },
        { 'S','S' }, { 'T','T' },
        { 'U','U' }, { 'V','V' },
        { 'W','W' }, { 'X','X' },
        { 'Y','Y' }, { 'Z','Z' },
    };

    public static bool Heterograma(string word)
    {
        bool isHeterogram = true;
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[j] == word[i]) { isHeterogram = false; break; }
            }
            if (!isHeterogram) break;
        }
        return isHeterogram;
    }

    public static bool Isograma(string word)
    {
        bool isIsogram = true;
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[j] == word[i]) { isIsogram = true; break; }
            }
            if (isIsogram) break;
        }
        return isIsogram;
    }

    public static bool Pangrama(string text)
    {
        bool isPangram = true;

        HashSet<char> found = new HashSet<char>();
        foreach (char c in text.ToLower())
        {
            if (letters.ContainsKey(c))
            {
                found.Add(Char.ToUpper(c));
            }
        }
        if (found.Count != 26) { isPangram = false; }
        
        return isPangram;
            
    }

}
