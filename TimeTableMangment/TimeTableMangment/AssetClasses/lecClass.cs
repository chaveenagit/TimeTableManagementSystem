using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableMangment.AssetClasses
{
    class lecClass
    {
        public String LecturerName { get; set; }

        public String Room { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        //Method to Updating data
        public bool Update(lecClass i)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql query to update the data in database
                string sql = "UPDATE LecManageTB2 SET Room=@Room WHERE LecturerName=@LecturerName";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add values
                cmd.Parameters.AddWithValue("@Room", i.Room);
                cmd.Parameters.AddWithValue("@LecturerName", i.LecturerName);


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
