using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class KeyControl //Facade pattern subsystem class
    {
        public static void Run()
        {
            while (Game.turn == Turn.Player)//if it player turn runs KeyPresses method
            {
                KeyPresses();
            }
        }

        private static void KeyPresses() 
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.D) //if D key is pressed runs the diceThrow method.
                {
                    Game.DiceThrow();//randomises the dice.s
                }

                else
                {
                    Console.WriteLine("wronge key");//if any other key is pressed it displayes message "wronge key".
                }
            }
        }
    }
}
