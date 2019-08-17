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

namespace FootballClubMS.Applications
{
    public partial class Manager : MetroFramework.Forms.MetroForm
    {
        private Login l;
        private DataSet Ds { get; set; }
        private EmployeeEntity ea;
        public Manager(Login l,string id)
        {
            InitializeComponent();
            this.l = l;
            this.Ds = EmployeeRepository.GetSpecificEmployee(id);
            this.ea = new EmployeeEntity(Ds);
            this.txtManagerId.Text = ea.Id;
            this.txtManagerName.Text = ea.Name;
            this.txtManagerEmail.Text = ea.Email;
            this.txtManagerSalary.Text = ea.Salary.ToString();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
