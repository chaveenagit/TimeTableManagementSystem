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
    class NonOverlapping
    {
        public int IDnon { get; set; }
        public string nonSession1 { get; set; }
        public string nonSession2 { get; set; }

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from NonOverlappingSessions";
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

        public bool Insert(NonOverlapping c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "INSERT INTO NonOverlappingSessions(nonSession1,nonSession2) VALUES (@nonSession1,@nonSession2)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nonSession1", c.nonSession1);
                cmd.Parameters.AddWithValue("@nonSession2", c.nonSession2);

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

        public bool Update(NonOverlapping c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "UPDATE NonOverlappingSessions SET nonSession1 =@nonSession1,nonSession2 =@nonSession2 WHERE IDnon=@IDnon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nonSession1", c.nonSession1);
                cmd.Parameters.AddWithValue("@nonSession2", c.nonSession2);
                cmd.Parameters.AddWithValue("@IDnon", c.IDnon);

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

        public bool Delete(NonOverlapping c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);

            try
            {
                string sql = "DELETE from NonOverlappingSessions  WHERE IDnon=@IDnon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("IDnon", c.IDnon);
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
