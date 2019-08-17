using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FootballClubMS.Data
{
    class DataAccess
    {
        private static SqlConnection sqcon;

        public static SqlConnection Sqcon
        {
            get
            {
                try
                {
                    if (sqcon == null)
                    {
                        sqcon = new SqlConnection(@"Data Source=DESKTOP-QLIANTH;Initial Catalog=footballclub;Integrated Security=True");
                    }
                    else if (sqcon.State != ConnectionState.Open)
                    {
                        sqcon.Open();
                    }
                    return sqcon;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static DataSet GetDataSet(string query)
        {
            try
            {
                SqlCommand sqcom = new SqlCommand(query, Sqcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable GetDataTable(string query)
        {
            try
            {
                var ds = GetDataSet(query);
                if (ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlCommand sqcom = new SqlCommand(query, Sqcon);
                return sqcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
