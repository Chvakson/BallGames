
namespace BallsGames.Common
{
    public class RandomRisingBall : RisingBall
    {
        private Random random;
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
            Brushes.Black,
            Brushes.Yellow
        };

        public RandomRisingBall(Form form) : base(form)
        {
            random = new Random();
            radius = random.Next(15, 35);
            newBrush = brushes[random.Next(0, brushes.Count)];
        }
    }
}
