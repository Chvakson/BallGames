using System.Net.Http.Headers;

namespace BallsGames.Common
{
    public class RandomMoveBall : RandomPaintBall
    {
        public float pointX;
        public float pointY;

        public RandomMoveBall(Form form) : base(form)
        { 
            vx = random.Next(-5, 7);
            vy = random.Next(-5, 7);
        }
    }
}
