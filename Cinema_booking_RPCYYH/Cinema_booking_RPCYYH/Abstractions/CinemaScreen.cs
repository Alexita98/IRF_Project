using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH
{
    public abstract class CinemaScreen : Label
    {
        public CinemaScreen()
        {
            AutoSize = false;
            Width = 50;
            Height = 50;

            Paint += CinemaScreen_Paint;
        }

        private void CinemaScreen_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics graphics);
    }
}
