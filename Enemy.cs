using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    
    [System.Serializable] //For Save/Load feature
    
     abstract class Enemy : Character //Had fun coding the Enemy class
    {
        protected Random select = new Random();
        public Enemy(int X, int Y, int Damage, int HP, int MaxHP, string CharacterSymbol) : base (X, Y, HP, MaxHP,Damage, CharacterSymbol)
        {
            instancehp = HP;
            instancemaxhp = MaxHP;
            instancedamage = Damage;

        }

        public override string ToString()
        {
            return "EnemyClass at [{X}, {Y}] has taken [{Damage}] damage";
        }
    }
}
