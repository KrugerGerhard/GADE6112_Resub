using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gerhard_Kruger_19342313_GADE_Resubmission.Character;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    class Mage : Enemy
    {
        EnumMovement MageMovement; //Movement enum adapted for Mage movement.

        public Mage(int X, int Y, int mageDamage = 5 , int mageHP = 5, int mageMaxHP = 5, string CharacterSymbol = "M") : base (X, Y, 5, 5, 5, "M") //integers and symbol for Mage stats character symbol
        {
            instanceDamage = mageDamage; // damage = 5
            instanceHP = mageHP; // hp = 5
            instanceMaxHP = mageMaxHP; //maxhp = 5

        }

        public override bool CheckRange(Character Target) // checks wether attackable entity is within range.
        {
            if (DistanceTo(Target) == 1)
            {
                return true; //target is within range.
            }
            else
            {
                return false; //target is not within range.
            }
        }

        public override EnumMovement ReturnMove(EnumMovement CharacterMovement = 0) //return method for Movement.
        {
            return EnumMovement.NoMovement;
        }
    }
}
