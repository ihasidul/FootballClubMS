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
            PopulateGridviewForPlayer();

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
        public void PopulateGridviewForPlayer()
        {
            this.dgvPlayer.AutoGenerateColumns = false;
            this.Ds = PlayerRepository.GetAllPlayers();
            this.dgvPlayer.DataSource = this.Ds.Tables[0];

        }
        public void PopulateGridviewForPlayerSearched()
        {
            this.dgvPlayer.AutoGenerateColumns = false;
            this.Ds = PlayerRepository.SearchPlayer(this.txtPlayerSearch.Text);//don't bring this.txtEmpSearch.Text as a string from other method.
            this.dgvPlayer.DataSource = this.Ds.Tables[0];


        }



        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)//this is passwordchange button for Admin
        {

             try
             {
                
                if (Validation.IsStringValid(this.txtOldPassword.Text) == true && Validation.IsStringValid(this.txtNewPassword.Text) == true)
                {


                    LoginEntity le = new LoginEntity(this.ea.Id, this.txtOldPassword.Text.ToString());
                    bool check = LoginRepository.SearchUser(le);//this will say if the id is in the login table or not

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

        private void BtnEmpSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsStringValid(this.txtEmpName.Text) == true && Validation.IsStringValid(this.txtEmpDesignation.Text) == true &&
                    Validation.IsStringValid(this.txtEmpEmail.Text) == true && Validation.IsStringValid(this.txtEmpSalary.Text.ToString()) == true)
                { 
                    if(Validation.IsStringAName(this.txtEmpName.Text) == true && Validation.IsStringAName(this.txtEmpDesignation.Text) == true &&
                    Validation.IsStringMail(this.txtEmpEmail.Text) == true && Validation.IsStringNumber(this.txtEmpSalary.Text.ToString()) == true)
                    {
                        double salary = Convert.ToDouble(this.txtEmpSalary.Text.ToString());
                        EmployeeEntity te = new EmployeeEntity(this.txtEmpName.Text, this.txtEmpDesignation.Text, this.txtEmpEmail.Text, salary);
                        EmployeeRepository.InsertEmployee(te);
                        Random rnd = new Random();
                        string password = rnd.Next(100, 999).ToString();
                        LoginRepository.InsertUser(te.Id, password);
                        MessageBox.Show("Your ID is " + te.Id + " and Password is " + password);
                        PopulateGridviewForEmployee();
                        this.txtEmpName.Text = "";
                        this.txtEmpDesignation.Text = "";
                        this.txtEmpEmail.Text = "";
                        this.txtEmpSalary.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Please Insert Proper Values");
                    }
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
            this.btnEmpUpdate.Enabled = true;
            this.txtEmpName.Text = this.dgvEmployee.CurrentRow.Cells["emp_name"].Value.ToString(); 
            this.txtEmpDesignation.Text = this.dgvEmployee.CurrentRow.Cells["designation"].Value.ToString();
            this.txtEmpEmail.Text = this.dgvEmployee.CurrentRow.Cells["emp_email"].Value.ToString();
            this.txtEmpSalary.Text = this.dgvEmployee.CurrentRow.Cells["salary"].Value.ToString();

            this.txtEmpName.ReadOnly = true;
            this.txtEmpDesignation.ReadOnly = true;
        }

        private void BtnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvEmployee.CurrentRow.Cells["designation"].Value.ToString() == "admin" || this.dgvEmployee.CurrentRow.Cells["designation"].Value.ToString() == "Admin")
            {
                MessageBox.Show("Admin can not delete himself.");
                PopulateGridviewForEmployee();
                this.btnEmployeeDelete.Enabled = false;
                this.btnEmpUpdate.Enabled = false;
                this.txtEmpName.Text = "";
                this.txtEmpDesignation.Text = "";
                this.txtEmpEmail.Text = "";
                this.txtEmpSalary.Text = "";
                this.btnEmpSignUp.Enabled = true;
                this.txtEmpName.ReadOnly = false;
                this.txtEmpDesignation.ReadOnly = false;
            }
            else
            {
                EmployeeRepository.DeleteEmployee(this.dgvEmployee.CurrentRow.Cells["emp_id"].Value.ToString());
                PopulateGridviewForEmployee();
                this.btnEmployeeDelete.Enabled = false;
                this.btnEmpUpdate.Enabled = false;
                this.txtEmpName.Text = "";
                this.txtEmpDesignation.Text = "";
                this.txtEmpEmail.Text = "";
                this.txtEmpSalary.Text = "";
                this.btnEmpSignUp.Enabled = true;
                this.txtEmpName.ReadOnly = false;
                this.txtEmpDesignation.ReadOnly = false;
            }
            
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.btnEmployeeDelete.Enabled = false;
            this.btnEmpUpdate.Enabled = false;
            this.txtEmpName.ReadOnly = false;
            this.txtEmpDesignation.ReadOnly = false;
            this.txtEmpName.Text = "";
            this.txtEmpDesignation.Text = "";
            this.txtEmpEmail.Text = "";
            this.txtEmpSalary.Text = "";
            this.btnEmpSignUp.Enabled = true;
        }

        private void TxtPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateGridviewForPlayerSearched();
        }

        private void BtnPlayerDelete_Click(object sender, EventArgs e)
        {
            
            
            PlayerRepository.DeletePlayer(this.dgvPlayer.CurrentRow.Cells["player_id"].Value.ToString());
            PopulateGridviewForPlayer();
            this.btnPlayerDelete.Enabled = false;
            this.btnPlayerUpdate.Enabled = false;
            this.txtPlayerName.Text = "";
            this.cmbPlayerPosition.Text = "";
            this.txtPlayerEmail.Text = "";
            this.txtPlayerFee.Text = "";
            this.dtpPlayerValidation.ResetText();
            this.btnPlayerSignUp.Enabled = true;
            //make the text box enable
            this.txtPlayerName.ReadOnly = false;
            this.cmbPlayerPosition.Enabled = true;
            

        }

        private void BtnPlayerSignUp_Click(object sender, EventArgs e)//Sign up for player
        {
            try
            {
                if (Validation.IsStringValid(this.txtPlayerName.Text) == true  && this.cmbPlayerPosition.SelectedItem != null &&
                    Validation.IsStringValid(this.txtPlayerEmail.Text) == true && Validation.IsStringValid(this.txtPlayerFee.Text) == true)
                {
                    if (Validation.IsStringMail(this.txtPlayerEmail.Text) == true && Validation.IsStringAName(this.txtPlayerName.Text) == true &&
                        Validation.IsStringNumber(this.txtPlayerFee.Text) == true)

                    {
                        double weeklyFee = Convert.ToDouble(this.txtPlayerFee.Text.ToString());
                        DateTime dt = Convert.ToDateTime(dtpPlayerValidation.Text);
                        PlayerEntity pe = new PlayerEntity(this.txtPlayerName.Text, this.cmbPlayerPosition.Text, this.txtPlayerEmail.Text, dt, weeklyFee);
                        PlayerRepository.InsertPlayer(pe);
                        Random rnd = new Random();
                        string password = rnd.Next(100, 999).ToString();
                        LoginRepository.InsertUser(pe.Id, password);
                        MessageBox.Show("Your ID is " + pe.Id + " and Password is " + password);
                        PopulateGridviewForPlayer();
                        this.txtPlayerName.Text = "";
                        this.cmbPlayerPosition.Text = "";
                        this.txtPlayerEmail.Text = "";
                        this.txtPlayerFee.Text = "";
                        this.dtpPlayerValidation.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Please,Insert Correct Values");
                    }

                    

                    //Validation.IsTheStringNumber(this.txtEmpName.ToString()) == true && Validation.IsTheStringNumber(this.txtEmpDesignation.ToString()) == true &&
                    //Validation.IsTheStringNumber(this.txtEmpEmail.ToString()) == true

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

        private void Admin_Load(object sender, EventArgs e)
        {
            // Set the Format type and the CustomFormat string.
            dtpPlayerValidation.Format = DateTimePickerFormat.Custom;
            dtpPlayerValidation.CustomFormat = "yyyy-MM-dd";
            dtpPlayerValidation.MinDate = DateTime.Today;
        }

        private void DgvPlayer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnPlayerSignUp.Enabled = false;
            this.btnPlayerUpdate.Enabled = true;
            this.btnPlayerDelete.Enabled = true;
            this.txtPlayerName.Text = this.dgvPlayer.CurrentRow.Cells["player_name"].Value.ToString();
            this.cmbPlayerPosition.Text = this.dgvPlayer.CurrentRow.Cells["position"].Value.ToString();
            this.txtPlayerEmail.Text = this.dgvPlayer.CurrentRow.Cells["player_email"].Value.ToString();
            this.txtPlayerFee.Text = this.dgvPlayer.CurrentRow.Cells["weekly_fee"].Value.ToString();
            this.dtpPlayerValidation.Text = this.dgvPlayer.CurrentRow.Cells["validation_date"].Value.ToString();
            //this will make text boxes readonly and disable
            this.txtPlayerName.ReadOnly = true;
            this.cmbPlayerPosition.Enabled = false;
        }

        private void BtnPlayerCancel_Click(object sender, EventArgs e)
        {
            this.btnPlayerDelete.Enabled = false;
            this.btnPlayerUpdate.Enabled = false;
            this.btnPlayerSignUp.Enabled = true;
            this.txtPlayerName.Text = "";
            this.cmbPlayerPosition.Text = "";
            this.txtPlayerEmail.Text = "";
            this.txtPlayerFee.Text = "";
            this.dtpPlayerValidation.ResetText();
            //make the text box enable
            this.txtPlayerName.ReadOnly = false;
            this.cmbPlayerPosition.Enabled = true;
            
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            l.Visible = true;
        }

        private void BtnPlayerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsStringValid(this.txtPlayerName.Text) == true && this.cmbPlayerPosition.SelectedItem != null &&
                    Validation.IsStringValid(this.txtPlayerEmail.Text) == true && Validation.IsStringValid(this.txtPlayerFee.Text) == true)
                {
                    if (Validation.IsStringMail(this.txtPlayerEmail.Text) == true && Validation.IsStringAName(this.txtPlayerName.Text) == true &&
                        Validation.IsStringNumber(this.txtPlayerFee.Text) == true)

                    {
                        try
                        {
                            double weeklyFee = Convert.ToDouble(this.txtPlayerFee.Text.ToString());
                            DateTime dt = Convert.ToDateTime(dtpPlayerValidation.Text);
                            this.Ds = PlayerRepository.GetSpecificPlayer(this.dgvPlayer.CurrentRow.Cells["player_id"].Value.ToString());
                            PlayerEntity pe = new PlayerEntity(Ds,this.txtPlayerEmail.Text,Convert.ToDouble(this.txtPlayerFee.Text),dt);
                            PlayerRepository.UpdatePlayer(pe);
                            PopulateGridviewForPlayer();
                            this.txtPlayerName.Text = "";
                            this.cmbPlayerPosition.Text = "";
                            this.txtPlayerEmail.Text = "";
                            this.txtPlayerFee.Text = "";
                            this.dtpPlayerValidation.ResetText();

                            //make the text box enable
                            this.txtPlayerName.ReadOnly = false;
                            this.cmbPlayerPosition.Enabled = true;
                            this.btnPlayerUpdate.Enabled = false;
                            this.btnPlayerDelete.Enabled = false;
                            this.btnPlayerSignUp.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Problem in insertion");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please,Insert Correct Values");
                    }
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

        private void BtnEmpUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsStringValid(this.txtEmpName.Text) == true && Validation.IsStringValid(this.txtEmpDesignation.Text) == true &&
                    Validation.IsStringValid(this.txtEmpEmail.Text) == true && Validation.IsStringValid(this.txtEmpSalary.Text.ToString()) == true)
                {
                    if (Validation.IsStringAName(this.txtEmpName.Text) == true && Validation.IsStringAName(this.txtEmpDesignation.Text) == true &&
                    Validation.IsStringMail(this.txtEmpEmail.Text) == true && Validation.IsStringNumber(this.txtEmpSalary.Text.ToString()) == true)
                    {

                        try
                        {
                            double salary = Convert.ToDouble(this.txtEmpSalary.Text.ToString());

                            this.Ds = EmployeeRepository.GetSpecificEmployee(this.dgvEmployee.CurrentRow.Cells["emp_id"].Value.ToString());
                            EmployeeEntity te = new EmployeeEntity(Ds, this.txtEmpEmail.Text, Convert.ToDouble(this.txtEmpSalary.Text));
                            EmployeeRepository.UpdateEmployee(te);
                            PopulateGridviewForEmployee();
                            this.txtEmpName.ReadOnly = false;
                            this.txtEmpDesignation.ReadOnly = false;
                            this.txtEmpName.Text = "";
                            this.txtEmpDesignation.Text = "";
                            this.txtEmpEmail.Text = "";
                            this.txtEmpSalary.Text = "";
                            this.btnEmpUpdate.Enabled = false;
                            this.btnEmployeeDelete.Enabled = false;
                            this.btnEmpSignUp.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Insert Proper Values");
                    }
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
    }
}
