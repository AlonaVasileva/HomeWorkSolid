using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkSolid.Interfaces;

namespace HomeWorkSolid.Classes
{
    public class GameSettings : IGameSettings
    {
       public  int MinNumber { get; set; }
       public int MaxNumber { get; set; }
       public int MaxAttempts { get; set; }
       public GameSettings(int minNumber, int maxNumber, int maxAttempts)
        {
            MinNumber = minNumber;
            MaxNumber = maxNumber;
            MaxAttempts = maxAttempts;
        }

      
    }
}
