using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string word = "Hello everyone, this code is to see how much vocals does this setence has";
        string [] wordVocal = word.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(word=>word.ToLower()).ToArray();
        countVocals(wordVocal); 
    }

    public static void countVocals(string [] words)
    {
        Dictionary<char, string> vowels = new Dictionary<char, string>
        {
            {'a', "a"},
            {'e', "e"},
            {'i', "i"},
            {'o', "o"},
            {'u', "u"}
        };
        int vocalA=0, vocalE=0, vocalI=0, vocalU=0, vocalO=0;

        foreach (string value in words)
        {
            foreach (char vocal in value)
            {
                if(vowels.ContainsKey(vocal) && vowels[vocal]=="a")
                {
                    vocalA++;
                }
                
                else if(vowels.ContainsKey(vocal) && vowels[vocal]=="e")
                {
                    vocalE++;
                }

                else if(vowels.ContainsKey(vocal) && vowels[vocal]=="i")
                {
                    vocalI++;
                }

                else if(vowels.ContainsKey(vocal) && vowels[vocal]=="o")
                {
                    vocalO++;
                }

                else if(vowels.ContainsKey(vocal) && vowels[vocal]=="u")
                {
                    vocalU++;
                }
            }
        }
        Console.WriteLine("The word or sentence has this many A="+vocalA+" E="+vocalE+" I="+vocalI+" O="+vocalO+" U="+vocalU);
    }
}