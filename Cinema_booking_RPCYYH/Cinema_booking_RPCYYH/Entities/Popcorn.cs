using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH.Entities
{
    public class Popcorn : Label
    {
        public Popcorn()
        {
            AutoSize = false;
            Width = 90;
            Height = 130;

            Paint += Popcorn_Paint;
        }

        private void Popcorn_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        public void DrawImage(Graphics graphics)
        {
            Image imageFile = Image.FromFile("images/popcorn.jpeg");
            graphics.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
