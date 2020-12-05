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


        //public int Value { get; set; }

        private int _value; //propfull tab tab -- > kifejtett property
        //(a privát változók nevét szokás egy alulvonással kezdeni, hogy elkülönüljenek a metódusokon belül létrehozott változóktól)
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;

                this.Text = _value.ToString();
                
            }
            //get { return Value; }
            //set { Value = value; }
        }


        /*
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
        }*/
    }
}
