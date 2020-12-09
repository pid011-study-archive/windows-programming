namespace ShootingStar.Game
{
    public class EnemyBullet : UnitBase
    {
        public EnemyBullet(GameForm main) : base(main)
        {
        }

        public void SetInitialPosition(EnemyUnit enemy)
        {
            Position.X = enemy.Position.X;
            Position.Y = enemy.Position.Y + (enemy.UnitImage.Height / 2) + (UnitImage.Height / 2);
        }

        public override void Update()
        {
            base.Update();
            Position.Y += Speed;

            if (Position.Y + (UnitImage.Height / 2) > ControlHeight)
            {
                IsAlive = false;
            }
        }
    }
}
