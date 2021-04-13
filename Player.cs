using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    //Facade pattern subsystem class
    class Player 
    {
        public static int PlayerPlace
        {
            get { return playerPlace; }
            set { playerPlace = value; }
        }

        private static int playerPlace;

        //adds dice number to existing player place.
        public static void PlayerGo(int amount) 
        {
            playerPlace = playerPlace + amount;
        }

        //sets computer place to go to tile if its ot special tile.
        public static void PlayerJump(int amount) 
        {
            playerPlace = amount;
        }
    }
}
