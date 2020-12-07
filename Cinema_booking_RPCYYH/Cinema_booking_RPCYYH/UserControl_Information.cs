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
        public UserControl_Information(int i, int[] newBookedSeats, string selectedMovieName, DateTime selectedShowTime)
        {
            InitializeComponent();

            LabelsTexts(i, selectedMovieName, selectedShowTime);


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
    }
}
