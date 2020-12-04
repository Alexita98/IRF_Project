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
    public partial class Form1 : Form
    {
        CinemaEntities context = new CinemaEntities();
        public Form1()
        {
            InitializeComponent();
            /* this.TopMost = true;
             this.WindowState = FormWindowState.Maximized;*/

            cboxMovie.DisplayMember = "MovieName";
            cboxTime.DisplayMember = "StartTime";
            //cboxYear.DisplayMember = "PublishYear";
            //cboxDay.DisplayMember = "StartTime";
            //cboxTime.ValueMember = "Movie_ID";

            cboxMovie.DataSource = (from x in context.Movies
                                    select x).ToList();
            cboxYear.DataSource = (from x in context.Movies
                                   select x.PublishYear).ToList();

            // this.searchMovie();

            dataGridView1.DataSource = (from x in context.Movie_Show
                                        where x.Movie_FK == x.Movie.Movie_ID
                                        orderby x.StartTime
                                        select new
                                        {
                                            Film = x.Movie.MovieName,
                                            Vetítés = x.StartTime,
                                            Megjelenés = x.Movie.PublishYear,
                                            Filmhossz = x.Movie.DurationMinutes
                                        }).ToList();
            //this.dataGridView1.Sort(this.dataGridView1.Columns["Vetítés"], ListSortDirection.Ascending);
        }

        private void cboxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie selectedMovie = (Movie)cboxMovie.SelectedItem;
            cboxTime.DataSource = (from x in context.Movie_Show
                                    where x.Movie_FK == selectedMovie.Movie_ID
                                    select x.StartTime).ToList();
        }

        private void cboxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Movie_Show selectedTime = (Movie_Show)cboxTime.SelectedItem;
            DateTime selectedTime = (DateTime)cboxTime.SelectedItem;
            Movie selectedMovie = (Movie)cboxMovie.SelectedItem;
     
            int countFreeSeats = CountFreeSeats(selectedMovie, selectedTime);
            labelSeatNumber.Text = countFreeSeats.ToString();
        }

        private void btnSeats_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = (DateTime)cboxTime.SelectedItem;
            Movie selectedMovie = (Movie)cboxMovie.SelectedItem;
            int selectedShowID = (from x in context.Movie_Show
                                   where x.Movie_FK == selectedMovie.Movie_ID
                                   && x.StartTime == selectedTime
                                   select x.Movie_Show_ID).FirstOrDefault();
            string selectedMovieName = selectedMovie.MovieName;
            DateTime selectedShowTime = selectedTime;
            int countFreeSeats = CountFreeSeats(selectedMovie, selectedTime);


            //MessageBox.Show(selectedShowID+" "+selectedMovieName+" "+selectedShowTime);

            this.Hide();
            SeatBooking form2 = new SeatBooking(selectedShowID, selectedMovieName, selectedShowTime, countFreeSeats);
            form2.ShowDialog();
        }


        /*private void searchMovie()
        {
            string searchValue = txtboxTitle.Text.ToLower();
            txtboxTitle.DataSource =
                (
                    from t in context.Textbook //.Local szűrés optimalizálás
                        where t.Title.ToLower().Contains(txtboxTitle.Text)
                    select t
               ).ToList();
        }*/

        private int CountFreeSeats(Movie selectedMovie, DateTime selectedTime)
        {
            int freeSeats = 57 - (from x in context.Tickets
                                  where x.Movie_Show.Movie.Movie_ID == selectedMovie.Movie_ID
                                  && x.Movie_Show_FK == x.Movie_Show.Movie_Show_ID
                                  && x.Movie_Show.StartTime == selectedTime
                                  select x.Seat_FK).Count();
            return freeSeats;
        }

    }
}
