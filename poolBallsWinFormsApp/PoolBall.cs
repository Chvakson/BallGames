using BallsGames.Common;

namespace PoolBallsWinFormsApp
{
    public partial class PoolBall : RandomMoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;

        public PoolBall(Form form) : base(form) => radius = 20;

        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                centerX = LeftSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= UpSide())
            {
                centerY = UpSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Up));
            }

            if (centerY >= DownSide())
            {
                centerY = DownSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
        public bool RightOfCenter()
        {
            return Enumerable.Range(form.ClientSize.Width / 2 + radius, RightSide()).Contains((int)centerX);
        }

        public bool LeftOfCenter()
        {
            return Enumerable.Range(LeftSide(), form.ClientSize.Width / 2 - radius).Contains((int)centerX);
        }
    }
}
