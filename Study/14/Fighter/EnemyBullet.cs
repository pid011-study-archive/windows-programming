namespace Fighter
{
    public class EnemyBullet : UnitBase
    {
        public EnemyBullet(MainGame main) : base(main)
        {
        }

        public void SetInitialPosition(EnemyUnit enemy)
        {
            XPos = enemy.XPos;
            YPos = enemy.YPos + (enemy.UnitImage.Height / 2) + (UnitImage.Height / 2);
        }

        public override void Update()
        {
            base.Update();
            YPos += Speed;

            if (YPos + (UnitImage.Height / 2) > ControlHeight)
            {
                IsAlive = false;
            }
        }
    }
}
