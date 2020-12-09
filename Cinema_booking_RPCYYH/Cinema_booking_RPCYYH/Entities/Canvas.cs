using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH.Entities
{
    public class Canvas : Label
    {
        public SolidBrush CanvasColor { get; private set; }
        public Canvas(Color color)
        {
            AutoSize = false;
            Width = 400;
            Height = 100;
            Left = 50;
            CanvasColor = new SolidBrush(color);

            Paint += Canvas_Paint;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        void DrawImage(Graphics graphics)
        {
            graphics.FillRectangle(CanvasColor, 0, 0, Width, Height);
        }
    }
}
