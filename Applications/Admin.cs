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
                Ds = LoginRepository.
                if(this.txtOldPassword.Text == Ds.Tables[0].Rows["id"])

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
    }
}
