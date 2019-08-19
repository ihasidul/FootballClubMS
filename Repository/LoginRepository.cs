using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using FootballClubMS.Entity;
using FootballClubMS.Data;

namespace FootballClubMS.Repository
{
    public class LoginRepository
    {
        private static DataSet Ds { get; set; }

        public static DataSet GetSpecificUser(LoginEntity l)
        {
            string sql = "select * from login where id = '" + l.Id + "' and password = '" + l.Password + "';";
            
            if (Ds.Tables[0].Rows.Count == 1)
            {
                return DataAccess.GetDataSet(sql);
            }
            else
            {
                return null;
            }
        }

  

        public static void InsertUser(string id,string passworrd)
        {

            try
            {
                {
                    string sql = "insert into login (id,password) values ('" + id + "','" + passworrd + "');";
                    DataAccess.ExecuteQuery(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong in Login. Error: " + ex.Message);
            }
        }
        public static bool SearchUser(LoginEntity l)
        {
            string sql = "select * from login where id = '"+ l.Id +"' and password = '"+ l.Password +"';";
            Ds = DataAccess.GetDataSet(sql);
            if (Ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UpdateUserPassword(LoginEntity l, string newpass)
        {
            try
            {
                {

                    string sql = "UPDATE login SET id = '" + l.Id + "',  password = '" + newpass+ "' WHERE id = '" + l.Id + "'; ";
                    DataAccess.ExecuteQuery(sql);

                }
            }
            catch (Exception ex)
            {
                
            }

        }

    }
}
