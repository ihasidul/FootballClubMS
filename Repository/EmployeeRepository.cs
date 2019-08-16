using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Data;

namespace FootballClubMS.Repository
{
    class EmployeeRepository
    {
        private static DataSet Ds { get; set; }
        public static int GetValueForEmployeeId()
        {
            try
            {
                string sql = "select autoid from employee where autoid = (select max(autoid) from employee);";
                Ds = DataAccess.ExecuteQuery(sql);
                string id = Ds.Tables[0].Rows[0][0].ToString();
                
                return Convert.ToInt32(id) + 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }   
    }
}
