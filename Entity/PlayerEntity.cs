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
    class PlayerEntity
    {
        private string id;
        private string name;
        private string position;
        private string email;
        private DateTime validationDate;
        private double performance; 
        private double weeklyFee;

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
        public string Position
        {
            get { return this.position; }
            set { this.position= value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public DateTime ValidationDate
        {
            get { return this.validationDate; }
            set { this.validationDate = value; }
        }
        public double Performance
        {
            get { return this.performance; }
            set { this.performance  = value; }
        }
        public double WeeklyFee
        {
            get { return this.weeklyFee; }
            set { this.weeklyFee = value; }
        }

        public PlayerEntity(string name, string position, string email,DateTime validationDate,double weeklyFee)
        {
            int temp = PlayerRepository.GetValueForPlayerId() + 1;
            this.Id = "p-" + temp;
            this.Name = name;
            this.Position = position;
            this.Email = email;
            this.ValidationDate = validationDate;
            this.Performance = performance;
            this.WeeklyFee = weeklyFee;
        }

        public PlayerEntity(DataSet player)
        {
            try
            {
                this.Id = player.Tables[0].Rows[0][0].ToString();
                this.Name = player.Tables[0].Rows[0][1].ToString(); ;
                this.Position = player.Tables[0].Rows[0][2].ToString();
                this.Email = player.Tables[0].Rows[0][3].ToString();
                string vd = player.Tables[0].Rows[0][4].ToString();
                this.ValidationDate = Convert.ToDateTime(vd);//converting to date type
                string p = player.Tables[0].Rows[0][5].ToString(); 
                this.Performance = Convert.ToDouble(p);
                string wf = player.Tables[0].Rows[0][6].ToString();
                this.WeeklyFee = Convert.ToDouble(wf);

  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get Player informatin");
                MessageBox.Show(ex.Message);
            }
        }

        public PlayerEntity(DataSet player,string email,double weeklyFee, DateTime validationDate)
        {
            try
            {
                this.Id = player.Tables[0].Rows[0][0].ToString();
                this.Name = player.Tables[0].Rows[0][1].ToString(); ;
                this.Position = player.Tables[0].Rows[0][2].ToString();
                this.Email = email;
                this.ValidationDate = validationDate;//converting to date type
                string p = player.Tables[0].Rows[0][5].ToString();
                this.Performance = Convert.ToDouble(p);
                this.WeeklyFee = weeklyFee;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get Player informatin");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
