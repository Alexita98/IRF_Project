using Cinema_booking_RPCYYH.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_booking_RPCYYH.Entities
{
    public class CurtainCreate : FigureCreate
    {
        public CinemaScreen CreateNew()
        {
            return new Curtain();
        }
    }
}
