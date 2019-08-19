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
    public partial class TicketSeller : MetroFramework.Forms.MetroForm
    {
        private Login l;
        private DataSet Ds { get; set; }
        
        private EmployeeEntity em;
      
        public TicketSeller(Login l, string id)
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
            PopulateGridViewShowAllTicketInfo();
            
        }

        private void TicketSeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
                
        }

        public double PriceCalculator()
        {
            try
            {
                double price = Convert.ToDouble(this.txtPricePerTicket.Text);
                int quantity = Convert.ToInt32(this.cmbTicketQuantity.Text);
                double totalPrice = price * quantity;

                if (this.cmbFanStatus.Text == "Fan")
                {
                    totalPrice -= totalPrice * 0.2;
                    return totalPrice;
                }
                else
                    return totalPrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Integer value as Price");
                return 0;
            }
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

        private void BtnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsStringAName(this.txtCustomerName.Text) == true && Validation.IsStringMail(this.txtCustomerEmail.Text) == true &&
                   this.cmbTicketQuantity.SelectedItem != null && this.cmbCustomerType.SelectedItem != null && this.cmbFanStatus != null) 
                {
                    bool fanStatus = false;
                    if (this.cmbFanStatus.Text == "Fan")
                    {
                        fanStatus = true;
                    }
                    else
                    {

                    }

                    if ((this.cmbCustomerType.Text == "New") && (this.cmbFanStatus.Text == "Not Fan"))
                    {

                        try
                        {

                            if (Validation.IsStringValid(this.txtCustomerName.Text) == true && Validation.IsStringValid(this.txtCustomerEmail.Text) == true)
                            {

                                CustomerEntity ce = new CustomerEntity(this.txtCustomerName.Text, this.txtCustomerEmail.Text, fanStatus);
                                CustomerRepository.InsertCustomer(ce);
                                MessageBox.Show("Your ID is " + ce.Id + " ");
                                double price = PriceCalculator();
                                TicketEntity tik3 = new TicketEntity(ce.Id, price);
                                TicketRepository.InsertTicket(tik3);
                                this.txtTotalPrice.Text = price.ToString();
                                this.txtCustomerEmail.Text = "";
                                this.txtCustomerId.Text = "";
                                this.txtCustomerName.Text = "";
                                this.txtPricePerTicket.Text = "";
                                PopulateGridViewShowAllTicketInfo();
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
                    else if ((this.cmbCustomerType.Text == "New") && (this.cmbFanStatus.Text == "Fan"))
                    {
                        try
                        {
                            if (Validation.IsStringValid(this.txtCustomerName.ToString()) == true && Validation.IsStringValid(this.txtCustomerEmail.ToString()) == true)
                            {

                                CustomerEntity ce = new CustomerEntity(this.txtCustomerName.Text, this.txtCustomerEmail.Text, fanStatus);
                                CustomerRepository.InsertCustomer(ce);
                                MessageBox.Show("Your ID is " + ce.Id + " ");
                                double price = PriceCalculator() + 100;
                                TicketEntity tik2 = new TicketEntity(ce.Id, price);
                                TicketRepository.InsertTicket(tik2);
                                this.txtTotalPrice.Text = price.ToString();
                                PopulateGridViewShowAllTicketInfo();
                                this.txtCustomerEmail.Text = "";
                                this.txtCustomerId.Text = "";
                                this.txtCustomerName.Text = "";
                                this.txtPricePerTicket.Text = "";

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
                    else if (this.cmbCustomerType.Text == "Existing")
                    {
                        this.btnGet.Enabled = true;
                        double price = PriceCalculator();
                        this.txtTotalPrice.Text = price.ToString();

                        TicketEntity tik = new TicketEntity(this.txtCustomerId.Text, price);
                        TicketRepository.InsertTicket(tik);

                        PopulateGridViewShowAllTicketInfo();
                        this.txtCustomerEmail.Text = "";
                        this.txtCustomerId.Text = "";
                        this.txtCustomerName.Text = "";
                        this.txtPricePerTicket.Text = "";
                        this.cmbFanStatus.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Please Insert All the values");
                    }
                    this.cmbFanStatus.Enabled = true;


                    PopulateGridViewShowAllTicketInfo();
                }
                else
                {
                    MessageBox.Show("Please insert valid values");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        /*public void PopulateGridViewTicketInfo()
        {
            try
            {
                this.Ds = TicketRepository.GetTicketInfo(this.txtCustomerId.Text, txtTotalPrice.Text);
                this.dgvTicketInfo.AutoGenerateColumns = false;
                this.dgvTicketInfo.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        public void PopulateGridViewShowAllTicketInfo()
        {
            try
            {
                this.Ds = TicketRepository.GetAllTicketInfo();//gets all data from ticket table
                this.dgvTicketInfo.AutoGenerateColumns = false;
                this.dgvTicketInfo.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            try
            {
                string s = this.txtCustomerId.Text;
                this.Ds = TicketRepository.GetCustomerInfo(s);

                string s1 = Ds.Tables[0].Rows[0]["Customer_name"].ToString();
                string s2 = Ds.Tables[0].Rows[0]["Customer_email"].ToString();
                string s3 = Ds.Tables[0].Rows[0]["Fan"].ToString();

                this.txtCustomerName.Text = s1;
                this.txtCustomerEmail.Text = s2;

                if (s3 == "True")
                {
                    this.cmbFanStatus.Text = "Fan";
                }
                else if (s3 == "False")
                {
                    this.cmbFanStatus.Text = "Not Fan";
                }
                else
                {

                }

                this.cmbFanStatus.Enabled = false;
                this.txtCustomerName.ReadOnly = true;
                this.txtCustomerEmail.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCustomerType.Text == "New")
            {
                this.txtCustomerId.ReadOnly = true;
                this.cmbFanStatus.Enabled = true;
                this.txtCustomerName.ReadOnly = false;
                this.txtCustomerEmail.ReadOnly = false;
                this.btnGet.Enabled = false;

            }
            else if (this.cmbCustomerType.Text == "Existing")
            {
                this.txtCustomerId.ReadOnly = false;
                this.btnGet.Enabled = true;
            }
            else
            {
                MessageBox.Show("Problem in Cusotmer type combobox");
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            l.Visible = true;
        }

        private void BtnLogOut2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            l.Visible = true;
        }
    }
}
