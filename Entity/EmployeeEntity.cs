using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using FootballClubMS.Repository;

namespace FootballClubMS.Entity
{
    public class EmployeeEntity
    {
        private string id;
        private string name;
        private string designation;
        private string email;
        private double  salary;
        
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Designation
        {
            get { return this.designation; }
            set { this.designation = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public EmployeeEntity(string name, string designation, string email, double salary)
        {
            this.Name = name;
            this.Designation = designation;
            if (Designation.ToLower() == "admin")
            {
                int temp = EmployeeRepository.GetValueForEmployeeId() + 1;
                this.Id = "a-" + temp; 
            }
            else if (Designation.ToLower() == "manager")
            {
                int temp = EmployeeRepository.GetValueForEmployeeId() + 1;
                this.Id = "m-" + temp;

            }

            else if (Designation.ToLower() == "seller")
            {
                int temp = EmployeeRepository.GetValueForEmployeeId() + 1;
                this.Id = "s-" + temp;

            }
            else
            {
                {
                    int temp = EmployeeRepository.GetValueForEmployeeId() + 1;
                    this.Id = "e-" + temp;

                }
            }

            this.Email = email;
            this.Salary = salary;           
        }

        public EmployeeEntity(DataSet employee)
        {
            try
            {
                this.Id = employee.Tables[0].Rows[0][0].ToString();
                this.Name = employee.Tables[0].Rows[0][1].ToString();
                this.Designation = employee.Tables[0].Rows[0][2].ToString();
                this.Email = employee.Tables[0].Rows[0][3].ToString();
                string s = employee.Tables[0].Rows[0][4].ToString();
                this.Salary = Convert.ToDouble(s);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not get Employee informatin");
               
            }
        }
        public EmployeeEntity(DataSet employee,string email,double salary)
        {
            try
            {
                this.Id = employee.Tables[0].Rows[0][0].ToString();
                this.Name = employee.Tables[0].Rows[0][1].ToString();
                this.Designation = employee.Tables[0].Rows[0][2].ToString();
                this.Email = email;
                this.Salary = salary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get Employee informatin");

            }
        }
    }
}
