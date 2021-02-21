using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class Player //Facade pattern subsystem class
    {
        public static int PlayerPlace
        {
            get { return playerPlace; }
            set { playerPlace = value; }
        }

        private static int playerPlace;

        public static void PlayerGo(int amount) //adds dice number to existing player place.
        {
            playerPlace = playerPlace + amount;
        }

        public static void PlayerJump(int amount) //sets computer place to go to tile if its ot special tile.
        {
            playerPlace = amount;
        }
    }
}
