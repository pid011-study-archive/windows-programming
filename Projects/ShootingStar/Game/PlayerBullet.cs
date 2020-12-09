namespace ShootingStar.Game
{
    public class PlayerBullet : UnitBase
    {
        public PlayerBullet(GameForm main) : base(main)
        {
        }

        public void SetInitialPosition(PlayerUnit player)
        {
            Position.X = player.Position.X;
            Position.Y = player.Position.Y - (player.UnitImage.Height / 2) - (UnitImage.Height / 2);
        }

        public override void Update()
        {
            base.Update();
            Position.Y -= Speed;

            if (Position.Y + (UnitImage.Height / 2) < 0)
            {
                IsAlive = false;
            }
        }
    }
}
