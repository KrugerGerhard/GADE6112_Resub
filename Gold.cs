using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()]

    class Gold : Item
    {
        private int gold;
        private Random random = new Random();

        public Gold(int X, int Y, string CharacterSymbol = "g") : base(X, Y, CharacterSymbol)
        {
            gold = random.Next(1, 6);
        }

        public int goldrecieved
        {
            get { return gold; }
            set { gold = value; }
        }
    }
}
