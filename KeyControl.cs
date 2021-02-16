using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class KeyControl
    {
        public static void Run()
        {
            while (Game.turn == Turn.Player)
            {
                KeyPresses();
            }
        }

        public static void KeyPresses() 
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.D)
                {
                    Game.DiceThrow();
                }

                else
                {
                    Console.WriteLine("wronge key");
                }
            }
        }
    }
}
