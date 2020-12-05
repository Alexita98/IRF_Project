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
        public CinemaHall()
        {
            this.Height = 30;
            this.Width = 30;
            this.BackColor = Color.Green;
            this.MouseDown += CinemaHall_MouseDown;
        }

        private void CinemaHall_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Orange;
            }
            if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.Green;
            }*/

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

        private bool _active;

        public bool Active
        {
            get { return _active; }
            set
            {
                _active = value;
                if (_active == false)
                {
                    
                }
                else
                {
                    
                }
            }
        }
    }
}
