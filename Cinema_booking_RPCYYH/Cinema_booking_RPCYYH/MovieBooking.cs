using Cinema_booking_RPCYYH.Entities;
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

        //CinemaEntities context = new CinemaEntities();
        CinemaEntities1 context = new CinemaEntities1();
        //List<Chair> seats = new List<Chair>();
        List<Seat> bookedSeats = new List<Seat>();
        List<Seat> db_seats = new List<Seat>();
        //private Chair actualChair;
        private Seat actualChair;
        

        public MovieBooking(int selectedShowID, string selectedMovieName, DateTime selectedShowTime, int countFreeSeats)
        {
            InitializeComponent();
            createCinemaHall();
            LoadChares2(selectedShowID);
            ChairNumbers();

            txtMovie.Text = selectedMovieName;
            txtTime.Text = Convert.ToString(selectedShowTime);
            txtFree.Text = Convert.ToString(countFreeSeats);
            txtTotal.Text = "57";

            labelMovie.BackColor = System.Drawing.Color.Transparent;
            labelTime.BackColor = System.Drawing.Color.Transparent;
            labelFree.BackColor = System.Drawing.Color.Transparent;
            labelTotal.BackColor = System.Drawing.Color.Transparent;
            labelTitle.BackColor = System.Drawing.Color.Transparent;


            Curtain curtain = new Curtain();
            panelChairs.Controls.Add(curtain);

            Canvas canvas = new Canvas(Color.Black);
            panelChairs.Controls.Add(canvas);

            for (int i = 0; i < 15; i++)
            {
                Stairs stair = new Stairs(Color.Gray);
                stair.Top = i * stair.Height + i * 2;
                panelStairs1.Controls.Add(stair);
                
            }

            for (int i = 0; i < 15; i++)
            {
                Stairs stair = new Stairs(Color.Gray);
                stair.Top = i * stair.Height + i * 2;
                panelStairs2.Controls.Add(stair);

            }
        }

        private void createCinemaHall()
        {
            panelChairs.Controls.Clear();
            int row, col, index;
            int lineWidth = 30;

            index = 0;

            for (row = 6; row < 11; row++)
            {
                for (col = 3; col < 13; col++)
                {
                    CinemaHall ch = new CinemaHall();
                    ch.buttonIndex = index;
                    ch.Top = row * ch.Height;
                    ch.Left = col * ch.Width + (int)(Math.Floor((double)(col / 5))) * lineWidth;
                    panelChairs.Controls.Add(ch);

                    index++;
                }
            }

            for (col = 3; col < 15; col++)
            {
                CinemaHall ch = new CinemaHall();
                ch.buttonIndex = index;
                ch.Top = 11 * ch.Height;
                ch.Left = col * ch.Width;
                panelChairs.Controls.Add(ch);

                index++;
            }
        }

        /*
        private void LoadChares()
        {
            //int i = 0;
            seats.Clear();
            db_seats.Clear();

            db_seats = context.Seats.ToList();
            
            foreach (Seat seat in db_seats)
            {
                Chair ch = new Chair();
                ch.SeatNumber = seat.SeatNumber;
                ch.RowNumber = seat.Row_FK;
                ch.Index = seat.Seat_ID;

                var occupiedSeat = (from x in context.Tickets
                                    where x.Seat_FK == ch.Index
                                    select x.Seat_FK).Any();
                if (occupiedSeat == true)
                {
                    ch.Occupied = true;
                    var occupantPerson = (from x in context.Tickets
                                          where x.Seat_FK == seat.SeatNumber
                                          && x.Booking_FK == x.Booking.Booking_ID
                                          && x.Booking.Customer_FK == x.Booking.Customer.Customer_ID
                                          select x.Booking.Customer.Name).FirstOrDefault();
                    ch.Occupant = occupantPerson;


                    foreach (var chall in panelChairs.Controls.OfType<CinemaHall>())
                    {
                        //int.Parse(actualChair.SeatNumber.ToString())
                        if (chall.buttonIndex==int.Parse(seat.Seat_ID.ToString()))
                        {
                            chall.BackColor = Color.Red;
                        }
                    }

                }
                else
                {
                    ch.Occupied = false;
                    ch.Occupant = "Free";
                }
                seats.Add(ch);
                
            }
            
        }*/

        private void LoadChares2(int selShowID)
        {
  
            //bookedSeats.Clear();
            //bookedSeats = context.Seats.ToList();

            var bookedSeats = (from x in context.Tickets
                               where x.Movie_Show_FK==selShowID
                               select x.Seat_FK).ToList();

            foreach (var seat in bookedSeats)
            {
                
                foreach (var chall in panelChairs.Controls.OfType<CinemaHall>())
                {
                     if (chall.buttonIndex == seat)
                     {
                            chall.BackColor = Color.Red;
                     }
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

        private void ChairNumbers() 
        {
            int i = 0;
            
            foreach (var sf in panelChairs.Controls.OfType<CinemaHall>())
            {
                db_seats = context.Seats.ToList();
                actualChair = db_seats[i];
                //actualChair = seats[i];
                sf.Value = int.Parse(actualChair.SeatNumber.ToString());
                //sf.Active = sf.Value == 0; //ha a sudokuField=0 --> Active=false 
                i++;
            }
        }

        private void BookedChairs()
        {
            if (true)
            {

            }
        }

        
    }
}

