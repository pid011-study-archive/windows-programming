namespace Fighter
{
    public class PlayerBullet : UnitBase
    {
        public PlayerBullet(MainGame main) : base(main)
        {
        }

        public void SetInitialPosition(PlayerUnit player)
        {
            XPos = player.XPos;
            YPos = player.YPos - (player.UnitImage.Height / 2) - (UnitImage.Height / 2);
        }

        public override void Update()
        {
            base.Update();
            YPos -= Speed;

            if (YPos + (UnitImage.Height / 2) < 0)
            {
                IsAlive = false;
            }
        }
    }
}
