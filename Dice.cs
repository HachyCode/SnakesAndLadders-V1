using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Dice
    {
        public static Random randomNumberGenerator = new Random();
        public static int diceNumber;

        public static void RandomNumber()
        {
            diceNumber = randomNumberGenerator.Next(1, 6);
        }
    }
}
