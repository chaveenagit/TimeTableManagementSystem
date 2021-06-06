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
    class Sessionc
    {
        public string sid { get; set; }
        public string lecN1 { get; set; }
        public string lecN2 { get; set; }
        public string scode { get; set; }
        public string sName { get; set; }
        public string gID { get; set; }
        public string tag { get; set; }
        public string session { get; set; }

        static string ManageLecturerdbEntities = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;



         public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select sid,lecN1,lecN2,scode,sName,gID,tag,session from SessionMangeTB2";
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

        //insert

        public bool Insert(Sessionc se)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            try
            {
                string sql = "INSERT INTO SessionMangeTB2(lecN1,lecN2,scode,sName,gID,tag,session) VALUES (@lecN1,@lecN2,@scode,@sName,@gID,@tag,@session)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@lecN1", se.lecN1);
                cmd.Parameters.AddWithValue("@lecN2", se.lecN2);
                cmd.Parameters.AddWithValue("@scode", se.scode);
                cmd.Parameters.AddWithValue("@sName", se.sName);
                cmd.Parameters.AddWithValue("@gID", se.gID);
                cmd.Parameters.AddWithValue("@tag", se.tag);
                cmd.Parameters.AddWithValue("@session", se.session);



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


        //update

        public bool Update(Sessionc se)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            try
            {
                string sql = "UPDATE SessionMangeTB2 SET lecN1 =@lecN1,lecN2 =@lecN2,scode =@scode,sName =@sName,gID = @gID,tag =@tag,session =@session WHERE sid=@sid";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@lecN1", se.lecN1);
                cmd.Parameters.AddWithValue("@lecN2", se.lecN2);
                cmd.Parameters.AddWithValue("@scode", se.scode);
                cmd.Parameters.AddWithValue("@sName", se.sName);
                cmd.Parameters.AddWithValue("@gID", se.gID);
                cmd.Parameters.AddWithValue("@tag", se.tag);
                cmd.Parameters.AddWithValue("@session", se.session);
                cmd.Parameters.AddWithValue("@sid", se.sid);


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


        //delete

        public bool Delete(Sessionc se)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);

            try
            {
                string sql = "DELETE from SessionMangeTB2  WHERE sid=@sid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("sid", se.sid);
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
