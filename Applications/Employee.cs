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
    public partial class Employee : MetroFramework.Forms.MetroForm
    {

        private DataSet Ds { get; set; }
        
        public Login l;
        private EmployeeEntity em;
        public Employee(Login l, string id)
        {
            InitializeComponent();
            this.l = l;
            this.Ds = EmployeeRepository.GetSpecificEmployee(id);
            this.em = new EmployeeEntity(Ds);
            this.lblEmployeeId.Text = em.Id;
            this.lblEmployeeName.Text = em.Name;
            this.lblEmployeeEmail.Text = em.Email;
            this.lblEmployeeDesignaiton.Text = em.Designation;
            this.lblEmployeeSalary.Text = em.Salary.ToString();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validation.IsStringValid(this.txtOldPassword.Text) == true && Validation.IsStringValid(this.txtNewPassword.Text) == true)
                {


                    LoginEntity le = new LoginEntity(this.em.Id, this.txtOldPassword.Text.ToString());
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
