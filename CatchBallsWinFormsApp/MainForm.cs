using BallsGames.Common;

namespace CatchBallsWinFormsApp
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
            randomBallsCount = random.Next(6, 30);
        }

        private void Create()
        {
            for (int i = 0; i < randomBallsCount; i++)
            {
                var ball = new RandomMoveBall(this);
                balls.Add(ball);
            }
        }

        private void createBallsStripButton_Click(object sender, EventArgs e)
        {
            createBallsStripButton.Enabled = false;
            Create();
            foreach (var ball in balls)
            {
                ball.Start();
            }
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            stopToolStripButton.Enabled = false;
            foreach (var ball in balls)
            {
                ball.Stop();
            }
        }

        private void restartToolStripButton_Click(object sender, EventArgs e)
        {
            stopToolStripButton.Enabled = true;
            counter = 0;
            countBallsToolStripLabel.Text = $"Поймано шариков: {counter}";
            foreach (var ball in balls)
            {
                ball.Stop();
                ball.Clear();
            }
            balls.Clear();
            Create();
            foreach (var ball in balls)
            {
                ball.Start();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (balls != null)
            {
                foreach (var ball in balls)
                {
                    if (ball.Contains(e.X, e.Y) && ball.IsMoveble())
                    {
                        ball.Stop();
                        counter++;
                    }
                }
                countBallsToolStripLabel.Text = $"Поймано шариков: {counter}";
            }
        }
    }
}