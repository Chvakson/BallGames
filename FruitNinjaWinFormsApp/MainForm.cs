using BallsGames.Common;
using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWinFormsApp
{
    public partial class MainForm : Form
    {
        private int ticks = 3;
        private Timer timer;
        private List<Fruit> fruits;

        public MainForm()
        {
            InitializeComponent();
            fruits = new List<Fruit> { };
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 300;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Create();
        }

        private void newTimer_Tick(object sender, EventArgs e)
        {
            ticks--;
            Create();
            Slow();
            if (ticks == 0)
            {
                bananaTimer.Enabled = false;
                timer.Enabled = true;
                Boost();
            }
        }

        private async void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Contains(e.X, e.Y))
                {
                    if (fruits[i].GetBrush() == Brushes.Black)
                    {
                        End();
                        MessageBox.Show("ÊÎÍÅÖ ÈÃÐÛ!");
                    }

                    if (fruits[i].GetBrush() == Brushes.Yellow)
                    {
                        ticks = 3;
                        Slow();
                        timer.Stop();
                        bananaTimer.Start();
                    }

                    fruits[i].Stop();
                    fruits[i].Clear();
                    fruits.RemoveAt(i);
                }
            }
        }

        private void Create()
        {
            var fruit = new Fruit(this);
            fruits.Add(fruit);
            fruit.Start();
        }

        private void Boost()
        {
            foreach (var fruit in fruits)
            {
                fruit.Boost();
            }
        }

        private void Slow()
        {
            foreach (var fruit in fruits)
            {
                fruit.Slow();
            }
        }

        private void End()
        {
            timer.Stop();
            bananaTimer.Stop();
            foreach (var fruit in fruits)
            {
                fruit.Stop();
                fruit.Clear();
            }
        }
    }
}