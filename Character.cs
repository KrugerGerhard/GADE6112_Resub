using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission // I was unable to get the Form Working in time
{
    
    [System.Serializable()] //For Save/Load feature.
    
    public abstract class Character : Tile
    {
        protected Tile[] vision { get; set; }
        protected Weapon weaponitem;
        protected string CharacterSymbol { get; set; } 
        protected int instancehp { get; set; } 
        protected int instancemaxhp { get; set; } 
        protected int instancedamage { get; set; } 
        protected bool ifdead { get; set; }
        

        public enum EnumMovement //Enum created for Movement, all possible moves that a Player/AI can make.
        {
            Up,
            Down,
            Left,
            Right,
            NoMovement,

        }

        public Tile[] Vision
        {
            get { return vision; }
            set { vision = value; }
        }
        public Weapon WeaponItem
        {
            get { return weaponItem; }
            set { weaponItem = value; }
        }

        public int instanceHP { get; set; }

        public int instanceMaxHP { get; set; }

        public int instanceDamage { get; set; }

        public Character(int X, int Y, int instanceHP, int instanceMaxHP, int instanceDamage, string CharacterSymbol) : base(X, Y, CharacterSymbol)
        {
            
        }

        public virtual void Attack(Character Target)
        {
            Target.instanceHP -= this.instanceDamage;
        }

        public virtual bool CheckRange(Character Target) //Checks wether there are any enemies in range (for both Player and AI).
        {
            if (DistanceTo(Target) <= 1 && DistanceTo(Target) >= -1)
            {
                return true; //Enemy/Player within range.
            }
            else
            {
                return false; //No Enemies/Player within range.
            }
        }

        public bool IsDead() //Bool for wether the player/AI has died.
        {
            if (instanceHP <= 0)
            {
                return true; //Player/AI has 0 HP and has died.
            }

            else
            {
                return false; //Player or AI has more than 0 HP and is still alive.
            }
        }

        public void Move(EnumMovement move)
        {
            if (move == EnumMovement.Up)
            {
                this.Y++;
            }

            if (move == EnumMovement.Down)
            {
                this.Y--;
            }

            if (move == EnumMovement.Left)
            {
                this.X--;
            }

            if (move == EnumMovement.Right)
            {
                this.X++;
            }
        }

        public int DistanceTo(Character Target)
        {
            return Math.Abs(Target.X - this.X) + Math.Abs(Target.Y - this.Y);
        }

        public abstract EnumMovement ReturnMove(EnumMovement move = 0);

        public abstract override string ToString();

    }
}
