using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class LadderA : ISpecialTile //Strategy pattern Concreat Strategy, Facade pattern subsystem class
    {
        public int StandingOnTile() { return 11; } //property for defining if some one stand on it.
        public int GoToTile() { return 2; } //if some one stand on the StandingOnTile then GoToTile are used to send them to it.
    }
}
