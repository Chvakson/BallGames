using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolBallsWinFormsApp
{
    internal class RedBall : PoolBall
    {
        public RedBall(Form form) : base(form)
        {
            OnRightSide();
            newBrush =  Brushes.IndianRed;
        }
    }
}
