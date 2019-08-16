using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FootballClubMS.Applications;
using FootballClubMS.Data;
using System.Windows.Forms;

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
            if (Designation.ToLower().Equals("admin"))
            {
                int tempid = UserRepository.GetTotalUsers() + 1;
                this.ID = "a-" + tempid.ToString().PadLeft(6, '0') + "-1";
            }
            else if (Designation.ToLower().Equals("manager"))
            {
                int tempid = UserRepository.GetTotalUsers() + 1;
                this.ID = "m-" + tempid.ToString().PadLeft(6, '0') + "-2";
            }
            
            else if (Designation.ToLower().Equals("seller"))
            {
                int tempid = UserRepository.GetTotalUsers() + 1;
                this.ID = "s-" + tempid.ToString().PadLeft(6, '0') + "-4";
            }
            this.Email = email;
            
        }
    }
}
