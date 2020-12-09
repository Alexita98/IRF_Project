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
        CinemaEntities1 context = new CinemaEntities1();
        List<Seat> bookedSeats = new List<Seat>();
        List<Seat> db_seats = new List<Seat>();
        private Seat actualChair;
        private string selectedMovieName2;
        private DateTime selectedShowTime2;
        private int selectedShowID2;
        

        public MovieBooking(int selectedShowID, string selectedMovieName, DateTime selectedShowTime, int countFreeSeats)
        {
            InitializeComponent();

            CreateCinemaHall();
            LoadChairs1(selectedShowID);
            ChairNumbers();
            StairsAdding();
            TextLabels(selectedMovieName, selectedShowTime, countFreeSeats);
            

            Curtain curtain = new Curtain();
            panelChairs.Controls.Add(curtain);

            Canvas canvas = new Canvas(Color.Black);
            panelChairs.Controls.Add(canvas);

            selectedMovieName2 = selectedMovieName;
            selectedShowTime2 = selectedShowTime;
            selectedShowID2 = selectedShowID;

        }

        private void CreateCinemaHall()
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

        private void LoadChairs1(int selShowID)
        {
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
                        chall.Enabled = false;
                     }
                }
            }
        }


        private void ChairNumbers() 
        {
            int i = 0;
            
            foreach (var sf in panelChairs.Controls.OfType<CinemaHall>())
            {
                db_seats.Clear();
                db_seats = context.Seats.ToList();
                actualChair = db_seats[i];
                sf.Value = int.Parse(actualChair.SeatNumber.ToString());
                i++;
            }
        }

        private void StairsAdding()
        {
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

        private void TextLabels(string selectedMovieName, DateTime selectedShowTime, int countFreeSeats)
        {
            txtMovie.Text = selectedMovieName;
            txtTime.Text = Convert.ToString(selectedShowTime);
            txtFree.Text = Convert.ToString(countFreeSeats);
            txtTotal.Text = "62";

            labelMovie.BackColor = System.Drawing.Color.Transparent;
            labelTime.BackColor = System.Drawing.Color.Transparent;
            labelFree.BackColor = System.Drawing.Color.Transparent;
            labelTotal.BackColor = System.Drawing.Color.Transparent;
            labelTitle.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int i;
            int[] chosenSeats = new int[62];
            i = 0;
            foreach (var chall in panelChairs.Controls.OfType<CinemaHall>())
            {
                if (chall.BackColor == Color.Orange)
                {
                    chosenSeats[i] = chall.buttonIndex;
                    i++;
                }
            }

            if (i>0)
            {
                mainPanel.Controls.Clear();
                UserControl_Information ucI = new UserControl_Information(i, selectedMovieName2, selectedShowTime2, selectedShowID2, chosenSeats);
                mainPanel.Controls.Add(ucI);
                ucI.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Válasszon ki legalább 1 széket!");
            }
            
        }

    }
}

