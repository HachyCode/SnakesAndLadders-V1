using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    //Strategy pattern strategy, Facade pattern subsystem class
    interface ISpecialTile 
    {
        //property for defining if some one stand on it
        int StandingOnTile();

        //if some one stand on the StandingOnTile then GoToTile are used to send them to it.
        int GoToTile(); 
    }
}
