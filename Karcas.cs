//This code is made for the encryption and descryption in karcas encryption
using System;

class Program
{
    public static void Main(string[] args)
    {
        string word = "Apple";
        string wordEncrypt = word.ToLower();
        string encrypt = encription(wordEncrypt);
        Console.WriteLine("The word: " + encrypt + " is encrypted");
        string decypher = decription(encrypt);
        Console.WriteLine("The word: " + decypher + " is descypted");
    }


    //Decryption
    public static string decription(string word)
    {
        //Checks for the numbers to turn them into vocals
        Dictionary<string, string> karca = new Dictionary<string, string>
        {
            {"0","a"},
            {"1","e"},
            {"2","i"},
            {"3","o"},
            {"4","u"},
        };
        string decypher = "";
        for (int i = 0; i < word.Length; i++)
        {
            string temp = word[i].ToString();

            if (karca.ContainsKey(temp))
            {
                decypher += karca[temp].ToString();
            }
            else
            {
                decypher += temp;
            }
            if (word.EndsWith("aca"))
            {
                word = word.Substring(0, word.Length - 3);
            }
        }
        return decypher;
    }

    //Encryption
    public static string encription(string word)
    {
        //Checks for the vocals to turn them into numbers
        Dictionary<string, int> karca = new Dictionary<string, int>
        {
            {"a",0},
            {"e",1},
            {"i",2},
            {"o",3},
            {"u",4}
        };
        string encrypt = "";

        for (int i=0;i<word.Length;i++)
        {
            string temp = word[i].ToString();

            if (karca.ContainsKey(temp))
            {
                encrypt += karca[temp].ToString();
            }
            else
            {
                encrypt += temp;
            }

            if (i == word.Length - 1)
            {
                encrypt += "aca";
            }
        }
        return encrypt;
    }
}