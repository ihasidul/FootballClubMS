using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FootballClubMS.Entity;
using FootballClubMS.Data;

namespace FootballClubMS.Repository
{
    class LoginRepository
    {
        private static DataSet Ds { get; set; }

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
           
    }
}
