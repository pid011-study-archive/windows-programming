using System.Drawing;

namespace ShootingStar.Game
{
    public abstract class DestroyAnimation : IGameLoop
    {
        public int FramePosition { get; private set; }
        public int FrameCount => DestroyImages.Length;

        private Point _center;

        protected abstract Image[] DestroyImages { get; set; }

        public DestroyAnimation(Point targetCenterPosition)
        {
            FramePosition = 0;
            _center = targetCenterPosition;
        }

        public void Draw(Graphics graphics)
        {
            var image = DestroyImages[FramePosition];

            // image의 위치를 타겟의 중앙으로 맞춤
            var drawPosition = new Point
            {
                X = _center.X - (image.Width / 2),
                Y = _center.Y - (image.Height / 2)
            };

            graphics.DrawImage(DestroyImages[FramePosition], drawPosition);
        }

        public void Update()
        {
            if (FramePosition >= DestroyImages.Length)
            {
                return;
            }
            FramePosition++;
        }
    }
}
