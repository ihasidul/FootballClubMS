using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using FootballClubMS.Data;
using FootballClubMS.Entity;

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
        //get customer info
        public static DataSet GetCustomerInfo(string id)
        {
            try
            {
                string sql = "select customer_name,customer_email,fan from customer where customer_id = '" + id + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        //get Ticket Info

        public static DataSet GetTicketInfo(string id, string price)
        {
            try
            {
                string sql = "update ticket set price = TRY_CONVERT(float,'" + price + "') where customer_id = '" + id + "';";
                DataAccess.GetDataSet(sql);
                sql = "select * from ticket where customer_id = '" + id + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        public static DataSet GetAllTicketInfo()
        {
            try
            {
                string sql = "select * from ticket;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        public static DataSet InsertTicket(TicketEntity ticket)
        {

            try
            {
                {
                    string sql = "insert into ticket(serial_no , customer_id,  price) values ('" + ticket.SerialNo + "','" + ticket.CustomerId + "','" + ticket.Price + "');";
                    MessageBox.Show("data inserted");
                    return DataAccess.GetDataSet(sql);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
