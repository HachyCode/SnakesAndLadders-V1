using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    enum Turn
    {
        Player,
        Computer
    }
    class Game
    {
        public static Turn turn = Turn.Player;

        public static bool End = false;

        public static PathInfo path = new PathInfo();

        public Game()
        {
            do
            {
                if (turn == Turn.Player && !End)
                {
                    Console.WriteLine("Player");
                    KeyControl.Run();
                    Console.WriteLine("d " + Dice.diceNumber);
                    Player.PlayerGo(Dice.diceNumber);
                    Console.WriteLine("p " + Player.PlayerPlace);
                    SpecialTileCheak();
                    EndCheak();
                    Console.WriteLine(" ");
                }

                if (turn == Turn.Computer && !End)
                {
                    Console.WriteLine("Computer");
                    DiceThrow();
                    Console.WriteLine("d " + Dice.diceNumber);
                    Computer.ComputerGo(Dice.diceNumber);
                    Console.WriteLine("p " + Computer.ComputerPlace);
                    SpecialTileCheak();
                    EndCheak();
                    Console.WriteLine(" ");
                }
            } while (!End);
        }

        public static void DiceThrow()
        {
            Dice.RandomNumber();
            ChangeTurn();
        }

        public static void ChangeTurn()
        {
            if(turn == Turn.Player)
            {
                turn = Turn.Computer;
            }
            else if (turn == Turn.Computer)
            {
                turn = Turn.Player;
            }
        }

        public static void SpecialTileCheak()
        {
            path.SetSpecialTile(new SnakesA());
            path.SpecialTile();
            path.SetSpecialTile(new LadderA());
            path.SpecialTile();
        }

        public static void EndCheak()
        {
            if (Player.PlayerPlace >= PathInfo.LastTile())
            {
                Console.WriteLine("Winner is Player");
                End = true;
            }
            else if (Computer.ComputerPlace >= PathInfo.LastTile())
            {
                Console.WriteLine("Winner is Computer");
                End = true;
            }
        }

        public static void EndMessage()
        {
            //class message
        }
    }
}
