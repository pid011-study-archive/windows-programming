using System.Drawing;

namespace Sokoban
{
    public class Stage
    {
        public readonly Tile[,] Map;

        public string StageName { get; }
        public int MaxGoal { get; }
        public int GoalCount { get; private set; }
        public Point Size => new Point(Map.GetLength(1), Map.GetLength(0));
        public bool IsStageClear => CheckForTheGoals();

        private Point _playerPosition;

        public Stage(string stageName, int[,] rawTiles)
        {
            StageName = stageName;
            Map = new Tile[rawTiles.GetLength(0), rawTiles.GetLength(1)];
            MaxGoal = GoalCount = 0;

            for (int y = 0; y < Size.Y; y++)
            {
                for (int x = 0; x < Size.X; x++)
                {
                    Map[y, x] = new Tile();
                    int tiletype = rawTiles[y, x];
                    Tile targetTile = Map[y, x];

                    if (tiletype < 3)
                    {
                        targetTile.Type = (TileType)tiletype;
                        if (tiletype == 2) // Goal
                        {
                            MaxGoal++;
                        }
                    }
                    else
                    {
                        targetTile.Type = TileType.Empty;
                        if (tiletype == 3) // Box
                        {
                            targetTile.IsBox = true;
                        }
                        else if (tiletype == 4) // Player
                        {
                            targetTile.IsPlayer = true;
                            _playerPosition = new Point(x, y);
                        }
                    }
                }
            }
        }

        public void Draw(Graphics graphics)
        {
            for (int y = 0; y < Size.Y; y++)
            {
                for (int x = 0; x < Size.X; x++)
                {
                    Map[y, x].Draw(graphics, new Point(x, y));
                }
            }
        }

        public void MovePlayer(Direction movement)
        {
            Point movePosition = _playerPosition;
            switch (movement)
            {
                case Direction.Up:
                    movePosition.Y--;
                    break;
                case Direction.Down:
                    movePosition.Y++;
                    break;
                case Direction.Left:
                    movePosition.X--;
                    break;
                case Direction.Right:
                    movePosition.X++;
                    break;
                default:
                    break;
            }

            Tile targetTile = Map[movePosition.Y, movePosition.X];

            if (targetTile.Type == TileType.Wall)
            {
                return;
            }

            if (targetTile.IsBox)
            {
                Point offset = new Point(
                    movePosition.X - _playerPosition.X,
                    movePosition.Y - _playerPosition.Y);

                Point spot = new Point(
                    movePosition.X + offset.X,
                    movePosition.Y + offset.Y);

                Tile spotTile = Map[spot.Y, spot.X];
                if (!spotTile.IsBox && (spotTile.Type == TileType.Empty || spotTile.Type == TileType.Goal))
                {
                    Map[spot.Y, spot.X].IsBox = true;
                    Map[movePosition.Y, movePosition.X].IsBox = false;

                    Map[movePosition.Y, movePosition.X].IsPlayer = true;
                    Map[_playerPosition.Y, _playerPosition.X].IsPlayer = false;

                    _playerPosition = movePosition;
                }

                return;
            }

            if (targetTile.Type == TileType.Empty || targetTile.Type == TileType.Goal)
            {
                Map[movePosition.Y, movePosition.X].IsPlayer = true;
                Map[_playerPosition.Y, _playerPosition.X].IsPlayer = false;

                _playerPosition = movePosition;

                return;
            }
        }

        private bool CheckForTheGoals()
        {
            int goals = 0;
            for (int y = 0; y < Size.Y; y++)
            {
                for (int x = 0; x < Size.X; x++)
                {
                    if (Map[y, x].IsBox && Map[y, x].Type == TileType.Goal)
                    {
                        goals++;
                    }
                }
            }

            if (goals >= MaxGoal)
            {
                return true;
            }

            return false;
        }
    }
}
