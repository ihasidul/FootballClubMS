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
        public static DataSet GetAllPlayers(string sql = "select * from player;")
        {
            try
            {
                return DataAccess.ExecuteQuery(sql);
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
                    return DataAccess.ExecuteQuery(sql);
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
                    return DataAccess.ExecuteQuery(sql);

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
                    return DataAccess.ExecuteQuery(sql);

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
                return DataAccess.ExecuteQuery(sql);
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
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
    }
}
