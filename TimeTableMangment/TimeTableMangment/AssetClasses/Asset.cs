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
    class Asset
    {
        public int ID { get; set; }
        public string AcdYrSem { get; set; }
        public string Programme { get; set; }
        public int GrpNo { get; set; }
        public int NumofStudinMainGrp { get; set; }
        public int SubGrpNum { get; set; }
        public int NumofStudinSubGrp { get; set; }
        public string GrpID { get; set; }
        public string SubGrpID { get; set; }

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select ID,AcademicYearSem,Programme,GrpNo,NumofStudinMainGrp,SubGrpNum,NumofStudinSubGrp,GrpID,SubGrpID from ManageStdTimeTB";
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

        public bool Insert(Asset c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "INSERT INTO ManageStdTimeTB(AcademicYearSem,Programme,GrpNo,NumofStudinMainGrp,SubGrpNum,NumofStudinSubGrp,GrpID,SubGrpID) VALUES (@AcademicYearSem,@Programme,@GrpNo,@NumofStudinMainGrp,@SubGrpNum,@NumofStudinSubGrp,@GrpID,@SubGrpID)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AcademicYearSem", c.AcdYrSem);
                cmd.Parameters.AddWithValue("@Programme", c.Programme);
                cmd.Parameters.AddWithValue("@GrpNo", c.GrpNo);
                cmd.Parameters.AddWithValue("@NumofStudinMainGrp", c.NumofStudinMainGrp);
                cmd.Parameters.AddWithValue("@SubGrpNum", c.SubGrpNum);
                cmd.Parameters.AddWithValue("@NumofStudinSubGrp", c.NumofStudinSubGrp);
                cmd.Parameters.AddWithValue("@GrpID", c.GrpID);
                cmd.Parameters.AddWithValue("@SubGrpID", c.SubGrpID);

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

        public bool Update(Asset c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "UPDATE ManageStdTimeTB SET AcademicYearSem =@AcademicYearSem,Programme =@Programme,GrpNo =@GrpNo,NumofStudinMainGrp =@NumofStudinMainGrp,SubGrpNum = @SubGrpNum,NumofStudinSubGrp =@NumofStudinSubGrp,GrpID =@GrpID,SubGrpID =@SubGrpID WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AcademicYearSem", c.AcdYrSem);
                cmd.Parameters.AddWithValue("@Programme", c.Programme);
                cmd.Parameters.AddWithValue("@GrpNo", c.GrpNo);
                cmd.Parameters.AddWithValue("@NumofStudinMainGrp", c.NumofStudinMainGrp);
                cmd.Parameters.AddWithValue("@SubGrpNum", c.SubGrpNum);
                cmd.Parameters.AddWithValue("@NumofStudinSubGrp", c.NumofStudinSubGrp);
                cmd.Parameters.AddWithValue("@GrpID", c.GrpID);
                cmd.Parameters.AddWithValue("@SubGrpID", c.SubGrpID);
                cmd.Parameters.AddWithValue("@ID", c.ID);

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

        public bool Delete(Asset c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);

            try
            {
                string sql = "DELETE from ManageStdTimeTB  WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", c.ID);
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
