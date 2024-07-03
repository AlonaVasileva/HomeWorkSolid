namespace HomeWorkSolid.Interfaces;

public interface IGameLogic
{
    bool TryGuessNumber(int guessNumber, out string message);
}