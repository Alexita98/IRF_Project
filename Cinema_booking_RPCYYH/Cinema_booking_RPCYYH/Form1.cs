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

            
        }

    }
}
