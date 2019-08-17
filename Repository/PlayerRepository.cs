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
    
        public static int GetValueForPlayerId() //this is to get an int to make autoid
        {
            try
            {
                string sql = "select autoid from player where autoid = (select max(autoid) from player);";
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
        public static DataSet GetAllPlayers(string sql = "select * from player;")
        {
            try
            {
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet InsertPlayer(PlayerEntity pl)
        {
            try
            {
                {
                    string sql = "insert into player(id,name,position,email,validationdate,performance,weeklyfee) values('" + pl.Id + "','" + pl.Name + "','" + pl.Position + "','" + pl.Email + "','" + pl.ValidationDate + "',0," + pl.WeeklyFee + ");";

                    MessageBox.Show("data inserted");
                    return DataAccess.GetDataSet(sql);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet UpdatePlayer(PlayerEntity pl)
        {
            try
            {
                {

                    string sql = "UPDATE player SET name = '" + pl.Id + "',  email = '" + pl.Email + "',position = '" + pl.Position + "', validationdate = '" + pl.ValidationDate + "', weeklyfee = '" + pl.WeeklyFee + "' WHERE id = '" + pl.Id + "'; ";

                    MessageBox.Show("data updated");
                    return DataAccess.GetDataSet(sql);

                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public static DataSet UpdatePerformance(PlayerEntity pl)
        {
            try
            {
                {

                    string sql = "UPDATE player SET performance = '" + pl.Performance + "'  WHERE id = '" + pl.Id + "'; ";

                    MessageBox.Show("data updated");
                    return DataAccess.GetDataSet(sql);

                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public static DataSet SearchPlayer(string text)
        {
            try
            {
                string sql = "select * from player where name LIKE '%" + text + "%' ;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet DeletePlayer(string text)
        {
            try
            {
                string sql = "delete from player where id = '" + text + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

        //for player position
        public static DataSet GetPlayerPosition(string text)
        {
            try
            {
                string sql = "select position from player where id = '" + text + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //for set performance
        public static void SetPlayerPerformance(double performance, string text)
        {
            try
            {
                string sql = "select performance from player where id = '" + text + "';";
                Ds = DataAccess.GetDataSet(sql);
                double previousPerformance = Convert.ToInt32(Ds.Tables[0].Rows[0][0].ToString());
                double currentPerformance = (performance + previousPerformance) / 2;
                sql = "update player SET performance = TRY_CONVERT(float,'" + currentPerformance + "') where id = '" + text + "';";
                DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        //find top 2 striker with performance
        public static DataSet GetStrikerInFormation1()
        {
            try
            {
                string sql = "select top 2 name from player where position = 'striker' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //find top 4 midfielder with performance
        public static DataSet GetMidfielderInFormation1()
        {
            try
            {
                string sql = "select top 4 name from player where position = 'midfielder' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //find top 4 defender with performance
        public static DataSet GetDefender()
        {
            try
            {
                string sql = "select top 4 name from player where position = 'defender' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //find top goalkeeper with performance
        public static DataSet GetGoalkeeper()
        {
            try
            {
                string sql = "select top 1 name from player where position = 'goalkeeper' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

        //find top 3 striker with performance
        public static DataSet GetStrikerInFormation2()
        {
            try
            {
                string sql = "select top 3 name from player where position = 'striker' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //find top 3 midfielder with performance
        public static DataSet GetMidfielderInFormation2()
        {
            try
            {
                string sql = "select top 3 name from player where position = 'midfielder' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

    }
}
