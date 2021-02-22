using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gerhard_Kruger_19342313_GADE_Resubmission.Tile;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    [System.Serializable()] //For Save/Load feature
    class Map
    {
        public Tile[,] maptile;
        public Enemy[] enemies;
        public Item[] items;
        public Random rnd = new Random();
        private Hero playerhero;
        private int mapheight;
        private int mapwidth;
        public int enemycombatants;
        

        public int MapWidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        public int MapHeight
        {
            get { return mapheight; }
            set { mapheight = value; }
        }

        public int EnemyCombatants
        {
            get { return enemycombatants; }
            set { enemycombatants = value; }
        }

        public Hero PlayerHero
        {
            get { return playerhero; }
            set { playerhero = value; }
        }

        public void GenerateOB()
        {
            for ( int X = 0; X < MapWidth; X++)
            {
                for (int Y = 0; Y < MapHeight; Y++)
                {
                    if (X == 0 || Y == 0 || X == MapWidth - 1 || Y == MapHeight - 1)
                    {
                        maptile[X, Y] = new ObstacleTile(X, Y, "X");
                    }
                }
            }
                
        }

        public Map(int MinimumWidth,int MaximumWidth,int MinimumHeight,int MaximumHeight, int EnemySpawns, int ItemSpawns, int enemycombatants)
        {
            this.MapWidth = rnd.Next(MinimumWidth, MaximumWidth);
            this.MapHeight = rnd.Next(MinimumHeight, MaximumHeight);
            this.EnemyCombatants = EnemySpawns;

            items = new Item[ItemSpawns];
            maptile = new Tile[MapWidth, MapHeight];
            EnemyCombatants = new Enemy[EnemySpawns];

            FullMap();
            MapInitialize();

            Tile playerHero = Create(TileType.Hero);
            maptile[PlayerHero.X, PlayerHero.Y] = playerHero;

            for (int i = 0; i < enemyCombatants.Length; i++)
            {
                enemyCombatants[i] = (Enemy)Create(TileType.Enemy);
                maptile[enemyCombatants[i].X, enemyombatants[i].Y] = enemyCombatants[i];
            }
            
            for (int i = 0; Item.Length; i++)
            {
                int ItemLocation = rnd.Next(1, 3);

                if (ItemLocation == 1)
                {
                    items[i] = (Item)Create(TileType.Weapon);
                }
                if (ItemLocation == 2)
                {
                    items[i] = (Item)Create(TileType.Gold)
                }

                maptile[items[i].X, items[i].Y] = items[i];
            }
            MapUpdate()
        }

        private Tile Create(TileType tiletype)
        {
            int randomX = rnd.Next(0, mapwidth);
            int randomY = rnd.Next(0, mapheight);

            while (maptile[randomX, randomY] is ObstacleTile || maptile[randomX, randomY] is Character || maptile[randomX, randomY] is Item)
            {
                randomX = rnd.Next(0, mapwidth);
                randomY = rnd.Next(0, mapheight);
            }

            if (tiletype == TileType.Hero)
            {
                PlayerHero = new Hero(randomX, randomY, 100);
                return PlayerHero;
            }

            else if (tiletype == TileType.Enemy)
            {
                int enemySpawnMap = rnd.Next(1, 5);

                if (enemySpawnMap == 1)
                {
                    return new Goblin(randomX, randomY);
                }

                else if (enemySpawnMap == 2)
                {
                    return new Mage(randomX, randomY);
                }

                else if (enemySpawnMap == 3)
                {
                    return new Leader(randomX, randomY, PlayerHero);
                }

            }

            else if (tiletype == TileType.Weapon)
            {
                int WeaponSpawn = rnd.Next(1, 6);

                if (WeaponSpawn == 1)
                {
                    return new RangedWeapon(currentWeaponType.Longbow, "I", randomX, randomY);
                }
                else if (WeaponSpawn == 2)
                {
                    return new RangedWeapon(currentWeaponType.Rifle, "I", randomX, randomY);
                }
                else if (WeaponSpawn == 3)
                {
                    return new MeleeWeapon(currentWeaponType.Dagger, "I", randomY, randomY);
                }
                else if (WeaponSpawn == 4)
                {
                    return new MeleeWeapon(currentWeaponType.Longsword, "I", randomX, randomY);
                }
            }
        }

        public void MapInitialize()
        {
            for ( int X = 0; X < MapWidth; X++)
            {
                for (int Y = 0; Y <MapHeight; Y++)
                {
                    maptile[X, Y] = new EmptyTile(X, Y);
                }
            }
            GenerateOB();
        }



        public void FullMap()
        {
            for (int X = 0; X < MapWidth; X++)
            {
                for (int Y = 0; Y < MapHeight; Y++)
                {
                    maptile[X, Y] = new EmptyTile(X, Y);
                }
            }
        }

        public void MapUpdate()
        {
            MapInitialize();
            maptile[playerHero.X, playerhero.Y] = playerHero;

            foreach (Enemy SelectedEnemy in enemycombatants)
            {
                if (SelectedEnemy.IsDead() == false)
                {
                    maptile[SelectedEnemy.X, SelectedEnemy.Y] = SelectedEnemy;
                }
            }

            foreach (Item gold in item)
            {
                if (gold != null)
                {
                    maptile[gold.X, gold.Y] = gold;
                }
            }
        }

    }
}