using HomeWorkSolid.Classes;
using System;
using System.Security.Cryptography;
using HomeWorkSolid.Classes;
using HomeWorkSolid.Interfaces;
using RandomNumberGenerator = HomeWorkSolid.Classes.RandomNumberGenerator;

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
            int.TryParse(Console.ReadLine(), out int guess);
            var guessed = gameLogic.TryGuessNumber(guess, out string message);
            Console.WriteLine(message);
            if (guessed)
            {
                break;
            }
        }
    }
}