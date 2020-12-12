using System.Drawing;
using ShootingStar.Properties;

namespace ShootingStar.Game
{
    public class EnemyDestroyAnimation : DestroyAnimation
    {
        protected override Image[] DestroyImages { get; set; } =
        {
            Resources.image_enemy_destroy0,
            Resources.image_enemy_destroy1,
            Resources.image_enemy_destroy2,
            Resources.image_enemy_destroy3,
            Resources.image_enemy_destroy4
        };

        public EnemyDestroyAnimation(Point targetCenterPosition) : base(targetCenterPosition)
        {
        }
    }
}
