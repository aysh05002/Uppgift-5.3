using System;

class program
{
    static void Main(string[] args)
    {
        string[] frågor = new string[4];
        int[] svar = new int[4];
        frågor[0] = "5*8";
        svar[0] = 5 * 8;
        frågor[1] = "7*4";
        svar[1] = 4 * 7;
        frågor[2] = "8*3";
        svar[2] = 8 * 3;
        frågor[3] = "6*9";
        svar[3] = 6 * 9;

        Console.WriteLine("Välj en fråga 1-4:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{frågor[x - 1]} svar:");
        int y = Convert.ToInt32(Console.ReadLine());
        if (y == svar[x - 1])
        {
            Console.WriteLine("Rätt svar");
        }
        else
        {
            Console.WriteLine($"Fel svar, svaret är {svar[x - 1]}");
        }
    }
}