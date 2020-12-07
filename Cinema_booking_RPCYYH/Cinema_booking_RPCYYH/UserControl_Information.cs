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
    public partial class UserControl_Information : UserControl
    {
        CinemaEntities1 context = new CinemaEntities1();
        private int MoviewShowID;
        private int[] chosenSeats2;
        public UserControl_Information(int i, string selectedMovieName, DateTime selectedShowTime, int selectedShowID, int[] chosenSeats)
        {
            InitializeComponent();

            LabelsTexts(i, selectedMovieName, selectedShowTime);
            MoviewShowID = selectedShowID;

            for (int n = 0; n < chosenSeats.Length; n++)
            {
                chosenSeats2[i] = chosenSeats[i];
            }
            

            
            for (int k = 0; k < 4; k++)
            {
                Popcorn popcorn = new Popcorn();
                panelPopcorn.Controls.Add(popcorn);
                popcorn.Left = k * popcorn.Width + 55;
            }


        }

        private void LabelsTexts(int i, string movie, DateTime show)
        {
            textNumber.Text = Convert.ToString(i);
            textTotal.Text = Convert.ToString(i * 2200);
            textMovie.Text = movie;
            textDate.Text = Convert.ToString(show);

           

            labelMovie.BackColor = System.Drawing.Color.Transparent;
            labelTime.BackColor = System.Drawing.Color.Transparent;
            labelPrice.BackColor = System.Drawing.Color.Transparent;
            labelNumber.BackColor = System.Drawing.Color.Transparent;
            labelTitle2.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            Booking book = new Booking();
            Ticket tick = new Ticket();

            if (textName.Text != "" && textPhone.Text != "" && textEmail.Text != "")
            {
                cus.Name = textName.Text;
                cus.Phone = textPhone.Text;
                cus.Email = textEmail.Text;
                context.Customers.Add(cus);

                book.BookingDate = DateTime.Now;
                book.Customer_FK = cus.Customer_ID;
                context.Bookings.Add(book);

                for (int k = 0; k < chosenSeats2.Length; k++)
                {
                    tick.Price = 2200;
                    tick.Booking_FK = book.Booking_ID;
                    tick.Movie_Show_FK = MoviewShowID;
                    tick.Seat_FK = chosenSeats2[k];
                    context.Tickets.Add(tick);
                }
                
                
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("A foglalás sikeres, szeretettel várjuk!");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textName.BackColor = Color.FromArgb(255, 142, 142);
            }

            
        }
    }
}
