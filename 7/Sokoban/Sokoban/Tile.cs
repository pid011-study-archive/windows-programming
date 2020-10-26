using System.Drawing;

namespace Sokoban
{
    public class Tile
    {
        public TileType Type { get; set; }
        public bool IsPlayer { get; set; }
        public bool IsBox { get; set; }

        public void Draw(Graphics graphics, Point pos)
        {
            Point realPos = new Point(pos.X * MainGame.TileSize, pos.Y * MainGame.TileSize);

            if (Type == TileType.Wall)
            {
                graphics.DrawImage(StaticSprites.Wall, realPos);
                return;
            }

            if (IsPlayer)
            {
                graphics.DrawImage(StaticSprites.Player, realPos);
                return;
            }

            if (IsBox)
            {
                graphics.DrawImage(StaticSprites.Box, realPos);
                return;
            }

            if (Type == TileType.Goal)
            {
                graphics.DrawImage(StaticSprites.Goal, realPos);
                return;
            }

            graphics.DrawImage(StaticSprites.Empty, realPos);
        }
    }
}
