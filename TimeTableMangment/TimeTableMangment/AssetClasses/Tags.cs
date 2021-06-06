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
    class Tags
    {
        public int ID { get; set; }
        public string TagName { get; set; }
        public string TagCode { get; set; }
        public string RelatedTag { get; set; }
        public string SpecialComments { get; set; }

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select ID,TagName,TagCode,RelatedTag,SpecialComments from ManageTagTB";
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

        public bool Insert(Tags c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "INSERT INTO ManageTagTB(TagName,TagCode,RelatedTag,SpecialComments) VALUES (@TagName,@TagCode,@RelatedTag,@SpecialComments)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TagName", c.TagName);
                cmd.Parameters.AddWithValue("@TagCode", c.TagCode);
                cmd.Parameters.AddWithValue("@RelatedTag", c.RelatedTag);
                cmd.Parameters.AddWithValue("@SpecialComments", c.SpecialComments);

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

        public bool Update(Tags c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            try
            {
                string sql = "UPDATE ManageTagTB SET TagName =@TagName,TagCode =@TagCode,RelatedTag =@RelatedTag,SpecialComments =@SpecialComments WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TagName", c.TagName);
                cmd.Parameters.AddWithValue("@TagCode", c.TagCode);
                cmd.Parameters.AddWithValue("@RelatedTag", c.RelatedTag);
                cmd.Parameters.AddWithValue("@SpecialComments", c.SpecialComments);
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


        public bool Delete(Tags c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);

            try
            {
                string sql = "DELETE from ManageTagTB  WHERE ID=@ID";
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
