namespace PoolBallsWinFormsApp
{
    public class GreenBall : PoolBall
    {
        public GreenBall(Form form) : base(form)
        {
            OnLeftSide();
            newBrush = Brushes.LightSeaGreen;
        }
    }
}
