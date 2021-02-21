using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    interface ISpecialTile //Strategy pattern strategy, Facade pattern subsystem class
    {
        int StandingOnTile(); //property for defining if some one stand on it
        int GoToTile(); //if some one stand on the StandingOnTile then GoToTile are used to send them to it.
    }
}
