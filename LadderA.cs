using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadders_V1
{
    class LadderA : ISpecialTile
    {
        public int StandingOnTile() { return 11; }
        public int GoToTile() { return 2; }
    }
}
