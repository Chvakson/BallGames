using BallsGames.Common;

namespace AngryBirdsWinFormsApp
{
    public class Bird : Ball
    {
        private float g = 0.2f;
        private float factor = 20;
        private float friction = 0.5f;

        public Bird(Form form) : base(form)
        {
            timer.Interval = 25;
            centerX = LeftSide();
            centerY = DownSide();
            newBrush = Brushes.DarkRed;
        }

        public void Launch(float pointX, float pointY)
        {
            vx = (pointX - centerX) / factor;
            vy = (pointY - centerY) / factor;
            Start();
        }

        protected override void Go()
        {
            base.Go();
            if (centerY >= DownSide())
            {
                centerY = DownSide();
                vy = - vy;
                vy *= friction;
                vx *= friction;
            }

            if (vx < 0.1 && vy < 0.1)
            {
                Stop();
            }
            vy += g;

        }

        internal bool IsOutSide()
        {
            return centerX > RightSide();
        }
    }
}
