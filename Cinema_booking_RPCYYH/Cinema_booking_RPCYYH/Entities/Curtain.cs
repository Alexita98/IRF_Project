using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH.Entities
{
    public class Curtain : Label
    {
        public Curtain()
        {
            AutoSize = false;
            Width = 700;
            Height = 60;

            Paint += Curtain_Paint;
        }

        private void Curtain_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        public void DrawImage(Graphics graphics)
        {
            Image imageFile = Image.FromFile("images/curtain.png");
            graphics.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
        /*public Curtain CreateNewCurtain()
        {
            return new Curtain();
        }*/
    }
}
