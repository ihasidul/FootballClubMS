using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using FootballClubMS.Applications;
using FootballClubMS.Entity;
using FootballClubMS.Data;

namespace FootballClubMS.Repository
{
    class PlayerRepository
    {
        private static DataSet Ds { get; set; }
    
        public static int GetValueForPlayerId()
        {
            try
            {
                string sql = "select autoid from player where autoid = (select max(autoid) from player);";
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
