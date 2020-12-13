using System.Drawing;
using ShootingStar.Forms;

namespace ShootingStar.Game
{
    public class Background : IGameLoop
    {
        public Image BackgroundImage => _background;

        /// <summary>
        /// Scrolling speed
        /// </summary>
        public int Speed { get; set; } = 1;

        public int PositionY => _ypos;

        private readonly Image _background;

        private int _ypos = 0;
        private readonly int _height;

        public Background(Image backgroundImage, int ypos)
        {
            _background = new Bitmap(backgroundImage);
            _ypos = ypos;
            _height = _background.Height;
        }

        public void Update()
        {
            _ypos += Speed;
            if (_ypos >= MainForm.FormHeight)
            {
                _ypos -= _height * 2;
            }
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(_background, 0, _ypos);
        }
    }
}
