using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    //Facade pattern subsystem class
    class KeyControl 
    {
        public static void Run()
        {
            //if it player turn runs KeyPresses method
            while (Game.turn == Turn.Player)
            {
                KeyPresses();
            }
        }

        private static void KeyPresses() 
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                //if D key is pressed runs the diceThrow method.
                if (keyPressed == ConsoleKey.D) 
                {
                    //randomises the dice.s
                    Game.DiceThrow();
                }

                else
                {
                    //if any other key is pressed it displayes message "wronge key".
                    Console.WriteLine("wronge key");
                }
            }
        }
    }
}
