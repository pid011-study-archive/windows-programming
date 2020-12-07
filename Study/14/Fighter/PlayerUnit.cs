using System;

namespace Fighter
{
    public class PlayerUnit : UnitBase
    {
        public PlayerUnit(MainGame main) : base(main)
        {
        }

        public override void Update()
        {
            base.Update();
            if (Direction < 0)
            {
                XPos = Math.Max(UnitImage.Width / 2, XPos - Speed);
            }
            if (Direction > 0)
            {
                XPos = Math.Min(ControlWidth - (UnitImage.Width / 2), XPos + Speed);

            }
        }

        public void SetInitialPosition()
        {
            XPos = ControlWidth / 2;
            YPos = ControlHeight - (UnitImage.Height / 2);
        }

        public void SetDirection(int direction)
        {
            Direction = direction;
        }
    }
}
