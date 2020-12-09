using System.Drawing;

namespace ShootingStar
{
    public interface IGameLoop<T>
    {
        void Init(T init);
        void Update();
        void Draw(Graphics graphics);
    }
}
