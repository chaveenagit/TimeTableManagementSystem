using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableMangment.AssetClasses
{
    class timetableclass
    {
        //getter setter properties
        public int BuildingId { get; set; }

        public String Building { get; set; }

        public String RoomName { get; set; }

        public String Capacity { get; set; }

        public String RoomType { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        //selecting data from databse
        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                //wtrite sql queries
                string sql = "SELECT * FROM location_table ";
                //create and use sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Createing Sql Adapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting data into database
        public bool Insert(timetableclass c)
        {
            //creating a default return type
            bool isSuccess = false;

            //connect the database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //create a sql query to insert data
                string sql = "INSERT INTO location_table(Building,RoomName,Capacity,RoomType) VALUES (@Building,@RoomName,@Capacity,@RoomType)";
                //create sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@Building", c.Building);
                cmd.Parameters.AddWithValue("@RoomName", c.RoomName);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@RoomType", c.RoomType);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to Updating data
        public bool Update(timetableclass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to update the data in database
                string sql = "UPDATE location_table SET Building=@Building,RoomName=@RoomName,Capacity=@Capacity,RoomType=@RoomType WHERE BuildingId=@BuildingId";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add values
                cmd.Parameters.AddWithValue("@Building", c.Building);
                cmd.Parameters.AddWithValue("@RoomName", c.RoomName);
                cmd.Parameters.AddWithValue("@Capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@RoomType", c.RoomType);
                cmd.Parameters.AddWithValue("@BuildingId", c.BuildingId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to delete data from database
        public bool Delete(timetableclass c)
        {
            bool isSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to delete the data from database
                string sql = "DELETE FROM location_table WHERE BuildingId=@BuildingId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@BuildingId", c.BuildingId);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
