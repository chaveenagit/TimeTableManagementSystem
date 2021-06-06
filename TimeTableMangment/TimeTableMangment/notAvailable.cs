using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TimeTableMangment
{
    public partial class notAvailable : Form
    {
        public notAvailable()
        {
            InitializeComponent();
        }

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
        SqlConnection con = new SqlConnection(TimeTablemanagementdbEntities1);
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=member3;Integrated Security=True");

        //static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
        //SqlConnection con = new SqlConnection("TimeTablemanagementdbEntities1");
        public int Id;
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNotavilablelecture();
            GetNotavilableclass();
            GetNotavilablestudents();
        }

        private void GetNotavilablestudents()
        {
            SqlCommand cmd = new SqlCommand("Select * from NAStudents ", con);
            DataTable dt2 = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt2.Load(sdr);
            con.Close();

            StdataGridView.DataSource = dt2;
        }

        private void GetNotavilableclass()
        {
            SqlCommand cmd = new SqlCommand("Select * from NAClassroom ", con);
            DataTable dt1 = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            CRdataGridView.DataSource = dt1;
        }

        private void GetNotavilablelecture()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from NALecture ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            LdataGridView.DataSource = dt;
            
        }

        private void Btn_nal_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NALecture VALUES(@Lecturer, @Day, @Starttime, @Endtime) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer", SelectL.Text);
                cmd.Parameters.AddWithValue("@Day", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Starttime", Slectstl.Text);
                cmd.Parameters.AddWithValue("@Endtime", Selectetl.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Not Available Lectures Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilablelecture();
               
            }
        }

        private bool IsValid()
        {
            if(SelectL.Text == string.Empty)
            {
                MessageBox.Show("Select The Lecture", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                    
            }
            return true;
        }

        private void Btn_cl_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Id > 0)
                    {
                SqlCommand cmd = new SqlCommand("DELETE FROM  NALecture WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Record is Deleted from the System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilablelecture();

            }
            else
            {
                MessageBox.Show("Select The Lecture To delte the record", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Slectstl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Selectetl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(LdataGridView.SelectedRows[0].Cells[0].Value);
            SelectL.Text = LdataGridView.SelectedRows[0].Cells[1].Value.ToString();
           
            Slectstl.Text = LdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Selectetl.Text = LdataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Id > 0)
            {
                
                //cmd = conn.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "SELECT session FROM SessionMangeTB2";
                //cmd.ExecuteNonQuery();
                SqlCommand cd = new SqlCommand("UPDATE NALecture SET Lecturer= @Lecturer, Day= @Day, Starttime= @Starttime, Endtime= @Endtime WHERE Id =@Id ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@Lecturer", SelectL.Text);
                cd.Parameters.AddWithValue("@Day", dateTimePicker1.Text);
                cd.Parameters.AddWithValue("@Starttime", Slectstl.Text);
                cd.Parameters.AddWithValue("@Endtime", Selectetl.Text);
                //cd.Parameters.AddWithValue("@Endtime", Selectetl.Text);
                //cd.Parameters.AddWithValue("@Endtime", Selectetl.Text);
                //cd.Parameters.AddWithValue("@Endtime", Selectetl.Text);
                cd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Not Available Lectures Successfully Upadated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilablelecture(); 
            }
            else
            {
                MessageBox.Show("Select a Lecturer to Update Not Available Lecturer", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValid1())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NAClassroom VALUES(@Room, @Day, @Starttime, @Endtime) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room", SelectCR.Text);
                cmd.Parameters.AddWithValue("@Day", txtcrday.Text);
                cmd.Parameters.AddWithValue("@Starttime", CRstarttime.Text);
                cmd.Parameters.AddWithValue("@Endtime", CRendtime.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Not Available Classrooms Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilableclass();

            }
        }
        private bool IsValid1()
        {
            if (SelectCR.Text == string.Empty)
            {
                MessageBox.Show("Select The Classroom", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE NAClassroom SET Room= @Room, Day= @Day, Starttime= @Starttime, Endtime= @Endtime WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room", SelectCR.Text);
                cmd.Parameters.AddWithValue("@Day", txtcrday.Text);
                cmd.Parameters.AddWithValue("@Starttime", CRstarttime.Text);
                cmd.Parameters.AddWithValue("@Endtime", CRendtime.Text);
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Not Available Classroom Successfully Upadated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilableclass();
            }
            else
            {
                MessageBox.Show("Select a Classrooms to Update Not Available Classrooms", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CRreset_Click(object sender, EventArgs e)
        {
           
            //txtcrday.Clear();
            
        }

        private void CRdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(CRdataGridView.SelectedRows[0].Cells[0].Value);
            SelectCR.Text = CRdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtcrday.Text = CRdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            CRstarttime.Text = CRdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            CRendtime.Text = CRdataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void CRdelete_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM  NAClassroom WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Record is Deleted from the System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilableclass();

            }
            else
            {
                MessageBox.Show("Select The Classroom To delte the record", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid2())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NAStudents VALUES(@MGroup, @SubGroup, @Day, @Starttime, @Endtime) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MGroup", SelectMG.Text);
                cmd.Parameters.AddWithValue("@SubGroup", SelectSG.Text);
                cmd.Parameters.AddWithValue("@Day", txtSTday.Text);
                cmd.Parameters.AddWithValue("@Starttime", STstarttime.Text);
                cmd.Parameters.AddWithValue("@Endtime", STendtime.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Not Available Students Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilablestudents();

            }
        }
        private bool IsValid2()
        {
            if (SelectMG.Text == string.Empty)
            {
                MessageBox.Show("Select The MainGroup", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
           
            if (SelectSG.Text == string.Empty)
            {
                MessageBox.Show("Select The SubGroup", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
    

        private void EditGroupbtn_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE NAStudents SET MainGroup= @MGroup, Subgroup= @SubGroup, Day= @Day, Starttime= @Starttime, Endtime= @Endtime WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MGroup", SelectMG.Text);
                cmd.Parameters.AddWithValue("@SubGroup", SelectSG.Text);
                cmd.Parameters.AddWithValue("@Day", txtSTday.Text);
                cmd.Parameters.AddWithValue("@Starttime", STstarttime.Text);
                cmd.Parameters.AddWithValue("@Endtime", STendtime.Text);
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Not Available Students Groups Successfully Upadated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilablestudents();
            }
            else
            {
                MessageBox.Show("Select a Students Group to Update Not Available Classrooms", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void StdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(StdataGridView.SelectedRows[0].Cells[0].Value);
            SelectMG.Text = StdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            SelectSG.Text = StdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtSTday.Text = StdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            STstarttime.Text = StdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            STendtime.Text = StdataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DeleteGroupbtn_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM  NAStudents WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Record is Deleted from the System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNotavilablestudents();

            }
            else
            {
                MessageBox.Show("Select The Student Group To delte the record", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcrday_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }
    }
}
