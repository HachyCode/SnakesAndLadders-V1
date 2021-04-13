using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    //Strategy pattern Concreat Strategy, Facade pattern subsystem class
    class SnakesA : ISpecialTile 
    {
        //property for defining if some one stand on it.
        public int StandingOnTile() { return 22; }

        //if some one stand on the StandingOnTile then GoToTile are used to send them to it.
        public int GoToTile() { return 33; } 
    }
}
