using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FootballClubMS.Data
{
    class DataAccess
    {
        private static SqlConnection sqlcon;
        public static SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private  static SqlCommand sqlcom;
        public static SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private static SqlDataAdapter sda;
        public static SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private static DataSet ds;
        public static DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            //this.sqcon = new SqlConnection(WFAExer.Properties.Settings.Default.conStr);
            //this.Sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True");
            //this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-HASIB;Initial Catalog=mydb;Integrated Security=True");
            DataAccess.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-QLIANTH;Initial Catalog=footballclub;Integrated Security=True");
            Sqlcon.Open();
        }

        private static  void QueryText(string query)
        {
            DataAccess.Sqlcom = new SqlCommand(query, DataAccess.Sqlcon);
        }

        public static DataSet ExecuteQuery(string sql)
        {
            DataAccess.QueryText(sql);
            DataAccess.Sda = new SqlDataAdapter(DataAccess.Sqlcom);
            DataAccess.Ds = new DataSet();
            DataAccess.Sda.Fill(DataAccess.Ds);
            return DataAccess.Ds;
        }

        public static int ExecuteUpdateQuery(string sql)
        {
            DataAccess.QueryText(sql);
            int u = DataAccess.Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
