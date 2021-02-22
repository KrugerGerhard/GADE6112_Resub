using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    
    [System.Serializable()] //For Save/Load feature
    
    class Goblin : Enemy
    {
        EnumMovement GoblinMovement;

        public Goblin(int X, int Y, int goblinDamage = 1, int goblinHP = 10, int goblinMaxHP = 10, string CharacterSymbol = "G") : base(X, Y, 1, 10, 10, "G")
        {
            instanceDamage = goblinDamage;
            instanceHP = goblinHP;
            instanceMaxHP = goblinMaxHP;
        }

        public override EnumMovement ReturnMove(EnumMovement move = EnumMovement.NoMovement)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 5);

            if (random == 1)
            {
                GoblinMovement = EnumMovement.Up;
            }

            if (random == 2)
            {
                GoblinMovement = EnumMovement.Down;
            }

            if (random == 3)
            {
                GoblinMovement = EnumMovement.Right;
            }

            if (random == 4)
            {
                GoblinMovement = EnumMovement.Left;
            }

            if (random == 5)
            {
                GoblinMovement = EnumMovement.NoMovement;
            }

            return GoblinMovement;
        }
    }
}
