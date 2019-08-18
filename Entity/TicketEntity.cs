using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballClubMS.Repository;
using System.Data;
using System.Windows.Forms;

namespace FootballClubMS.Entity
{
    class TicketEntity
    {
        private string serialno;
        private string customerId;
        private double price;
        public string SerialNo
        {
            get { return this.serialno; }
            set { this.serialno = value; }
        }
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public double Price 
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public TicketEntity(string customerId,double price)
        {

            int temp = TicketRepository.GetValueForTicketId() + 1;
            this.SerialNo = "t-" + temp;
            this.CustomerId = customerId;
            this.Price = price;
        }

        public TicketEntity(DataSet ticket)
        {
            try
            {
                this.SerialNo = ticket.Tables[0].Rows[0][0].ToString();
                this.CustomerId = ticket.Tables[0].Rows[0][1].ToString();
                string p = ticket.Tables[0].Rows[0][2].ToString();
                this.Price = Convert.ToDouble(p);
              
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Could not get ticket informatin");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
