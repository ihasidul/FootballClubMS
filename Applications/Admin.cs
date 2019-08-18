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
            PopulateGridviewForEmployee();

        }

        public void PopulateGridviewForEmployee()
        {
            this.dgvEmployee.AutoGenerateColumns = false;
            this.Ds = EmployeeRepository.GetAllEmployee();
            this.dgvEmployee.DataSource = this.Ds.Tables[0];

        }

        public void PopulateGridviewForEmployeeSearched()
        {
            this.dgvEmployee.AutoGenerateColumns = false;
            this.Ds = EmployeeRepository.SearchEmployee(this.txtEmpSearch.Text);//don't bring this.txtEmpSearch.Text as a string from other method.
            this.dgvEmployee.DataSource = this.Ds.Tables[0];
            

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
                    bool check = LoginRepository.SearchUser(le);//this will say if the id is in the login table or not
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

        private void BtnEmpSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsStringValid(this.txtEmpName.ToString()) == true && Validation.IsStringValid(this.txtEmpDesignation.ToString()) == true &&
                    Validation.IsStringValid(this.txtEmpEmail.ToString()) == true && Validation.IsStringValid(this.txtEmpSalary.ToString()) == true)
                {

                    double salary = Convert.ToDouble(this.txtEmpSalary.Text.ToString());
                    EmployeeEntity te = new EmployeeEntity(this.txtEmpName.Text, this.txtEmpDesignation.Text, this.txtEmpEmail.Text, salary);
                    EmployeeRepository.InsertEmployee(te);
                    Random rnd = new Random();
                    string password = rnd.Next(100, 999).ToString();
                    LoginRepository.InsertUser(te.Id, password);
                    MessageBox.Show("Your ID is " + te.Id + " and Password is " + password);
                    PopulateGridviewForEmployee();
                }
                else
                {
                    MessageBox.Show("Please Insert all information.");
                }
               
            }
            catch
            {
                MessageBox.Show("Problem in insertion");
            }


        }

        private void TxtEmpSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateGridviewForEmployeeSearched();
        }

        private void DgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEmpSignUp.Enabled = false;
            this.btnEmployeeDelete.Enabled = true;
            this.txtEmpName.Text = this.dgvEmployee.CurrentRow.Cells["emp_name"].Value.ToString(); 
            this.txtEmpDesignation.Text = this.dgvEmployee.CurrentRow.Cells["designation"].Value.ToString();
            this.txtEmpEmail.Text = this.dgvEmployee.CurrentRow.Cells["emp_email"].Value.ToString();
            this.txtEmpSalary.Text = this.dgvEmployee.CurrentRow.Cells["salary"].Value.ToString();
        }

        private void BtnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvEmployee.CurrentRow.Cells["designation"].Value.ToString() == "admin" || this.dgvEmployee.CurrentRow.Cells["designation"].Value.ToString() == "Admin")
            {
                MessageBox.Show("Admin can not delete himself.");
                PopulateGridviewForEmployee();
                this.btnEmployeeDelete.Enabled = false;
                this.txtEmpName.Text = "";
                this.txtEmpDesignation.Text = "";
                this.txtEmpEmail.Text = "";
                this.txtEmpSalary.Text = "";
                this.btnEmpSignUp.Enabled = true;
            }
            else
            {
                EmployeeRepository.DeleteEmployee(this.dgvEmployee.CurrentRow.Cells["emp_id"].Value.ToString());
                PopulateGridviewForEmployee();
                this.btnEmployeeDelete.Enabled = false;
                this.txtEmpName.Text = "";
                this.txtEmpDesignation.Text = "";
                this.txtEmpEmail.Text = "";
                this.txtEmpSalary.Text = "";
                this.btnEmpSignUp.Enabled = true;
            }
            
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.btnEmployeeDelete.Enabled = false;
            this.txtEmpName.Text = "";
            this.txtEmpDesignation.Text = "";
            this.txtEmpEmail.Text = "";
            this.txtEmpSalary.Text = "";
            this.btnEmpSignUp.Enabled = true;
        }

       
    }
}
