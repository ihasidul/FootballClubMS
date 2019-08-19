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
    class CustomerRepository
    {
        private static DataSet Ds { get; set; }

        public static int GetValueForCustomerId()
        {
            try
            {
                string sql = "select autoid from customer where autoid = (select max(autoid) from customer);";
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
        public static DataSet InsertCustomer(CustomerEntity customer)
        {

            try
            {
                {
                    string sql = "insert into customer(customer_id, customer_name, customer_email, fan) values ('" + customer.Id + "','" + customer.Name + "','" + customer.Email + "','" + customer.Fan + "');";
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
