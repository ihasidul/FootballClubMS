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
    public partial class Employee : MetroFramework.Forms.MetroForm
    {
        private Login l;
        public Employee(Login l, string id)
        {
            InitializeComponent();
            this.l = l;
        }
    }
}
