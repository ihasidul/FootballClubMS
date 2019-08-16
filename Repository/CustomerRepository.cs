using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using FootballClubMS.Data;

namespace FootballClubMS.Repository
{
    class CustomerRepository
    {
        private static DataSet Ds { get; set; }

        public static int GetValueForCustomerId()
        {
            try
            {
                string sql = "select autoid from customer where autoid = (select max(autoid) from customer);";
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
