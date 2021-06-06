using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TimeTableMangment.AssetClasses
{
    class student
    {
        public int SubjectID { get; set; }
        public string OfferedYear { get; set; }
        public string OfferedSemester { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int NoofLecHours { get; set; }
        public int NoofTuteHours { get; set; }
        public int NoofLabHours { get; set; }
        public int NoofEvaluationHours { get; set; }


        static string ManageLecturerdbEntities = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select SubjectID,OfferedYear,OfferedSemester,SubjectName,SubjectCode,NoofLecHours,NoofTuteHours,NoofLabHours,NoofEvaluationHours from SubManageTB2";
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

        public bool Insert(student s)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            try
            {
                string sql = "INSERT INTO SubManageTB2(OfferedYear,OfferedSemester,SubjectName,SubjectCode,NoofLecHours,NoofTuteHours,NoofLabHours,NoofEvaluationHours) VALUES (@OfferedYear,@OfferedSemester,@SubjectName,@SubjectCode,@NoofLecHours,@NoofTuteHours,@NoofLabHours,@NoofEvaluationHours)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@OfferedYear", s.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemester", s.OfferedSemester);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@NoofLecHours", s.NoofLecHours);
                cmd.Parameters.AddWithValue("@NoofTuteHours", s.NoofTuteHours);
                cmd.Parameters.AddWithValue("@NoofLabHours", s.NoofLabHours);
                cmd.Parameters.AddWithValue("@NoofEvaluationHours", s.NoofEvaluationHours);


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


        public bool Update(student c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            try
            {
                string sql = "UPDATE SubManageTB2 SET OfferedYear =@OfferedYear,OfferedSemester =@OfferedSemester,SubjectName =@SubjectName,SubjectCode =@SubjectCode,NoofLecHours = @NoofLecHours,NoofTuteHours =@NoofTuteHours,NoofLabHours =@NoofLabHours,NoofEvaluationHours =@NoofEvaluationHours WHERE SubjectID=@SubjectID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@OfferedYear", c.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemester", c.OfferedSemester);
                cmd.Parameters.AddWithValue("@SubjectName", c.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", c.SubjectCode);
                cmd.Parameters.AddWithValue("@NoofLecHours", c.NoofLecHours);
                cmd.Parameters.AddWithValue("@NoofTuteHours", c.NoofTuteHours);
                cmd.Parameters.AddWithValue("@NoofLabHours", c.NoofLabHours);
                cmd.Parameters.AddWithValue("@NoofEvaluationHours", c.NoofEvaluationHours);

                cmd.Parameters.AddWithValue("@SubjectID", c.SubjectID);


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

        public bool Delete(student c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);

            try
            {
                string sql = "DELETE from SubManageTB2  WHERE SubjectID=@SubjectID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("SubjectID", c.SubjectID);
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
