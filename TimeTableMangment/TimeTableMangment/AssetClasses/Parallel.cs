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

    class Parallel
    {
        public int IDpar { get; set; }
        public string parSession1 { get; set; }
        public string parSession2 { get; set; }
        public int duration { get; set; }

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from ParallelSessions";
                SqlCommand cmd = new SqlCommand(sql, conn);
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

        public bool Insert(Parallel c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "INSERT INTO ParallelSessions(parSession1,parSession2,duration) VALUES (@parSession1,@parSession2,@duration)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@parSession1", c.parSession1);
                cmd.Parameters.AddWithValue("@parSession2", c.parSession2);
                cmd.Parameters.AddWithValue("@duration", c.duration);

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

        public bool Update(Parallel c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "UPDATE ParallelSessions SET parSession1 =@parSession1,parSession2 =@parSession2,duration =@duration WHERE IDpar=@IDpar";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@parSession1", c.parSession1);
                cmd.Parameters.AddWithValue("@parSession2", c.parSession2);
                cmd.Parameters.AddWithValue("@duration", c.duration);
                cmd.Parameters.AddWithValue("@IDpar", c.IDpar);

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

        public bool Delete(Parallel c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);

            try
            {
                string sql = "DELETE from ParallelSessions  WHERE IDpar=@IDpar";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("IDpar", c.IDpar);
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
