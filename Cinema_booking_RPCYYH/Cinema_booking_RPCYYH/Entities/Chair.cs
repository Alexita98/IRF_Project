﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_booking_RPCYYH
{
    class Chair
    {
        public int Index { get; set; }
        public int SeatNumber { get; set; }

        public int RowNumber { get; set; }

        public bool Occupied { get; set; }

        public string Occupant { get; set; }
    }
}
