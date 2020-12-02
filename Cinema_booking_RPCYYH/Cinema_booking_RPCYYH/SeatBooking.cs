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
        CinemaEntities context = new CinemaEntities();
        List<Seat> seats = new List<Seat>();

        public SeatBooking(int selectedShowID, string selectedMovieName, DateTime selectedShowTime)
        {
            InitializeComponent();
            createCinemaHall();
            LoadCharis();

            labelMovieName.Text = selectedMovieName;
        }

       // int lineWidth = 3;
        private void createCinemaHall()
        {
            int row, col;
            
            for (row = 3; row < 7; row++)
            {
                for (col = 3; col < 8; col++)
                {
                    CinemaHall ch = new CinemaHall();
                    //ch.Top = row * ch.Height + (int)(Math.Floor((double)(row / 3))) * lineWidth;
                    //ch.Left = col * ch.Width + (int)(Math.Floor((double)(col / 3))) * lineWidth;
                    ch.Top = row * ch.Height;
                    ch.Left = col * ch.Width;
                    panel1.Controls.Add(ch);
                }
            }
            for (row = 2; row < 7; row++)
            {
                for (col = 10; col < 15; col++)
                {
                    CinemaHall ch = new CinemaHall();
                    //ch.Top = row * ch.Height + (int)(Math.Floor((double)(row / 1))) * lineWidth;
                    ch.Top = row * ch.Height;
                    ch.Left = col * ch.Width;
                    panel1.Controls.Add(ch);
                }
            }
            for(col=3; col< 15; col++)
            {
                CinemaHall ch = new CinemaHall();
                ch.Top = 7 * ch.Height;
                ch.Left = col * ch.Width;
                panel1.Controls.Add(ch);
            }
        }

        private void LoadCharis()
        {
            seats = context.Seats.ToList();

        }
    }
}
