using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubMS.Data;
using FootballClubMS.Entity;

namespace FootballClubMS.Repository
{
    class EmployeeRepository
    {
        private static DataSet Ds { get; set; }
        public static int GetValueForEmployeeId()//this is to get an int to make auto id. this gives the max value of autoid in the database
        {
            try
            {
                string sql = "select autoid from employee where autoid = (select max(autoid) from employee);";
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
        public static DataSet GetAllEmployee(string sql = "select * from employee;")
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
        public static DataSet InsertEmployee(EmployeeEntity emp)
        {

            try
            {
                {
                    string sql = "insert into Employee (id,name,email,designation,salary) values ('" + emp.Id + "','" + emp.Name + "','" + emp.Email + "','" + emp.Designation + "','" + emp.Salary + "');";

                    MessageBox.Show("data inserted");
                    return DataAccess.GetDataSet(sql);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet UpdateEmployee(EmployeeEntity emp)
        {

            try
            {
                {

                    string sql = "UPDATE employee SET name = '" + emp.Id + "',  email = '" + emp.Email + "',designation = '" + emp.Designation + "', salary = '" + emp.Salary + "' WHERE id = '" + emp.Id + "'; ";

                    MessageBox.Show("data updated");
                    return DataAccess.GetDataSet(sql);

                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public static DataSet SearchEmployee(string text)
        {
            try
            {
                string sql = "select * from employee where name LIKE '%" + text + "%' ;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet DeleteEmployee(string text)
        {
            try
            {
                string sql = "delete from employee where id = '" + text + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return null;
            }
        }
        public static DataSet GetSpecificEmployee(string id)
        {
            try
            {
                string sql = "select * from employee where id = '" + id + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

    }
}
