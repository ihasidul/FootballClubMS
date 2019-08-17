using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Framework;
using FootballClubMS.Entity;
using System.Data;
using FootballClubMS.Data;

namespace FootballClubMS.Applications
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private  DataSet Ds { get; set; }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtId.ToString()))
            {
                LoginEntity le = new LoginEntity(this.txtId.Text.ToString(), this.txtPassword.Text.ToString());
                string sql = "select * from login where id ='"+le.Id+"'and password = '"+le.Password+"';";
                
                this.Ds = DataAccess.GetDataSet(sql);
                
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    
                    string[] words = this.txtId.Text.Split('-');
                    MessageBox.Show( words[0].ToString());
                    if (words[0] == "a")//He is an Admin
                    {
                        this.Visible = false;
                        Admin a = new Admin(this);
                        a.Visible = true;
                    }
                    else if(words[0] == "m")//He is a manager
                    {
                        this.Visible = false;
                        Manager m = new Manager(this);
                        m.Visible = true;
                    }
                    else if(words[0] == "s")//He is ticketSeller
                    {
                        this.Visible = false;
                        TicketSeller a = new TicketSeller(this);
                        a.Visible = true;
                    }
                    else if (words[0] == "e")//He is ticketSeller
                    {
                        this.Visible = false;
                        Employee a = new Employee(this);
                        a.Visible = true;
                    }
                    else if(words[0] == "p")//he is a Player
                    {
                        this.Visible = false;
                        Player a = new Player(this);
                        a.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Insert Correct id and password" + Ds.Tables[0].Rows.Count);

                }
            }
            else
            {
                MessageBox.Show("Insert Id");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
