using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        private Bird bird;
        private Pig pig;
        private int score = 0;
        private Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void CreateBird()
        {
            timer.Stop();
            if (bird != null)
            {
                bird.Clear();
                bird.Stop();
            }
            bird = new Bird(this);
            bird.Show();
        }

        private void CreatePig()
        {
            pig = new Pig(this);
            pig.Show();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (!bird.IsMoveble())
            {
                CreateBird();
            }
            if (bird.IsOutSide())
            {
                CreateBird();
            }
            if (bird.Intersect(pig))
            {
                scoreLabel.Text = (score += 1).ToString();
                pig.Clear();
                CreateBird();
                CreatePig();
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (timer.Enabled == false)
            {
                bird.Launch(e.X, e.Y);
                timer.Start();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.scoreLabel.Text = "0";
            CreateBird();
            CreatePig();
        }
    }
}