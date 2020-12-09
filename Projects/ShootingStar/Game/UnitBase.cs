using System;
using System.Drawing;

namespace ShootingStar.Game
{
    public class UnitBase : IGameLoop<UnitBase>
    {
        public int Speed;
        public int Hp;
        public int MaxHp;
        public Point Position;
        public int Direction;
        public int FireRate;
        public int Tick;
        public Image UnitImage;
        public bool IsAlive = true;

        protected readonly GameForm Main;
        protected int ControlWidth;
        protected int ControlHeight;
        protected Random UnitRandom = new Random();

        public UnitBase(GameForm main)
        {
            Main = main;
            ControlWidth = main.ClientSize.Width;
            ControlHeight = main.ClientSize.Height;
        }

        public virtual void Init(UnitBase init)
        {
            Speed = init.Speed;
            Hp = init.Hp;
            MaxHp = init.MaxHp;
            UnitImage = init.UnitImage;
            FireRate = init.FireRate;
        }

        public virtual void Update()
        {
            Tick++;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(
                UnitImage,
                Position.X - (UnitImage.Width / 2), Position.Y - (UnitImage.Height / 2),
                UnitImage.Width, UnitImage.Height);
        }

        public void Reset()
        {
            Hp = MaxHp;
        }
    }
}
