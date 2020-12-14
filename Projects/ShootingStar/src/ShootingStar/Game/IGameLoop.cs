using System.Drawing;

namespace ShootingStar.Game
{
    public interface IGameLoop
    {
        void Update();
        void Draw(Graphics graphics);
    }
}
