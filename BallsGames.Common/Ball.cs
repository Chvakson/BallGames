using System;
using Timer = System.Windows.Forms.Timer;

namespace BallsGames.Common
{
    public class Ball
    {
        protected Form form;
        protected float vx = -20;
        protected float vy = 15;
        protected float centerX = 100;
        protected float centerY = 100;
        protected int radius = 25;
        protected Timer timer;
        protected Brush brush;
        protected Brush newBrush = Brushes.LightSeaGreen;
        protected static Random random = new Random();

        public Ball(Form form)
        {
            this.form = form;
            brush = new SolidBrush(form.BackColor);
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        public Brush GetBrush()
        {
            return newBrush;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public bool IsMoveble()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int UpSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool Contains(int pointX, int pointY)
        {
            var dX = (centerX - pointX);
            var dY = (centerY - pointY);
            return dX * dX + dY * dY <= radius * radius;
        }

        private void Paint(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectange = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectange);
        }

        public void Show()
        {
            Paint(newBrush);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Clear()
        {
            Paint(brush);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public bool Intersect(Ball other)
        {
            var dx = centerX - other.centerX;
            var dy = centerY - other.centerY;
            return dx * dx + dy * dy <= Math.Pow(radius + other.radius, 2);
        }

        public bool IsOnField()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= UpSide() && centerY <= DownSide();
        }

        public void ChangeV()
        {
            vx = random.Next(-30, 30);
            vy = random.Next(-30, 30);
        }
    }
}
