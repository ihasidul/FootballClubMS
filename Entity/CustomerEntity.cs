using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Repository;


namespace FootballClubMS.Entity
{
    public class CustomerEntity
    {
        private string id;
        private string name;
        private string email;
        private bool fan;
        

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public bool Fan
        {
            get { return this.fan; }
            set { this.fan  = value; }
        }
      
        public CustomerEntity(string name,string email,bool fan)
        {
            int temp = CustomerRepository.GetValueForCustomerId() + 1;
            this.Id = "c-" + temp;
            this.Name = name;
            this.Email = email;
            this.Fan = fan;
        }

    }
}
