using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
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
                    string sql = "insert into player(player_id,player_name,position,player_email,validation_date,performance,weekly_fee) values('" + pl.Id + "','" + pl.Name + "','" + pl.Position + "','" + pl.Email + "','" + pl.ValidationDate + "',0," + pl.WeeklyFee + ");";

                    
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

                    string sql = "UPDATE player SET player_name = '" + pl.Name + "',  player_email = '" + pl.Email + "',position = '" + pl.Position + "', validation_date = '" + pl.ValidationDate + "', weekly_fee = '" + pl.WeeklyFee + "' WHERE player_id = '" + pl.Id + "'; ";

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

                    string sql = "UPDATE player SET performance = '" + pl.Performance + "'  WHERE player_id = '" + pl.Id + "'; ";

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
                string sql = "select * from player where player_name LIKE '%" + text + "%' ;";
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
                string sql = "delete from player where player_id = '" + text + "';";//this is for player table
                string sqlLogin = "delete from login where id = '" + text + "';";
                DataAccess.GetDataSet(sqlLogin);
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
                string sql = "select position from player where player_id = '" + text + "';";
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
                string sql = "select performance from player where player_id = '" + text + "';";
                Ds = DataAccess.GetDataSet(sql);
                double previousPerformance = Convert.ToInt32(Ds.Tables[0].Rows[0][0].ToString());
                double currentPerformance = (performance + previousPerformance) / 2;
                sql = "update player SET performance = TRY_CONVERT(float,'" + currentPerformance + "') where player_id = '" + text + "';";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        //find top 2 striker with performance
        public static DataSet GetTwoStriker()
        {
            try
            {
                string sql = "select top 2 player_name from player where position = 'striker' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //find top 4 midfielder with performance
        public static DataSet GetFourMidfielder()
        {
            try
            {
                string sql = "select top 4 player_name from player where position = 'midfielder' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //find top 4 defender with performance
        public static DataSet GetFourDefender()
        {
            try
            {
                string sql = "select top 4 player_name from player where position = 'defender' order by performance desc;";
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
                string sql = "select top 1 player_name from player where position = 'goalkeeper' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

        //find top 3 striker with performance
        public static DataSet GetThreeStriker()
        {
            try
            {
                string sql = "select top 3 player_name from player where position = 'striker' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        //find top 3 midfielder with performance
        public static DataSet GetThreeMidfielder()
        {
            try
            {
                string sql = "select top 3 player_name from player where position = 'midfielder' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

        //find top 1 striker with performance
        public static DataSet GetOneStriker()
        {
            try
            {
                string sql = "select top 1 player_name from player where position = 'striker' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

        //find top 3 defender with performance
        public static DataSet GetThreeDefender()
        {
            try
            {
                string sql = "select top 3 player_name from player where position = 'defender' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

        //find top 5 defender with performance
        public static DataSet GetFiveDefender()
        {
            try
            {
                string sql = "select top 5 player_name from player where position = 'defender' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

        //find top 5 midfielder with performance
        public static DataSet GetFiveMidfielder()
        {
            try
            {
                string sql = "select top 5 player_name from player where position = 'midfielder' order by performance desc;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }

   
        public static DataSet GetSpecificPlayer(string id)
        {
            try
            {
                string sql = "select * from player where player_id = '" + id + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }


    }
}