using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()] //For Save/Load feature
    class Hero : Character
    {
        EnumMovement HeroMovement;
        public Hero(int X, int Y, int instancehp = 100, int instancemaxhp = 100, int instancedamage = 2, string CharacterSymbol = "H") : base(X, Y, 100, 100, 2, "H")
        {
            instancehp = 100;
            instancemaxhp = 100;
            instancedamage = 2;
        }

        
        public override EnumMovement ReturnMove(EnumMovement move) //method for returning hero move
        {
            if (move == EnumMovement.Up)
            {
                HeroMovement = EnumMovement.Up;
            }

            else if (move == EnumMovement.Down)
            {
                HeroMovement = EnumMovement.Down;
            }

            else if (move == EnumMovement.Left)
            {
                HeroMovement = EnumMovement.Left;
            }

            else if (move == EnumMovement.Right)
            {
                HeroMovement = EnumMovement.Right;
            }

            else if (move == EnumMovement.NoMovement)
            {
                HeroMovement = EnumMovement.NoMovement;
            }

            return HeroMovement;
        }

        public override string ToString()
        {
            return "PlayerStats" + "[{HP},/{MaxHP}]" + "Damage:[{damage}]" + "at [{X}, {Y}]";   
        }
    }
}
