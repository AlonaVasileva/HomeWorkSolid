using HomeWorkSolid.Classes;
using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        var gameSettings = new GameSettings(1, 100, 10);
        var numberGenerator = new RandomNumberGenerator();
        var gameLogic = new GameLogic(numberGenerator, gameSettings);

        while (true)
        {
            Console.Write("Enter your guess: ");
            if (int.TryParse(Console.ReadLine(), out int guess) && gameLogic.TryGuessNumber(guess, out string message))
            {
                Console.WriteLine(message);
                break;
            }
            else 
            {
                Console.WriteLine(message);
            }
        }
    }
}