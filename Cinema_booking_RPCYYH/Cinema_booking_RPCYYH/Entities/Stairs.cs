using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH.Entities
{
    public class Stairs : Label
    {
        public SolidBrush CanvasColor { get; private set; }
       

        public Stairs(Color color)
        {
            AutoSize = false;
            Width = 30;
            Height = 8;
            CanvasColor = new SolidBrush(color);

            Paint += Stairs_Paint1;
        }

        private void Stairs_Paint1(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        void DrawImage(Graphics graphics)
        {
            graphics.FillRectangle(CanvasColor, 0, 0, Width, Height);
        }
    }
}
