namespace PoolBallsWinFormsApp
{
    public partial class PoolBall
    {
        public class HitEventArgs
        {
            public Side Side;

            public HitEventArgs(Side side)
            {
                Side = side;
            }
        }
    }
}
