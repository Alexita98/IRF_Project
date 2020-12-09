using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH
{
    public partial class Form1 : Form
    {
        CinemaEntities1 context = new CinemaEntities1();
        public Form1()
        {
            InitializeComponent();

            cboxMovie.DisplayMember = "MovieName";
            cboxTime.DisplayMember = "StartTime";

            cboxMovie.DataSource = (from x in context.Movies
                                    select x).ToList();
            /*cboxYear.DataSource = (from x in context.Movies
                                   select x.PublishYear).ToList();*/

            System.Object[] ItemObject = new System.Object[2];
            ItemObject[0] = "Megjelenési év";
            ItemObject[1] = "Film név";

            cBoxFilters.Items.AddRange(ItemObject);

      

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
            Filters(false);
           
            GetFreeSeats();
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
            GetFreeSeats();
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


            this.Hide();
            MovieBooking form2 = new MovieBooking(selectedShowID, selectedMovieName, selectedShowTime, countFreeSeats);
            form2.ShowDialog();
        }


        private int CountFreeSeats(Movie selectedMovie, DateTime selectedTime)
        {
            int freeSeats = 62 - (from x in context.Tickets
                                  where x.Movie_Show.Movie.Movie_ID == selectedMovie.Movie_ID
                                  && x.Movie_Show_FK == x.Movie_Show.Movie_Show_ID
                                  && x.Movie_Show.StartTime == selectedTime
                                  select x.Seat_FK).Count();
            return freeSeats;
        }

        private void GetFreeSeats()
        {
            DateTime selectedTime = (DateTime)cboxTime.SelectedItem;
            Movie selectedMovie = (Movie)cboxMovie.SelectedItem;
            int countFreeSeats = CountFreeSeats(selectedMovie, selectedTime);
            labelSeatNumber.Text = countFreeSeats.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            bool saving = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.Default))
                {
                    sw.Write("Film" + ";" + "Vetítés" + ";" + "Megjelenés" + ";" + "Filmhossz");
                    sw.WriteLine();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            sw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridView1.Columns.Count - 1)
                            {
                                sw.Write(";");
                            }
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                saving = false;
            }

            if (saving == true)
            {
                MessageBox.Show("A moziműsor sikeresen mentésre került");
            }
        }

       

        private void YearFilter()
        {
            int selectedYear = Convert.ToInt32(cboxYear.SelectedItem);
            dataGridView1.DataSource = (from x in context.Movie_Show
                                        where selectedYear == x.Movie.PublishYear
                                        && x.Movie_FK == x.Movie.Movie_ID
                                        orderby x.StartTime
                                        select new
                                        {
                                            Film = x.Movie.MovieName,
                                            Vetítés = x.StartTime,
                                            Megjelenés = x.Movie.PublishYear,
                                            Filmhossz = x.Movie.DurationMinutes
                                        }).ToList();
            //dataGridView1.Invalidate();
        }
        private void MovieFilter()
        {
            string selectedMovie = Convert.ToString(cboxYear.SelectedItem);
            dataGridView1.DataSource = (from x in context.Movie_Show
                                        where selectedMovie == x.Movie.MovieName
                                        && x.Movie_FK == x.Movie.Movie_ID
                                        orderby x.StartTime
                                        select new
                                        {
                                            Film = x.Movie.MovieName,
                                            Vetítés = x.StartTime,
                                            Megjelenés = x.Movie.PublishYear,
                                            Filmhossz = x.Movie.DurationMinutes
                                        }).ToList();
        }
        

        private void Filters(bool isFilterSelected)
        {
            if (Convert.ToString(cBoxFilters.SelectedItem) == "Megjelenési év")
            {
                if (!isFilterSelected)
                cboxYear.DataSource = (from x in context.Movies
                                       orderby x.PublishYear
                                       select x.PublishYear).Distinct().ToList();
                YearFilter();
            }
            else if (Convert.ToString(cBoxFilters.SelectedItem) == "Film név")
            {
                if (!isFilterSelected)
                    cboxYear.DataSource = (from x in context.Movies
                                       select x.MovieName).ToList();
                MovieFilter();
            }
            
        }

        private void cBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters(false);
        }
        private void cboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filters(true);
            
        }
    }
}
