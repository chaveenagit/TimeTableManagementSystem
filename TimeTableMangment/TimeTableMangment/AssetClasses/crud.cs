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
    class crud
    {
        public string EmployeeID { get; set; }
        public string LecturerName { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Center { get; set; }
        public string Building { get; set; }
        public string Levl { get; set; }
        public string Rank { get; set; }
        public string ActiveHours { get; set; }
        public string AvailableDays { get; set; }

        static string ManageLecturerdbEntities = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select EmployeeID,LecturerName,Faculty,Department,Center,Building,Levl,Rank,ActiveHours,AvailableDays from LecManageTB2";
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

        public bool Insert(crud c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            try
            {
                string sql = "INSERT INTO LecManageTB2(EmployeeID,LecturerName,Faculty,Department,Center,Building,Levl,Rank,ActiveHours,AvailableDays) VALUES (@EmployeeID,@LecturerName,@Faculty,@Department,@Center,@Building,@Levl,@Rank,@ActiveHours,@AvailableDays)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", c.EmployeeID);
                cmd.Parameters.AddWithValue("@LecturerName", c.LecturerName);
                cmd.Parameters.AddWithValue("@Faculty", c.Faculty);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Center", c.Center);
                cmd.Parameters.AddWithValue("@Building", c.Building);
                cmd.Parameters.AddWithValue("@Levl", c.Levl);
                cmd.Parameters.AddWithValue("@Rank", c.Rank);
                cmd.Parameters.AddWithValue("@ActiveHours", c.ActiveHours);
                cmd.Parameters.AddWithValue("@AvailableDays", c.AvailableDays);

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

        public bool Update(crud c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            try
            {
                string sql = "UPDATE LecManageTB2 SET LecturerName =@LecturerName,Faculty =@Faculty,Department =@Department,Center =@Center,Building = @Building,Levl =@Levl,Rank =@Rank,ActiveHours =@ActiveHours,AvailableDays =@AvailableDays WHERE EmployeeID=@EmployeeID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@LecturerName", c.LecturerName);
                cmd.Parameters.AddWithValue("@Faculty", c.Faculty);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Center", c.Center);
                cmd.Parameters.AddWithValue("@Building", c.Building);
                cmd.Parameters.AddWithValue("@Levl", c.Levl);
                cmd.Parameters.AddWithValue("@Rank", c.Rank);
                cmd.Parameters.AddWithValue("@ActiveHours", c.ActiveHours);
                cmd.Parameters.AddWithValue("@AvailableDays", c.AvailableDays);
                cmd.Parameters.AddWithValue("@EmployeeID", c.EmployeeID);


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

        public bool Delete(crud c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);

            try
            {
                string sql = "DELETE from LecManageTB2  WHERE EmployeeID=@EmployeeID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeID", c.EmployeeID);
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
