using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    //Facade pattern subsystem class
    class Dice 
    {
        //instantiates a randon 
        private static Random randomNumberGenerator = new Random();

        //veriable, stores the dice number, changes each time
        public static int diceNumber;

        // sets rundom number bettween 1 and 6, like a dice. 
        public static void RandomNumber()
        {
            diceNumber = randomNumberGenerator.Next(1, 6); 
        }
    }
}
