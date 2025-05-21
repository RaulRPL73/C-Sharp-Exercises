using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string word = "Hello @user, it's good to see you, you are the number #12 in seeing this on https://github.com/RaulRPL73";
        handles(word);
    }

    public static void handles(string word)
    {
        Regex userRegex = new Regex(@"@\w+");
        Regex hashtagRegex = new Regex(@"#\w+");
        Regex webRegex = new Regex(@"(https?://[^\s]+)");

        List<string> arroba = new List<string>();
        List<string> hashtags = new List<string>();
        List<string> webs = new List<string>();

        foreach (Match match in userRegex.Matches(word))
        {
            arroba.Add(match.Value);
        }

        foreach (Match match in hashtagRegex.Matches(word))
        {
            hashtags.Add(match.Value);
        }

        foreach (Match match in webRegex.Matches(word))
        {
            webs.Add(match.Value);
        }

        Console.WriteLine("Arroba detected: " + string.Join(", ", arroba));
        Console.WriteLine("Hashtags detected: " + string.Join(", ", hashtags));
        Console.WriteLine("Web detected: " + string.Join(", ", webs));
    }
}
