﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Framework;

namespace FootballClubMS.Applications
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtId.ToString()))
            {

            }
            else
            {
                MessageBox.Show("Insert Id");
            }
        }
    }
}
