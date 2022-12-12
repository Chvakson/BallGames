using BallsGames.Common;

namespace FruitNinjaWinFormsApp
{
    public  class Fruit : RandomRisingBall
    {
        protected float g = 0.2f;

        public Fruit(Form form) : base(form) 
        {
            timer.Interval = 10;
            vx = random.Next(-4, 4);
            vy = random.Next(-13, -9);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;

            if (centerY > DownSide() + radius * 2)
            {
                Stop();
            }
        }

        public void Slow()
        {
            timer.Interval = 20;
        }

        public void Boost()
        {
            timer.Interval = 10;
        }
    }
}
