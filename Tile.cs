using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()] //For Save/Load feature 

    public abstract class Tile
    {
        public enum TileType //Enum regarding possible Tiles (Hero Tile, Enemy Tile etc)
        {
            Hero,
            Enemy,
            Weapon,
            Gold,
            Empty,
            Item,
            Goblin,
            Mage,
            Leader

        }

        protected int x;
        protected int y;
        protected string charactersymbol;

        public int X { get; set; }

        public int Y
        {
            get { return Y; }
            set { Y = value; }
        }

        public Tile(int Xvalue, int Yvalue, string CharacterSymbol) // X and Y Values for Tiles on game form
        {
            x = Xvalue;
            y = Yvalue;
            charactersymbol = CharacterSymbol;
        }

        protected Tile(int X, int Y) //Protected integers for the X and Y positions of Tiles 
        {
            this.x = X;
            this.y = Y;
        }

        public int DistanceTo(Character Target)
        {
            return Math.Abs(Target.X - this.X) + Math.Abs(Target.Y - this.Y);
        }
    }
}
    