using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class PathInfo //Strategy pattern context, Facade pattern subsystem class
    {
        public static int LastTile() { return 40; } //set the size on the path

        private ISpecialTile specialTile; 

        public void SpecialTile() //cheacks the turn and then if it on one of the specilatile it displaye the till type and where it got to.
        {
            if (Player.PlayerPlace == specialTile.StandingOnTile())
            {
                Player.PlayerJump(specialTile.GoToTile());

                if(specialTile.StandingOnTile() < specialTile.GoToTile())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Snake " + Player.PlayerPlace);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ladder " + Player.PlayerPlace);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (Computer.ComputerPlace == specialTile.StandingOnTile())
            {
                Computer.ComputerJump(specialTile.GoToTile());

                if (specialTile.StandingOnTile() < specialTile.GoToTile())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Snake " + Computer.ComputerPlace);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ladder  " + Computer.ComputerPlace);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void SetSpecialTile(ISpecialTile st)
        {
            specialTile = st;
        }
    }
}
