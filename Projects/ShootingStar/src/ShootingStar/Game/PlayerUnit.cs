using System;
using ShootingStar.Forms;

namespace ShootingStar.Game
{
    public class PlayerUnit : UnitBase
    {
        public PlayerUnit(GameForm main) : base(main)
        {
        }

        public override void Update()
        {
            base.Update();
            if (Direction < 0)
            {
                Position.X = Math.Max(UnitImage.Width / 2, Position.X - Speed);
            }
            if (Direction > 0)
            {
                Position.X = Math.Min(ControlWidth - (UnitImage.Width / 2), Position.X + Speed);

            }
        }

        public void SetInitialPosition()
        {
            Position.X = ControlWidth / 2;
            Position.Y = ControlHeight - (UnitImage.Height / 2) - 50;
        }

        public void SetDirection(int direction)
        {
            Direction = direction;
        }
    }
}
