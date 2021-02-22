using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    class GameEngine
    {
        public enum WeaponType
        {
            Dagger,
            Longsword,
            Longbow,
            Rifle
        }

        public enum EnumMovement
        {
            Up,
            Down,
            Left,
            Right,
            NoMovement
        }

        public enum TileType
        {
            Hero,
            Enemy,
            Weapon,
            Gold,
            Empty,
            Item,
        }

        private Map displayMap = new Map(30, 40, 28, 50, 12, 20, 12);

        public Map DisplayMap
        {
            get { return displayMap; }
            set { displayMap = value; }
        }

        public void EnemyMovement()
        {
            EnumMovement heroMovement;
            displayMap.UpdatedVision();

            foreach (Enemy enemySelection in displayMap.enemycombatants)
            {
                displayMap.UpdatedVision();

                heroMovement = enemySelection.ReturnMove();
                if (enemySelection is Goblin)
                {
                    if (enemySelection.CheckRange(displayMap.PlayerHero))
                    {
                        enemySelection.Attack(displayMap.PlayerHero);
                    }
                }
                else if (enemySelection is Mage)
                {
                    if (enemySelection.CheckRange(displayMap.PlayerHero))
                    {
                        enemySelection.Attack(displayMap.PlayerHero);
                    }
                    for (int i= 0; i < displayMap.EnemyCombatants.Length; i++)
                    {
                        if (displayMap.enemycombatants[i].X != enemySelection.X && displayMap.EnemyCombatants[i].Y != enemySelection.Y)
                        {
                            if (enemySelection.CheckRange(displayMap.EnemyCombatants[i]))
                            {
                                enemySelection.Attack(displayMap.EnemyCombatants[i]);
                            }
                        }
                    }
                }

            }

            displayMap.MapUpdate();
        }

        public override string ToString()
        {
            string GameMap = "";
            for (int i = 0; i < displayMap.MapWidth; i++)
            {
                for (int j = 0; j < displayMap.MapHeight; j++)
                {
                    GameMap += displayMap.maptile[i, j] + " ";
                }
                GameMap += "\n";
            }
            return GameMap;
        }
    }

    public void EnemyAttack()
    {
        displayMap.MapUpdate();
        foreach (enemy enemySelection in map)
    }

    public bool EnumMovement(HeroMovement dir)
    {
        if (displayMap.PlayerHero.ReturnMove(dir) == EnumMovement.NoMovement)
        {
            return false;
        }

        else
        {
            Item pickUp = displayMap.
        }
    }
}
