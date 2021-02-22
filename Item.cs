using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    public abstract class Item : Tile
    {
        public Item(int X, int Y, string CharacterSymbol = "I") : base (X, Y, CharacterSymbol)
        {

        }

    }
}
