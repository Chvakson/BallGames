using BallsGames.Common;

namespace FireworkWinFormsApp
{
    public class FireworkBall : FallingBall
    {
        private Random random = new Random();
        private List<Brush> brushes = new List<Brush>

        {
            Brushes.IndianRed,
            Brushes.LightSeaGreen,
            Brushes.OrangeRed,
            Brushes.LightGreen,
            Brushes.DeepSkyBlue,
            Brushes.Violet,
            Brushes.Green,
            Brushes.LightPink,
            Brushes.Yellow,
        };

        public FireworkBall(Form form, int centerX, int centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            Explosion();
        }

        public void Explosion()
        {
            vy = -Math.Abs(vy);
            newBrush = brushes[random.Next(0, brushes.Count)];
            radius = random.Next(3, 15);
        }
    }
}
