using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Entity;
using FootballClubMS.Repository;
using FootballClubMS.Framework;
namespace FootballClubMS.Applications
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        public Login l;
        private DataSet Ds { get; set; }
        private EmployeeEntity ea;
        public Admin(Login l,string id)
        {
            InitializeComponent();
            this.l = l;
            this.Ds = EmployeeRepository.GetSpecificEmployee(id);
            this.ea = new EmployeeEntity(Ds);
            this.txtAdminId.Text = ea.Id;
            this.txtAdminName.Text = ea.Name;
            this.txtAdminEmail.Text = ea.Email;
            this.txtAdminSalary.Text = ea.Salary.ToString();

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {

             try
             {
                
                if (Validation.IsStringValid(this.txtOldPassword.ToString()) == true && Validation.IsStringValid(this.txtNewPassword.ToString()) == true)
                 {


                    LoginEntity le = new LoginEntity(this.ea.Id, this.txtOldPassword.Text.ToString());
                    bool check = LoginRepository.SearchUser(le);
                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        LoginRepository.UpdateUserPassword(le, this.txtNewPassword.Text.ToString());
                        MessageBox.Show("Password updated");

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
    }
}
