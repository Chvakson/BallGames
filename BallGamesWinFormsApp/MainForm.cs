using BallsGames.Common;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> balls = new List<RandomMoveBall>();
        private Random random = new Random();
        private int randomBallsCount;
        private int counter = 0;

        public MainForm()
        {
            InitializeComponent();
            stopToolStripButton.Enabled = false;
            restartToolStripButton.Enabled = false;
            randomBallsCount = random.Next(6, 30);
        }

        private void CreateBalls()
        {
            for (int i = 0; i < 7; i++)
            {
                var ball = new RandomMoveBall(this);
                balls.Add(ball);
            }
        }

        private void createAndMoveBallsToolStripButton_Click(object sender, EventArgs e)
        {
            stopToolStripButton.Enabled = true;
            createAndMoveBallsToolStripButton.Enabled = false;
            CreateBalls();
            foreach (var ball in balls)
            {
                ball.Start();
            }
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            stopToolStripButton.Enabled = false;
            restartToolStripButton.Enabled = true;
            foreach (var ball in balls)
            {
                if (ball.IsOnField())
                {
                    counter++;
                }
                ball.Stop();
            }
            MessageBox.Show($"Поймано {counter} шариков");
        }

        private void restartToolStripButton_Click(object sender, EventArgs e)
        {
            counter = 0;
            stopToolStripButton.Enabled = true;
            foreach (var ball in balls)
            {
                ball.Stop();
                ball.Clear();
            }
            balls.Clear();
            CreateBalls();
            foreach (var ball in balls)
            {
                ball.Start();
            }
        }
    }
}