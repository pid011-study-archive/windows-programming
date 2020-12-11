using System.Collections.Generic;
using System.Drawing;
using ShootingStar.Properties;

namespace ShootingStar.Game
{
    public class GlobalBackground : IGameLoop
    {
        public static GlobalBackground Instance { get; } = new GlobalBackground();

        private readonly List<BackgroundScroller> _backgrounds;

        private GlobalBackground()
        {
            _backgrounds = new List<BackgroundScroller>
            {
                new BackgroundScroller(Resources.background0)
                {
                    Speed = 3
                },
                new BackgroundScroller(Resources.background1)
                {
                    Speed = 4
                }
            };
        }

        public void Draw(Graphics graphics)
        {
            foreach (var background in _backgrounds)
            {
                background.Draw(graphics);
            }
        }

        public void Update()
        {
            foreach (var background in _backgrounds)
            {
                background.Update();
            }
        }
    }
}
