﻿using ShootingStar.Forms;

namespace ShootingStar.Game
{
    public class EnemyUnit : UnitBase
    {
        public int EnemyType;

        public EnemyUnit(GameForm main) : base(main)
        {
        }

        public void SetInitialPosition(int enemyType)
        {
            var yRangeMin = 25;
            var yRangeMax = 100;
            switch (enemyType)
            {
                case 1:
                    yRangeMin = 100;
                    yRangeMax = 200;
                    break;
                case 2:
                    yRangeMin = 200;
                    yRangeMax = 300;
                    break;
                default:
                    break;
            }

            Position.Y = UnitRandom.Next(yRangeMin, yRangeMax);
            if (UnitRandom.Next(2) == 0)
            {
                Direction = 1;
                Position.X = UnitRandom.Next(-100, -50);
            }
            else
            {
                Direction = -1;
                Position.X = UnitRandom.Next(ControlWidth + 50, ControlWidth + 100);
            }
        }

        public override void Init(UnitBase init)
        {
            base.Init(init);

            EnemyType = (init is EnemyUnit enemy) ? enemy.EnemyType : -1;
        }

        public override void Update()
        {
            base.Update();
            Position.X += Direction * Speed;
            if (Direction > 0)
            {
                if (Position.X - (UnitImage.Width / 2) > ControlWidth)
                {
                    IsAlive = false;
                }
            }
            else
            {
                if (Position.X + (UnitImage.Width / 2) < 0)
                {
                    IsAlive = false;
                }
            }
        }
    }
}
