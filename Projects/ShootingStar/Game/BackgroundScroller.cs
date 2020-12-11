using System.Drawing;

namespace ShootingStar.Game
{
    public class BackgroundScroller : IGameLoop
    {
        public int Speed
        {
            get => _background1.Speed;
            set
            {
                _background1.Speed = value;
                _background2.Speed = value;
            }
        }

        private readonly Background _background1;
        private readonly Background _background2;

        public BackgroundScroller(Image backgroundImage)
        {
            _background1 = new Background(backgroundImage, 0);
            _background2 = new Background(backgroundImage, -backgroundImage.Height);
        }

        public void Draw(Graphics graphics)
        {
            _background1.Draw(graphics);
            _background2.Draw(graphics);
        }

        public void Update()
        {
            _background1.Update();
            _background2.Update();
        }
    }
}
