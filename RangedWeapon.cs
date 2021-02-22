using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    class RangedWeapon : Weapon
    {
        public enum RangedWeapons
        {
            Longbow,
            Weapon,
        }

        public RangedWeapon(int X, int Y, int CharacterSymbol, WeaponType currentWeaponType) : base (X, Y, "I", currentWeaponType)
        {
            if (currentWeaponType == WeaponType.Longbow)
            {
                base.currentWeaponType = WeaponType.Longbow;
                base.itemRange = 2;
                currentWeapon = "Longbow";
                itemDamage = 4;
                itemDurability = 4;
                itemCost = 6;

            }

            else if (currentWeaponType == WeaponType.Rifle)
            {
                base.currentWeaponType = WeaponType.Rifle;
                base.itemRange = 3;
                currentWeapon = "Rifle";
                itemDamage = 5;
                itemDurability = 3;
                itemCost = 7;

            }

            selectedWeaponType = currentWeaponType;
        }

        public WeaponType selectedWeaponType;
        
    }
}
