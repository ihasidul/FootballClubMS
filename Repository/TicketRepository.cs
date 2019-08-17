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
    class TicketRepository
    {
        private static DataSet Ds { get; set; }

        public static int GetValueForTicketId()
        {
            try
            {
                string sql = "select autoid from ticket where autoid = (select max(autoid) from ticket);";
                Ds = DataAccess.GetDataSet(sql);
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
