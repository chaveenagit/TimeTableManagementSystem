using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableMangment.AssetClasses
{
    class subTagClass
    {
        //getter setter properties
        public int STID { get; set; }

        public String Subject { get; set; }

        public String Tag { get; set; }

        public String Room { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        //Inserting data into database
        public bool Insert(subTagClass c)
        {
            //creating a default return type
            bool isSuccess = false;

            //connect the database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //create a sql query to insert data
                string sql = "INSERT INTO sub_tag(Subject,Tag,Room) VALUES (@Subject,@Tag,@Room)";
                //create sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@Subject", c.Subject);
                cmd.Parameters.AddWithValue("@Tag", c.Tag);
                cmd.Parameters.AddWithValue("@Room", c.Room);
                
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
    }
}
