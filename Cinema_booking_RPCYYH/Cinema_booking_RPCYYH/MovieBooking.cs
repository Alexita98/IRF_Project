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
    public partial class MovieBooking : Form
    {
        CinemaEntities context = new CinemaEntities();
        List<Seat> seats = new List<Seat>();

        public MovieBooking(int selectedShowID, string selectedMovieName, DateTime selectedShowTime, int countFreeSeats)
        {
            InitializeComponent();
            createCinemaHall();
            LoadChares();

            txtMovie.Text = selectedMovieName;
            txtTime.Text = Convert.ToString(selectedShowTime);
            txtFree.Text = Convert.ToString(countFreeSeats);
            txtTotal.Text = "57";

            labelMovie.BackColor = System.Drawing.Color.Transparent;
            labelTime.BackColor = System.Drawing.Color.Transparent;
            labelFree.BackColor = System.Drawing.Color.Transparent;
            labelTotal.BackColor = System.Drawing.Color.Transparent;
            labelTitle.BackColor = System.Drawing.Color.Transparent;
        }

        private void createCinemaHall()
        {
            int row, col;

            for (row = 7; row < 11; row++)
            {
                for (col = 3; col < 8; col++)
                {
                    CinemaHall ch = new CinemaHall();
                    ch.Top = row * ch.Height;
                    ch.Left = col * ch.Width;
                    panelChairs.Controls.Add(ch);
                }
            }
            for (row = 6; row < 11; row++)
            {
                for (col = 10; col < 15; col++)
                {
                    CinemaHall ch = new CinemaHall();
                    ch.Top = row * ch.Height;
                    ch.Left = col * ch.Width;
                    panelChairs.Controls.Add(ch);
                }
            }
            for (col = 3; col < 15; col++)
            {
                CinemaHall ch = new CinemaHall();
                ch.Top = 11 * ch.Height;
                ch.Left = col * ch.Width;
                panelChairs.Controls.Add(ch);
            }
        }

        private void LoadChares()
        {
            seats = context.Seats.ToList();
            for (int i = 0; i < 57; i++)
            {
                var actualSeatNumber = (from x in context.Seats
                                        where x.Seat_ID == i
                                        select x.SeatNumber).FirstOrDefault();
                Chair ch = new Chair();
                ch.SeatNumber = actualSeatNumber;

                var occupiedSeat = (from x in context.Tickets
                                    where x.Seat_FK == i
                                    select x.Seat_FK).FirstOrDefault();
                if (occupiedSeat != 0)
                {
                    ch.Occupied = true;

                    var occupantPerson = (from x in context.Tickets
                                          where i == x.Seat_FK
                                          && x.Booking_FK == x.Booking.Booking_ID
                                          && x.Booking.Customer_FK == x.Booking.Customer.Customer_ID
                                          select x.Booking.Customer.Name).FirstOrDefault();
                    ch.Occupant = occupantPerson;
                }
                else
                {
                    ch.Occupied = false;
                    ch.Occupant = "Free";
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UserControl_Information ucI = new UserControl_Information();
            mainPanel.Controls.Add(ucI);
            ucI.Dock = DockStyle.Fill;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

