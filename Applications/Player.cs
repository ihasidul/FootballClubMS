using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Data;
using FootballClubMS.Repository;
using FootballClubMS.Entity;
using FootballClubMS.Framework;


namespace FootballClubMS.Applications
{
    public partial class Player : MetroFramework.Forms.MetroForm
    {
        private Login l;
        private DataSet Ds { get; set; }
        private PlayerEntity pe;
        public Player(Login l, string id)
        {
            InitializeComponent();
            this.l = l;
            this.Ds = PlayerRepository.GetSpecificPlayer(id);
            this.pe = new PlayerEntity(Ds);
            this.lblPlayerId.Text = pe.Id;
            this.lblPlayerName.Text = pe.Name;
            this.lblPlayerEmail.Text = pe.Email;
            this.lblPlayerPositon.Text = pe.Position;
            this.lblPlayerValidity.Text = pe.ValidationDate.ToString();
            this.lblPlayerFee.Text = pe.WeeklyFee.ToString();

        }

        private void Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validation.IsStringValid(this.txtOldPassword.Text) == true && Validation.IsStringValid(this.txtNewPassword.Text) == true)
                {


                    LoginEntity le = new LoginEntity(this.pe.Id, this.txtOldPassword.Text.ToString());
                    bool check = LoginRepository.SearchUser(le);
                    if (check)
                    {
                        LoginRepository.UpdateUserPassword(le, this.txtNewPassword.Text.ToString());
                        MessageBox.Show("Password updated");
                        this.txtOldPassword.Text = "";
                        this.txtNewPassword.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Insert Correct password");
                    }
                }
                else
                {
                    MessageBox.Show("Insert Password");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            l.Visible = true;
        }
    }
}
