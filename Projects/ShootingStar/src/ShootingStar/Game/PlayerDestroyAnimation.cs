using System.Drawing;
using ShootingStar.Properties;

namespace ShootingStar.Game
{
    public class PlayerDestroyAnimation : DestroyAnimation
    {
        protected override Image[] DestroyImages { get; set; } =
        {
            Resources.image_fighter_destroy0,
            Resources.image_fighter_destroy1,
            Resources.image_fighter_destroy2,
            Resources.image_fighter_destroy3
        };

        public PlayerDestroyAnimation(Point targetCenterPosition) : base(targetCenterPosition)
        {
        }
    }
}
