﻿using System;
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
    public partial class Manager : MetroFramework.Forms.MetroForm
    {
        private Login l;
        public Manager(Login l,string id)
        {
            InitializeComponent();
            this.l = l;
        }

     
    }
}
