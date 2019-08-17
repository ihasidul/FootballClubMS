using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballClubMS.Applications
{
    public partial class TicketSeller : MetroFramework.Forms.MetroForm
    {
        private Login l;
        public TicketSeller(Login l)
        {
            InitializeComponent();
            this.l = l;
        }

     
    }
}
