using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()] //For Save/Load feature

    class EmptyTile : Tile
    {
        public EmptyTile(int X, int Y , string CharacterSymbol = ",") : base (X, Y)
        {

        }
    }
}
