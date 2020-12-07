using System;
using System.Drawing;

namespace Fighter
{
    public class UnitBase
    {
        public int Speed;
        public int Hp;
        public int MaxHp;
        public int XPos;
        public int YPos;
        public int Direction;
        public int FireRate;
        public int Tick;
        public Image UnitImage;
        public bool IsAlive = true;

        protected readonly MainGame Main;
        protected int ControlWidth;
        protected int ControlHeight;
        protected Random UnitRandom = new Random();

        public UnitBase(MainGame main)
        {
            Main = main;
            ControlWidth = main.ClientSize.Width;
            ControlHeight = main.ClientSize.Height;
        }

        public virtual void CopyFrom(UnitBase value)
        {
            Speed = value.Speed;
            Hp = value.Hp;
            MaxHp = value.MaxHp;
            UnitImage = value.UnitImage;
            FireRate = value.FireRate;
        }

        public virtual void Update()
        {
            Tick++;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(UnitImage, XPos - (UnitImage.Width / 2), YPos - (UnitImage.Height / 2), UnitImage.Width, UnitImage.Height);
        }

        public void Reset()
        {
            Hp = MaxHp;
        }
    }
}
