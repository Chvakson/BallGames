namespace BallsGames.Common
{
    public class FallingBall : RandomMoveBall
    {
        protected float g = 0.2f;

        public FallingBall(Form form) : base(form)
        {

        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
