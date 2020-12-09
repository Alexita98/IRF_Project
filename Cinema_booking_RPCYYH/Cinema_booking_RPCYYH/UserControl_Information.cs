using Cinema_booking_RPCYYH.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            chosenSeats2 = new int[i];

            for (int n = 0; n < chosenSeats2.Length; n++)
            {
                chosenSeats2[n] = chosenSeats[n];
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
            
            if (textName.Text != "" && textPhone.Text != "" && textEmail.Text != "")
            {
                Customer cus = new Customer();
                cus.Name = textName.Text;
                cus.Phone = textPhone.Text;
                cus.Email = textEmail.Text;
                context.Customers.Add(cus);
 
                MessageBox.Show($"Customer_ID (6): { cus.Customer_ID.ToString()} CustomerName: {cus.Name.ToString()} Email: {cus.Email.ToString()} Phone: {cus.Phone.ToString()}");

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("A customer mentésnél van a hiba: " + ex.Message);
                }
                //context.Customers.Load();

                Booking book = new Booking();
                book.BookingDate = DateTime.Now;
                book.Customer_FK = cus.Customer_ID;
                context.Bookings.Add(book);
                MessageBox.Show($"Customer_FK (6): {book.Customer_FK.ToString()} Booking_ID(6): { book.Booking_ID.ToString()} BookingDate: {book.BookingDate.ToString()}");
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("A booking mentésnél van a hiba: " + ex.Message);
                }
                context.Bookings.Load();


                for (int k = 0; k < chosenSeats2.Length; k++)
                {
                    Ticket tick = new Ticket();
                    tick.Price = 2200;
                    tick.Booking_FK = book.Booking_ID;
                    tick.Movie_Show_FK = MoviewShowID;
                    tick.Seat_FK = chosenSeats2[k];
                    context.Tickets.Add(tick);
                    //MessageBox.Show(tick.Price.ToString());
                    MessageBox.Show($"Lefoglalt jegyek:{chosenSeats2.Length.ToString()} BookingFK (6): {tick.Booking_FK.ToString()} Movie_Show_FK (3): {tick.Movie_Show_FK.ToString()} Seat_FK (61): {tick.Seat_FK.ToString()} Ticket_ID (13): {tick.Ticket_ID.ToString()} ");
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
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("A ticket mentésnél van a hiba: " + ex.Message);
                }
            }
            else
            {
                textName.BackColor = Color.FromArgb(255, 142, 142);
            }

            
        }

        //---------------------VALIDÁLÁS-----------------------------------------

        private void textName_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            //nem lehet üres
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (regex.IsMatch(textName.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textName.Text))
                {
                    textName.BackColor = Color.LightGreen;
                }
                else textName.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                textName.BackColor = Color.FromArgb(255, 142, 142);
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            //email szabvány + nem lehet üres
            Regex regex = new Regex(@"(^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$)");
            if (regex.IsMatch(textEmail.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textEmail.Text))
                    textEmail.BackColor = Color.LightGreen;
                else
                    textEmail.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                textEmail.BackColor = Color.FromArgb(255, 142, 142);
            }
        }

        private void textPhone_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(\+36|06)(-|/)[0-9]{1,2}-[0-9]{3}-?[0-9]{3,4}$");
            if (regex.IsMatch(textPhone.Text))
            {
                e.Cancel = false;

                if (!String.IsNullOrWhiteSpace(textPhone.Text))
                    textPhone.BackColor = Color.LightGreen;
                else
                    textPhone.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                textPhone.BackColor = Color.FromArgb(255, 142, 142);
            }
        }
    }
}
