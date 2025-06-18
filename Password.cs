using System;

class Program
{
    public static void Main(string[] args)
    {
        int lenght = 12;
        string[] password = new string[lenght];
        generator(password);
    }

    //Generates the password
    public static void generator(string[] pass)
    {
        //Selects a random letter or number or special case to add to your password
        const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
        Random random = new Random();

        for (int i = 0; i < pass.Length; i++)
        {
            char randomChar = characters[random.Next(characters.Length)];
            pass[i] = randomChar.ToString();
        }
        Console.WriteLine("Your password is: " + string.Join("", pass));
    }
}