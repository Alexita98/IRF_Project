using Cinema_booking_RPCYYH.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_booking_RPCYYH.Entities
{
    public class CanvasCreate : FigureCreate
    {
       public Color CanvasColor { get; set; }

        public CinemaScreen CreateNew()
        {
            return new Canvas(CanvasColor); 
        }
    }

    }
}
