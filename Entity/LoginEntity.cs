using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace FootballClubMS.Entity
{
    public class LoginEntity
    {
        private string id;
        private string password;

        public  string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public LoginEntity(string id, string password)
        {
            this.Id = id;
            this.Password = password;
        }
        public LoginEntity(DataSet data)
        {
            try
            {
                this.Id = data.Tables[0].Rows[0][0].ToString();
                this.Password = data.Tables[0].Rows[0][1].ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is wrong.");
                MessageBox.Show(ex.Message);
            }
        }

    }
}
