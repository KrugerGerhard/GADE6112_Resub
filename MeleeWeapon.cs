using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()]
    class MeleeWeapon : Weapon
    {
        public enum MeleeWeapons // enum generated for Melee weapon types
        {
            Dagger,
            Longsword,
        }

        public MeleeWeapon(WeaponType currentWeaponType, int X = 1, int Y = 1, string CharacterSymbol = "I") : base (X, Y, CharacterSymbol )
        {
            if (currentWeaponType == WeaponType.Dagger)
            {
                base.currentWeaponType = WeaponType.Dagger;
                base.range = 1;
                currentWeapon = "Dagger";
                itemDamage = 3;
                itemDurability = 10;
                itemCost = 3;
                
            }
            else if (currentWeaponType == WeaponType.Longsword)
            {
                base.currentWeaponType = WeaponType.Longsword;
                base.range = 1;
                currentWeapon = "Longsword";
                itemDamage = 4;
                itemDurability = 6;
                itemCost = 5;
                
            }

            WeaponType = currentWeaponType;
        }

        public WeaponType WeaponType;

    }
}
