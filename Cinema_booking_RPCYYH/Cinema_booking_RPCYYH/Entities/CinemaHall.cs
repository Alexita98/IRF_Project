using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_RPCYYH
{
    class CinemaHall : Button
    {
        public int buttonIndex { get; set; }
        public CinemaHall()
        {
            this.Height = 30;
            this.Width = 30;
            this.BackColor = Color.Green;
            this.MouseDown += CinemaHall_MouseDown;
        }

        private void CinemaHall_MouseDown(object sender, MouseEventArgs e)
        {
           Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Orange":
                    ctrl.BackColor = Color.Green;
                    break;
                default:
                    ctrl.BackColor = Color.Orange;
                    break;
            }
        }

        private int _value; //kifejtett property _ privát változó
        
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                this.Text = _value.ToString();
            }
        }
    }
}
