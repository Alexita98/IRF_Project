using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH
{
    public partial class SeatBooking : Form
    {
        public SeatBooking(int selectedShowID, string selectedMovieName, DateTime selectedShowTime)
        {
            InitializeComponent();
        }
    }
}
