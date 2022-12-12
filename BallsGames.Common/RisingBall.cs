namespace BallsGames.Common
{
    public class RisingBall : Ball
    {
        public float TopX;
        public float TopY;

        public RisingBall(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = form.ClientSize.Height;
            vx = random.Next(-10, 5);
            vy = random.Next(-10, -2);
            radius = 5;
            newBrush = Brushes.White;
        }

        protected override void Go()
        {
            base.Go();
            TopX = centerX;
            TopY = centerY;
        }
    }
}
