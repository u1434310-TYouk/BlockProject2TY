namespace ConsoleApp3;

// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Security.Cryptography;
class program{
    public static void Main(String[] args)
    {
        Random rnd = new Random();
        String s = Console.ReadLine();

        int hash = s.GetHashCode();

        for (int i = 0; i < 13; i++)
        {
            if (hash % 2 == 0)
                hash -= hash / rnd.Next(Math.Abs(hash));
            else
            {
                hash -= hash / 2;
            }
        }

        Console.WriteLine(hash + s.GetHashCode());
    }
}