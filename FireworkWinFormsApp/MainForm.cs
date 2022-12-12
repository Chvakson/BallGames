using BallsGames.Common;
using Timer = System.Windows.Forms.Timer;

namespace FireworkWinFormsApp
{
    public partial class MainForm : Form
    {
        private RisingBall ball;
        private Random random;
        private Timer timer;
        private int ballCount;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            timer = new Timer();
            timer.Tick += Timer_Tick;
            ballCount = random.Next(6, 15);
            Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ball.Stop();
            ball.Clear();
            for (int i = 0; i < ballCount; i++)
            {
                var fireWork = new FireworkBall(this, (int)ball.TopX, (int)ball.TopY);
                fireWork.Start();
            }
            timer.Stop();
            Start();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < ballCount; i++)
            {
                var fireWork = new FireworkBall(this, e.X, e.Y);
                fireWork.Start();
            }
        }

        private void Create()
        {
            ball = new RisingBall(this);
            ball.Start();
        }

        private void Start()
        {
            timer.Interval = random.Next(500, 1300);
            Create();
            timer.Start();
        }
    }
}