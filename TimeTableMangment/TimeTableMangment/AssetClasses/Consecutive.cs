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
    class Consecutive
    {
        public int IDcon { get; set; }
        public string conSession1 { get; set; }
        public string conSession2 { get; set; }

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from ConsecutiveSessions";
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

        public bool Insert(Consecutive c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "INSERT INTO ConsecutiveSessions(conSession1,conSession2) VALUES (@conSession1,@conSession2)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@conSession1", c.conSession1);
                cmd.Parameters.AddWithValue("@conSession2", c.conSession2);

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

        public bool Update(Consecutive c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "UPDATE ConsecutiveSessions SET conSession1 =@conSession1,conSession2 =@conSession2 WHERE IDcon=@IDcon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@conSession1", c.conSession1);
                cmd.Parameters.AddWithValue("@conSession2", c.conSession2);
                cmd.Parameters.AddWithValue("@IDcon", c.IDcon);

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

        public bool Delete(Consecutive c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);

            try
            {
                string sql = "DELETE from ConsecutiveSessions  WHERE IDcon=@IDcon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("IDcon", c.IDcon);
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
