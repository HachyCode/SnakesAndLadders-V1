using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Computer //Facade pattern subsystem class.
    {
        public static int ComputerPlace
        {
            get { return computerPlace; }
            set { computerPlace = value; }
        }

        private static int computerPlace;

        public static void ComputerGo(int amount) //adds dice number to existing computer place.
        {
            computerPlace = computerPlace + amount;
        }
        public static void ComputerJump(int amount) //sets computer place to go to tile if its ot special tile.
        {
            computerPlace = amount;
        }
    }
}
