using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerhard_Kruger_19342313_GADE_Resubmission
{
    class Leader : Enemy
    {
        public Leader(int X, int Y, Hero Target, int LeaderHP = 20, int LeaderMaxHP = 20, int LeaderDamage = 2, string CharacterSymbol = "L") : base ( X, Y, LeaderHP, LeaderMaxHP, LeaderDamage, CharacterSymbol)
        {
            base.X = X;
            base.Y = Y;
            base.CharacterSymbol = CharacterSymbol;
            base.instanceDamage = LeaderDamage;
            base.instanceHP = LeaderHP;
            base.instanceMaxHP = LeaderMaxHP;
            base.WeaponItem = new Weapon(WeaponType.Longsword, "LS");
            leadertile = Target;

        }

        public EnumMovement RandomMove(EnumMovement newMoveTile = 0)
        {
            int RandomDirection = select.Next(0, 4);
            newMoveTile = EnumMovement.NoMovement;

            while (newMoveTile == EnumMovement.NoMovement)
            {
                if (RandomDirection == 0)
                {
                    if (Vision[0] is EmptyTile || Vision[0] is Item && !(Vision[0] is Hero))
                        if (Vision[0] is Item)
                        {
                            AddInv(Vision[0] as Item);
                        }
                    newMoveTile = EnumMovement.Left;
                    X--;
                }
                else
                {
                    RandomDirection = select.Next(0, 4);
                }

                else if (RandomDirection == 1)
                {
                    if (Vision[1] is EmptyTile || Vision[1] is Item && !(Vision[1] is Hero))
                    {
                        if (Vision[1] is Item)
                        {
                            AddInv(Vision[1] is Item);
                            RandomDirection = EnumMovement.Up;
                            X--;
                        }
                    }
                }
            }
        }

        public override EnumMovement ReturnMove(EnumMovement newTileLocation = 0 )
        {
            EnumMovement TileLocation = ChaseHero(newTileLocation);
            if (TileLocation == EnumMovement.NoMovement)
            {
                RandomMove(newTileLocation);
            }

            return newTileLocation;
        }

        public EnumMovement ChaseHero(EnumMovement leaderchase = 0)
        {
            int LeaderX;
            int LeaderY;
            LeaderX = base.x - leadertile.X;
            LeaderY = base.y - leadertile.Y;
            leaderchase = EnumMovement.NoMovement;

            if (Math.Abs(LeaderX) >= Math.Abs(LeaderY))
            {
                if (LeaderX <0 && Vision[2] is EmptyTile || Vision[2] is Item && !(Vision[2] is Hero))
                {
                    if (Vision[2] is Item)
                    {
                        AddInv(Vision[2] is Item);
                    }
                    leaderchase == EnumMovement.Up
                    base.X++;
                }

                if (LeaderX > 0 && Vision[0] is EmptyTile || Vision[0] is Item && !(Vision[0] is Hero))
                {
                    if (Vision[0] is Item)
                    {
                        AddInv(Vision[0] is Item);
                    }
                    leaderchase == EnumMovement.Right
                    base.X--;
                }

                if (Math.Abs(LeaderY) > Math.Abs(LeaderX))
                {
                    if (LeaderY < 0 && Vision[1] is EmptyTile || Vision[1] is Item && !(Vision[1] is Hero))
                    {
                        if (Vision[1] is Item) ;
                    }
                    leaderchase == EnumMovement.Up;
                    base.Y++;
                }
                if (LeaderY > 0 && Vision[3] is EmptyTile || Vision[3] is Item && !(Vision[3] is Hero))
                {
                    if (Vision[3] is Item);
                }
                leaderchase == EnumMovement.Down;
                base.Y--;
            }

            return leaderchase;
        }

        private Tile leaderTile;
        public Tile leadertile
        {
            get { return leadertile; }
            set { leadertile = value; }
        }
    }
}
