using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()]
    class Weapon : Item
    {
        protected int itemDurability;
        protected int itemCost;
        protected int itemDamage;
        protected int itemRange;
        protected string heroWeapon;
        protected string currentWeapon;
        protected WeaponType selectedWeaponType;

        public Weapon(int X = 1, int Y = 1, string CharacterSymbol, int currentWeapontype) : base( X, Y, "I", currentWeapontype)
        {
        
        }

        public enum WeaponType
        {
            Dagger,
            Longsword,
            Longbow,
            Rifle,
        }

        public WeaponType currentWeaponType
        {
            get { return currentWeaponType; }
            set { currentWeaponType = value; }
        }

        public int damage
        {
            get { return itemDamage; }
            set { itemDamage = value; }
        }

        public int durability
        {
            get { return itemDurability; }
            set { itemDurability = value; }
        }

        public int range
        {
            get { return itemRange; }
            set { itemRange = value; }
        }

        public int cost
        {
            get { return itemCost; }
            set { itemCost = value; }
        }

        public string HeroWeapon
        {
            get { return heroWeapon; }
            set { heroWeapon = value; }
        }
    }
}

