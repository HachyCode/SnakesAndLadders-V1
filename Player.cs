using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Player
    {
        public static int PlayerPlace
        {
            get { return playerPlace; }
            set { playerPlace = value; }
        }

        //veriables
        private static int playerPlace;

        public static void PlayerGo(int amount)
        {
            playerPlace = playerPlace + amount;
        }

        public static void PlayerJump(int amount)
        {
            playerPlace = amount;
        }
    }
}
