using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()]
    class ObstacleTile : Tile
    {
        public ObstacleTile(int X, int Y, string CharacterSymbol = "X") : base(X, Y, CharacterSymbol)
        {

        }
    }
}
