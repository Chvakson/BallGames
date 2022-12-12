using BallsGames.Common;

namespace AngryBirdsWinFormsApp
{
    public class Pig : RandomPaintBall
    {
        public Pig(Form form) : base(form)
        {
            newBrush = Brushes.LightGreen;
        }
    }
}
