using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    //Facade pattern subsystem class.
    class Computer 
    {
        public static int ComputerPlace
        {
            get { return computerPlace; }
            set { computerPlace = value; }
        }

        private static int computerPlace;

        //adds dice number to existing computer place.
        public static void ComputerGo(int amount) 
        {
            computerPlace = computerPlace + amount;
        }

        //sets computer place to go to tile if its ot special tile.
        public static void ComputerJump(int amount) 
        {
            computerPlace = amount;
        }
    }
}
