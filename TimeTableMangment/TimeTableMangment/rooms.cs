using TimeTableMangment.AssetClasses;
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

namespace TimeTableMangment
{
    public partial class rooms : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstring);
        SqlCommand cmd;

        public rooms()
        {
            InitializeComponent();
        }
        subTagClass d = new subTagClass();
        tagClass f = new tagClass();
        subGroupClass g = new subGroupClass();
        lecClass j = new lecClass();
        subClass l = new subClass();
        sessionClasss t = new sessionClasss();

        private void rooms_Load(object sender, EventArgs e)
        {
            //get the related subject names to the combobox
            comboSelectSub.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectName FROM SubManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                comboSelectSub.Items.Add(dr["SubjectName"].ToString());
            }
            
            //get the related tag names to the combobox
            comboSelectTab.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RelatedTag FROM ManageTagTB";
            cmd.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                comboSelectTab.Items.Add(dr["RelatedTag"].ToString());
            }

            //get the related room names to the combobox
            comboSelectRoom.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM location_table";
            cmd.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                comboSelectRoom.Items.Add(dr["RoomName"].ToString());
            }

            //get the related tag names to the TagCombo
            comboTag.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RelatedTag FROM ManageTagTB";
            cmd.ExecuteNonQuery();

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd);
            da3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                comboTag.Items.Add(dr["RelatedTag"].ToString());
            }

            //get the related room names to the comboSelectRoom1
            comboSelectRoom1.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM location_table";
            cmd.ExecuteNonQuery();

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            da4.Fill(dt4);

            foreach (DataRow dr in dt4.Rows)
            {
                comboSelectRoom1.Items.Add(dr["RoomName"].ToString());
            }

            //get the related room names to the comboSelectSubgroup
            comboSelectSubgroup.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubGrpID FROM ManageStdTimeTB";
            cmd.ExecuteNonQuery();

            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            da5.Fill(dt5);

            foreach (DataRow dr in dt5.Rows)
            {
                comboSelectSubgroup.Items.Add(dr["SubGrpID"].ToString());
            }


            //get the related room names to the comboSelectRoom2
            comboSelectRoom2.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM location_table";
            cmd.ExecuteNonQuery();

            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(cmd);
            da6.Fill(dt6);

            foreach (DataRow dr in dt6.Rows)
            {
                comboSelectRoom2.Items.Add(dr["RoomName"].ToString());
            }

            //get the related room names to the comboSelectLecturer
            comboSelectLecturer.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT LecturerName FROM LecManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt7 = new DataTable();
            SqlDataAdapter da7 = new SqlDataAdapter(cmd);
            da7.Fill(dt7);

            foreach (DataRow dr in dt7.Rows)
            {
                comboSelectLecturer.Items.Add(dr["LecturerName"].ToString());
            }

            //get the related room names to the comboSelectRoom3
            comboSelectRoom3.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM location_table";
            cmd.ExecuteNonQuery();

            DataTable dt8 = new DataTable();
            SqlDataAdapter da8 = new SqlDataAdapter(cmd);
            da8.Fill(dt8);

            foreach (DataRow dr in dt8.Rows)
            {
                comboSelectRoom3.Items.Add(dr["RoomName"].ToString());
            }


            //get the related room names to the comboSelectSubjectRoom
            comboSelectSubjectRoom.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectName FROM SubManageTB2";
            cmd.ExecuteNonQuery();

            DataTable dt9 = new DataTable();
            SqlDataAdapter da9 = new SqlDataAdapter(cmd);
            da9.Fill(dt9);

            foreach (DataRow dr in dt9.Rows)
            {
                comboSelectSubjectRoom.Items.Add(dr["SubjectName"].ToString());
            }

            //get the related room names to the comboSelectRoom4
            comboSelectRoom4.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM location_table";
            cmd.ExecuteNonQuery();

            DataTable dt10 = new DataTable();
            SqlDataAdapter da10 = new SqlDataAdapter(cmd);
            da10.Fill(dt10);

            foreach (DataRow dr in dt10.Rows)
            {
                comboSelectRoom4.Items.Add(dr["RoomName"].ToString());
            }

            //get the related room names to the comboSelectSession
            comboSelectSession.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT session FROM SessionMangeTB2";
            cmd.ExecuteNonQuery();

            DataTable dt11 = new DataTable();
            SqlDataAdapter da11 = new SqlDataAdapter(cmd);
            da11.Fill(dt11);

            foreach (DataRow dr in dt11.Rows)
            {
                comboSelectSession.Items.Add(dr["session"].ToString());
            }

            //get the related room names to the comboSelectRoom5
            comboSelectRoom5.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM location_table";
            cmd.ExecuteNonQuery();

            DataTable dt12 = new DataTable();
            SqlDataAdapter da12 = new SqlDataAdapter(cmd);
            da12.Fill(dt12);

            foreach (DataRow dr in dt12.Rows)
            {
                comboSelectRoom5.Items.Add(dr["RoomName"].ToString());
            }
            conn.Close();
        }




        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            //get the values from the input fields
            d.Subject = comboSelectSub.Text;
            d.Tag = comboSelectTab.Text;
            d.Room = comboSelectRoom.Text;
           
            //inserting data into the databse usimg Insert method
            bool success = d.Insert(d);

            if (success == true)
            {
                MessageBox.Show("Room alocated Successfully!");
                //call the clear method here
                Clear();
            }
            else
            {
                MessageBox.Show("Room not allocated.Try again!!");
            }
        }

        private void Clear()
        {
            comboSelectSub.Text = " ";
            comboSelectTab.Text = " ";
            comboSelectRoom.Text = " ";
            comboTag.Text = " ";
            comboSelectRoom1.Text = " ";
            comboSelectSubgroup.Text = " ";
            comboSelectRoom2.Text = " ";
            comboSelectLecturer.Text = " ";
            comboSelectRoom3.Text = " ";
            comboSelectSubjectRoom.Text = " ";
            comboSelectRoom4.Text = " ";
            comboSelectSession.Text = " ";
            comboSelectRoom5.Text = " ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the data from text boxes
            
            f.RelatedTag = comboTag.Text;
            f.Room = comboSelectRoom1.Text;
            

            //update data in database
            bool success = f.Update(f);
            if (success == true)
            {
                MessageBox.Show("Room allocated successfully!");
                //load data into the grid view
               
                Clear();
            }
            else
            {
                MessageBox.Show("Room not allocated!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRoomSubGroup_Click(object sender, EventArgs e)
        {
            //get the data from text boxes

            g.SubGrpID = comboSelectSubgroup.Text;
            g.Room = comboSelectRoom2.Text;


            //update data in database
            bool success = g.Update(g);
            if (success == true)
            {
                MessageBox.Show("Room allocated successfully!");
                //load data into the grid view

                Clear();
            }
            else
            {
                MessageBox.Show("Room not allocated!");
            }
        }

        private void btnClearSubGroup_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAllocateLec_Click(object sender, EventArgs e)
        {
            //get the data from text boxes

            j.LecturerName = comboSelectLecturer.Text;
            j.Room = comboSelectRoom3.Text;


            //update data in database
            bool success = j.Update(j);
            if (success == true)
            {
                MessageBox.Show("Room allocated successfully!");
                //load data into the grid view

                Clear();
            }
            else
            {
                MessageBox.Show("Room not allocated!");
            }
        }

        private void btnClearLec_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAllocateSub_Click(object sender, EventArgs e)
        {
            //get the data from text boxes

            l.SubjectName = comboSelectSubjectRoom.Text;
            l.Room = comboSelectRoom4.Text;


            //update data in database
            bool success = l.Update(l);
            if (success == true)
            {
                MessageBox.Show("Room allocated successfully!");
                //load data into the grid view

                Clear();
            }
            else
            {
                MessageBox.Show("Room not allocated!");
            }

        }

        private void btnClearSubject_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAllocateSessionforRoom_Click(object sender, EventArgs e)
        {
            //get the data from text boxes

            t.session = comboSelectSession.Text;
            t.Room = comboSelectRoom5.Text;


            //update data in database
            bool success = t.Update(t);
            if (success == true)
            {
                MessageBox.Show("Room allocated successfully!");
                //load data into the grid view

                Clear();
            }
            else
            {
                MessageBox.Show("Room not allocated!");
            }

        }

        private void btnClearSess_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtStId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
