using Timer = System.Windows.Forms.Timer;

namespace PoolBallsWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<PoolBall> balls = new List<PoolBall>();
        private Timer timer = new Timer();
        private Random random = new Random();
        private int randomBallsCount = 1;
        private int greenBallCounter = 0;
        private int redBallCounter = 0;

        public MainForm()
        {
            InitializeComponent();
            while(randomBallsCount % 2 != 0)
            {
                randomBallsCount = random.Next(6, 12);
            }
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void ShowCenterVerticalLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ShowCenterVerticalLine();
            int leftOfCenterGreenBallsCount = 0;
            int rightOfCenterGreenBallsCount = 0;

            int leftOfCenterRedBallsCount = 0;
            int rightOfCenterRedBallsCount = 0;

            foreach (var ball in balls)
            {
                if(ball.LeftOfCenter())
                {
                    if(ball.GetBrush() == Brushes.IndianRed)
                    {
                        leftOfCenterRedBallsCount++;
                    }

                    else
                    {
                        leftOfCenterGreenBallsCount++;
                    }
                }

                else 
                {
                    if(ball.RightOfCenter())
                    {
                        if (ball.GetBrush() == Brushes.LightSeaGreen)
                        {
                            rightOfCenterGreenBallsCount++;
                        }

                        else
                        {
                            rightOfCenterRedBallsCount++;
                        }
                    }
                }
            }

            if(leftOfCenterGreenBallsCount > 0 && leftOfCenterGreenBallsCount == leftOfCenterRedBallsCount && leftOfCenterGreenBallsCount + leftOfCenterRedBallsCount == balls.Count / 2)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
                timer.Enabled = false;
                MessageBox.Show($"Произошла диффузия!\nДавление зеленого газа на стенки сосуда: {greenBallCounter}\nДавление красного газа на стенки сосуда: {redBallCounter}");
            }

        }

        private void Create()
        {
            for (int i = 0; i < randomBallsCount; i++)
            {
                var greenBall = new GreenBall(this);
                greenBall.OnHited += greenBall_OnHited;
                balls.Add(greenBall);

                var redBall = new RedBall(this);
                redBall.OnHited += redBall_OnHited;
                balls.Add(redBall);
            }
        }

        private void redBall_OnHited(object? sender, PoolBall.HitEventArgs e)
        {
            switch (e.Side)
            {
                case PoolBall.Side.Left:
                    leftRedBallLabel.Text = (Convert.ToInt32(leftRedBallLabel.Text) + 1).ToString();
                    redBallCounter++;
                    break;
                case PoolBall.Side.Right:
                    rightRedBallLabel.Text = (Convert.ToInt32(rightRedBallLabel.Text) + 1).ToString();
                    redBallCounter++;
                    break;
                case PoolBall.Side.Up:
                    upRedBallLabel.Text = (Convert.ToInt32(upRedBallLabel.Text) + 1).ToString();
                    redBallCounter++;
                    break;
                case PoolBall.Side.Down:
                    downRedBallLabel.Text = (Convert.ToInt32(downRedBallLabel.Text) + 1).ToString();
                    redBallCounter++;
                    break;
            }
        }

        private void greenBall_OnHited(object? sender, PoolBall.HitEventArgs e)
        {
            switch (e.Side)
            {
                case PoolBall.Side.Left:
                    leftGreenBallLabel.Text = (Convert.ToInt32(leftGreenBallLabel.Text) + 1).ToString();
                    greenBallCounter++;
                    break;
                case PoolBall.Side.Right:
                    rightGreenBallLabel.Text = (Convert.ToInt32(rightGreenBallLabel.Text) + 1).ToString();
                    greenBallCounter++;
                    break;
                case PoolBall.Side.Up:
                    upGreenBallLabel.Text = (Convert.ToInt32(upGreenBallLabel.Text) + 1).ToString();
                    greenBallCounter++;
                    break;
                case PoolBall.Side.Down:
                    downGreenBallLabel.Text = (Convert.ToInt32(downGreenBallLabel.Text) + 1).ToString();
                    greenBallCounter++;
                    break;
            }
        }

        private void createToolStripButton_Click(object sender, EventArgs e)
        {
            Create();
            foreach (var ball in balls)
            {
                ball.Show();
            }
        }
        
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            var IsStop = true;
            foreach (var ball in balls)
            {
                if (ball.IsMoveble())
                {
                    ball.Stop();
                }

                else
                {
                    ball.ChangeV();
                    ball.Start();
                    IsStop = false;
                }
            }

            if (IsStop == true)
            {
                MessageBox.Show($"Давление зеленого газа на стенки сосуда: {greenBallCounter}\nДавление красного газа на стенки сосуда: {redBallCounter}");
            }
        }
    }
}