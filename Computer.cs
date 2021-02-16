using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Computer
    {
        public static int ComputerPlace
        {
            get { return computerPlace; }
            set { computerPlace = value; }
        }

        //veriables
        private static int computerPlace;

        public static void ComputerGo(int amount)
        {
            computerPlace = computerPlace + amount;
        }
        public static void ComputerJump(int amount)
        {
            computerPlace = amount;
        }
    }
}
