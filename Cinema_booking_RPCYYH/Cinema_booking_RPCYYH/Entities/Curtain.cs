using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_booking_RPCYYH.Entities
{
    public class Curtain : CinemaScreen
    {
        protected override void DrawImage(Graphics graphics)
        {
            Image imageFile = Image.FromFile("images/curtain.png");
            graphics.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
        public CinemaScreen CreateNew()
        {
            return new Curtain();
        }
    }
}
