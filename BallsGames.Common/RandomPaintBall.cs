namespace BallsGames.Common
{
    public class RandomPaintBall : Ball
    {
        public RandomPaintBall(Form form) : base(form)
        {
             centerX = random.Next(LeftSide(), RightSide());
             centerY = random.Next(UpSide(), DownSide());
        }

        public void OnLeftSide()
        {
            centerX = random.Next(LeftSide(), form.ClientSize.Width / 2 - radius);
        }

        public void OnRightSide()
        {
            centerX = random.Next(form.ClientSize.Width / 2 + radius, RightSide());
        }
    }
}
