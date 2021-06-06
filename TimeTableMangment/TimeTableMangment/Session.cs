using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableMangment.AssetClasses;




namespace TimeTableMangment
{
    public partial class Session : Form
    {
        
        static string connection1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        SqlCommand cmd;

        public Session()
        {
            InitializeComponent();

            DataTable dt2 = se.Select();
            dataGridView1.DataSource = dt2;
            smtxt1.Enabled = false;
            stxt1.Enabled = false;
        }
        Sessionc se = new Sessionc();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scb5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        SqlConnection conn = new SqlConnection(connection1);
        private object dgvassetlist;

        private void Session_Load(object sender, EventArgs e)
        {

            //scb1 

            scb1.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT LecturerName FROM LecManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                scb1.Items.Add(dr["LecturerName"].ToString());
            }


            //scb2
            scb2.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT LecturerName FROM LecManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                scb2.Items.Add(dr["LecturerName"].ToString());
            }


            //scb3

            scb3.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectCode FROM SubManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                scb3.Items.Add(dr["SubjectCode"].ToString());
            }


            //scb4 SubjectName

            scb4.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectName FROM SubManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd);
            da3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                scb4.Items.Add(dr["SubjectName"].ToString());
            }


            //scb5-groupid

            scb5.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT GrpID FROM ManageStdTimeTB";
            cmd.ExecuteNonQuery();

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            da4.Fill(dt4);

            foreach (DataRow dr in dt4.Rows)
            {
                scb5.Items.Add(dr["GrpID"].ToString());
            }

            //scb6
            scb6.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TagName FROM ManageTagTB";
            cmd.ExecuteNonQuery();

            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            da5.Fill(dt5);

            foreach (DataRow dr in dt5.Rows)
            {
                scb6.Items.Add(dr["TagName"].ToString());
            }

            //scb7

            scb7.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT NumofStudinSubGrp FROM ManageStdTimeTB";
            cmd.ExecuteNonQuery();

            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(cmd);
            da6.Fill(dt6);

            foreach (DataRow dr in dt6.Rows)
            {
                scb7.Items.Add(dr["NumofStudinSubGrp"].ToString());
            }

            //uscb1

            uscb1.Items.Clear();
           
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT LecturerName FROM LecManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt7 = new DataTable();
            SqlDataAdapter da7 = new SqlDataAdapter(cmd);
            da.Fill(dt7);

            foreach (DataRow dr in dt7.Rows)
            {
                uscb1.Items.Add(dr["LecturerName"].ToString());
            }

            //uscb2
            uscb2.Items.Clear();

            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT LecturerName FROM LecManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt8 = new DataTable();
            SqlDataAdapter da8 = new SqlDataAdapter(cmd);
            da.Fill(dt8);

            foreach (DataRow dr in dt8.Rows)
            {
                uscb2.Items.Add(dr["LecturerName"].ToString());
            }


            //uscb3
            uscb3.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectCode FROM SubManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt9 = new DataTable();
            SqlDataAdapter da9 = new SqlDataAdapter(cmd);
            da9.Fill(dt9);

            foreach (DataRow dr in dt2.Rows)
            {
                uscb3.Items.Add(dr["SubjectCode"].ToString());
            }

            //uscb4
            uscb4.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectName FROM SubManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt10 = new DataTable();
            SqlDataAdapter da10 = new SqlDataAdapter(cmd);
            da10.Fill(dt10);

            foreach (DataRow dr in dt10.Rows)
            {
                uscb4.Items.Add(dr["SubjectName"].ToString());
            }

            //uscb5
            uscb5.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT GrpID FROM ManageStdTimeTB";
            cmd.ExecuteNonQuery();

            DataTable dt11 = new DataTable();
            SqlDataAdapter da11 = new SqlDataAdapter(cmd);
            da11.Fill(dt11);

            foreach (DataRow dr in dt11.Rows)
            {
                uscb5.Items.Add(dr["GrpID"].ToString());
            }

            // uscb6
            uscb6.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TagName FROM ManageTagTB";
            cmd.ExecuteNonQuery();

            DataTable dt12 = new DataTable();
            SqlDataAdapter da12 = new SqlDataAdapter(cmd);
            da12.Fill(dt12);

            foreach (DataRow dr in dt12.Rows)
            {
                uscb6.Items.Add(dr["TagName"].ToString());
            }




            conn.Close();
        }



        private void scb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void sbtn1_Click(object sender, EventArgs e)
        {
            stxt2.Text = scb1.Text.ToString() + "-" + scb2.Text.ToString() + "-" + scb3.Text.ToString() + "-" + scb4.Text.ToString() + "-" + scb6.Text.ToString() + "-" + scb5.Text.ToString() + "-" + scb7.Text.ToString();



        }

        private void label18_Click(object sender, EventArgs e)
        {

        }


        //insert
        private void sbtn2_Click(object sender, EventArgs e)
        {
            {

               /* if ( scb2.Text == "" || scb3.Text == "" || scb4.Text == "" || scb5.Text == "" || scb6.Text == "" || stxt1.Text == "" || stxt2.Text == "")
                {
                    MessageBox.Show("All Fields Are Required");
                }
                else*/
                {
                    //sid,lecN1,lecN2,scode,sName,gID,tag,session

                    //Sessionc s = new Sessionc();
                   
                    se.lecN1 = scb1.Text;
                    se.lecN2 = scb2.Text;
                    se.scode = scb3.Text;
                    se.sName = scb4.Text;
                    se.gID = scb5.Text;
                    se.tag = scb6.Text;
                    se.session = stxt2.Text;



                    bool success = se.Insert(se);
                    if (success == true)
                    {
                        MessageBox.Show("Successfully Inserted");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add new subject..Try Again!");
                    }
                    DataTable dt2 = se.Select();
                    dataGridView1.DataSource = dt2;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //getting data to data table
        private void tabPage2_Click(object sender, EventArgs e)
        {
            DataTable dt2 = se.Select();
            dataGridView1.DataSource = dt2;
        }

        //getting data to feilds
       private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          

        }


        //clear feilds
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        
       

        public void Clear()
        {
            scb1.Text = "";
            scb2.Text = "";
            scb3.Text = "";
            scb4.Text = "";
            scb5.Text = "";
            scb6.Text = "";
            scb7.Text = "";
            stxt1.Text = "";
            stxt2.Text = "";
            uscb1.Text = "";
            uscb2.Text = "";
            smtxt1.Text = "";
            uscb3.Text = "";
            uscb4.Text = "";
            uscb5.Text = "";
            uscb6.Text = "";
            smtxt2.Text = "";


            smtxt3.Text = "";
        }


        //genarate session
        private void button4_Click(object sender, EventArgs e)
        {
            smtxt2.Text = uscb1.Text.ToString() + "-" + uscb2.Text.ToString() + "-" + uscb3.Text.ToString() + "-" + uscb4.Text.ToString() + "-" + uscb6.Text.ToString() + "-" + uscb5.Text.ToString();

        }

        //search
        private void smtxt3_TextChanged(object sender, EventArgs e)
        {

            string keyword = smtxt3.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SessionMangeTB2 WHERE lecN1 LIKE '%" + keyword + "%' OR lecN2 LIKE '%" + keyword + "%' OR sName LIKE '%" + keyword + "%'", conn);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }



        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            //look at hereagain
            se.sid = smtxt1.Text;
            bool success = se.Delete(se);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Deleted..Try Again!");
            }
            DataTable dt2 = se.Select();
            dataGridView1.DataSource = dt2;
        }


        //update
        private void button1_Click(object sender, EventArgs e)
        {

            /*
                        if (scb6.Text == "" || scb7.Text == "" || scb8.Text == "" || scb9.Text == "" || snud5.Text == "" || snud6.Text == "" || snud7.Text == "" || snud8.Text == "")
                        {
                            MessageBox.Show("All Fields Are Required");

                        }
                        else*/
            {
                //look at here again
                se.sid = smtxt1.Text;
                se.lecN1 = uscb1.Text;
                se.lecN2 = uscb2.Text;
                se.scode = uscb3.Text;
                se.sName = uscb4.Text;
                se.gID = uscb5.Text;
                se.tag = uscb6.Text;
                se.session = smtxt2.Text;





                bool success = se.Update(se);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Updated.Try Again!");
                }
                DataTable dt2 = se.Select();
                dataGridView1.DataSource = dt2;
            }
        }


        //getting particular data for the feilds
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            smtxt1.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            uscb1.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            uscb2.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            uscb3.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            uscb4.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            uscb5.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            uscb6.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            smtxt2.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void smtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stxt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}