using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission // I was unable to impliment the Shop in Game
{
    [System.Serializable()]
    class Shop
    {
        private Weapon[] weapons = new Weapon[3];
        private Random random = new Random();
        private Character player;

        public Shop(Character player)
        {
            this.player = player;
        }
        
    }
}
