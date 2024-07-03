using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkSolid.Interfaces;

namespace HomeWorkSolid.Classes
{
    public class NumGenerator :INumberGenerator
    {
        public int GenerateNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue + 1);
        }
    }
}
