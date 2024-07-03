using HomeWorkSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSolid.Classes
{
    public class GameLogic : IGameLogic
    {
        private readonly INumberGenerator _numberGenerator;
        private readonly IGameSettings _gameSettings;
        private int _targetNumber;
        private int _attemptsRemaining;

        public GameLogic(INumberGenerator numberGenerator, IGameSettings gameSettings)
        {
            _numberGenerator = numberGenerator;
            _gameSettings = gameSettings;
            _targetNumber = _numberGenerator.GenerateNumber(_gameSettings.MinNumber, _gameSettings.MaxNumber);
            _attemptsRemaining = _gameSettings.MaxAttempts;
        }

        public bool TryGuessNumber(int guess, out string message)
        {
            _attemptsRemaining--;

            if (guess == _targetNumber)
            {
                message = "Congratulations! You guessed the number.";
                return true;
            }

            if (_attemptsRemaining == 0)
            {
                message = $"Sorry, you ran out of attempts. The number was {_targetNumber}.";
                return false;
            }

            message = guess < _targetNumber ? "The number is higher." : "The number is lower.";

            return false;
        }
    }

    
}
