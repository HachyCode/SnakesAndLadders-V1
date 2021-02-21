using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Dice //Facade pattern subsystem class
    {
        private static Random randomNumberGenerator = new Random(); //instantiates a randon 
        public static int diceNumber; //veriable, stores the dice number, changes each time

        public static void RandomNumber()
        {
            diceNumber = randomNumberGenerator.Next(1, 6); // sets rundom number bettween 1 and 6, like a dice. 
        }
    }
}
