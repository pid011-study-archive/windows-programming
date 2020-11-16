using System.Drawing;

namespace Sokoban
{
    internal static class StaticSprites
    {
        public static readonly Image Empty = Image.FromFile("resources/tile_empty_01.png");
        public static readonly Image Wall = Image.FromFile("resources/tile_wall_01.png");
        public static readonly Image Goal = Image.FromFile("resources/tile_goal_01.png");
        public static readonly Image Player = Image.FromFile("resources/user_01.png");
        public static readonly Image Box = Image.FromFile("resources/box_01.png");
    }
}
