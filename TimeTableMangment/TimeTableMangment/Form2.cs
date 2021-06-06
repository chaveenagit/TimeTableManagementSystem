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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=member3;Integrated Security=True");
        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
        SqlConnection con = new SqlConnection(TimeTablemanagementdbEntities1);
        public int Id;
        public int Sid;
        private void Slectstl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValid1())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Workingdays VALUES (@Day1, @Day2, @Day3, @Day4, @Day5, @Day6, @Day7) ", con);
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@Day1", Day1.Text);
                cmd.Parameters.AddWithValue("@Day2", Day2.Text);
                cmd.Parameters.AddWithValue("@Day3", Day3.Text);
                cmd.Parameters.AddWithValue("@Day4", Day4.Text);
                cmd.Parameters.AddWithValue("@Day5", Day5.Text);
                cmd.Parameters.AddWithValue("@Day6", Day6.Text);
                cmd.Parameters.AddWithValue("@Day7", Day7.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Working Days Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetWorkingDays();

            }
        }

        private bool IsValid1()
        {
            if (Selectnumber.Text == string.Empty)
            {
                MessageBox.Show("Select Working Day", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
    

        private void button6_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Workingdays SET Day1= @Day1, Day2= @Day2, Day3= @Day3, Day4= @Day4, Day5= @Day5, Day6= @Day6, Day7= @Day7 WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Day1", Day1.Text);
                cmd.Parameters.AddWithValue("@Day2", Day2.Text);
                cmd.Parameters.AddWithValue("@Day3", Day3.Text);
                cmd.Parameters.AddWithValue("@Day4", Day4.Text);
                cmd.Parameters.AddWithValue("@Day5", Day5.Text);
                cmd.Parameters.AddWithValue("@Day6", Day6.Text);
                cmd.Parameters.AddWithValue("@Day7", Day7.Text);
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Not Available Lectures Successfully Upadated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetWorkingDays();
            }
            else
            {
                MessageBox.Show("Select a Lecturer to Update Not Available Lecturer", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM  Workingdays WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Record is Deleted from the System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetWorkingDays();

            }
            else
            {
                MessageBox.Show("Select The Lecture To delte the record", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void txtworkingtime_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM  Timeslots WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Record is Deleted from the System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTimeSlot();

            }
            else
            {
                MessageBox.Show("Select The No of Working Days To delte the record", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE NoOfWorkingDays SET NoOfWorkingDays= @Noofwd WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Noofwd", int.Parse(Selectnumber.Text));
                
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("No Of Working Days Successfully Upadated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNofoworkingDays();
            }
            else
            {
                MessageBox.Show("Select a Number of working days to Update No Of Working Days", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetNofoworkingDays();
            GetWorkingDays();
            GetWorkingTime();
            GetTimeSlot();
            
        }

    

        private void GetTimeSlot()
        {
            SqlCommand cmd = new SqlCommand("Select * from Timeslots ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewSlots.DataSource = dt; ;
        }

        private void GetWorkingTime()
        {
            SqlCommand cmd = new SqlCommand("Select * from Workingtime ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewWorktime.DataSource = dt; ;
        }

        private void GetWorkingDays()
        {
            SqlCommand cmd = new SqlCommand("Select * from Workingdays ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewDays.DataSource = dt;
        }

        private void GetNofoworkingDays()
        {
            SqlCommand cmd = new SqlCommand("Select * from NoOfWorkingDays ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewNoofwd.DataSource = dt;
        }

        private void Addno_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NoOfWorkingDays VALUES(@Noofwd)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Noofwd", int.Parse(Selectnumber.Text));
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("No of Working Days Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNofoworkingDays();

            }
        }

        private bool IsValid()
        {
            if (Selectnumber.Text == string.Empty)
            {
                MessageBox.Show("Select The Number Of Working Days", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void dataGridViewNoofwd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewNoofwd.SelectedRows[0].Cells[0].Value);
            Selectnumber.Text = dataGridViewNoofwd.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Removeno_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM  NoOfWorkingDays WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Record is Deleted from the System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNofoworkingDays();

            }
            else
            {
                MessageBox.Show("Select The No of Working Days To delte the record", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewDays.SelectedRows[0].Cells[0].Value);
            Day1.Text = dataGridViewDays.SelectedRows[0].Cells[1].Value.ToString();
            Day2.Text = dataGridViewDays.SelectedRows[0].Cells[2].Value.ToString();
            Day3.Text = dataGridViewDays.SelectedRows[0].Cells[3].Value.ToString();
            Day4.Text = dataGridViewDays.SelectedRows[0].Cells[4].Value.ToString();
            Day5.Text = dataGridViewDays.SelectedRows[0].Cells[5].Value.ToString();
            Day6.Text = dataGridViewDays.SelectedRows[0].Cells[6].Value.ToString();
            Day7.Text = dataGridViewDays.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Addtime_Click(object sender, EventArgs e)
        {
            if (IsValid2())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Workingtime VALUES(@Hours , @Minutes) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Hours", UpDownHours.Text);
                cmd.Parameters.AddWithValue("@Minutes", UpDownMinutes.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Working Time Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetWorkingTime();

            }
        }

        private bool IsValid2()
        {
            if (Selectnumber.Text == string.Empty)
            {
                MessageBox.Show("Select Working Time", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void dataGridViewWorktime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewWorktime.SelectedRows[0].Cells[0].Value);
            UpDownHours.Text = dataGridViewWorktime.SelectedRows[0].Cells[1].Value.ToString();
            UpDownMinutes.Text = dataGridViewWorktime.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Edittime_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Workingtime SET Hours= @Hours ,Minutes= @Minutes  WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Hours", UpDownHours.Text);
                cmd.Parameters.AddWithValue("@Minutes", UpDownMinutes.Text);

                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Working Time Successfully Upadated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetWorkingTime();
            }
            else
            {
                MessageBox.Show("Select to Update No Of Working Time", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Deletetime_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM  Workingtime WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Record is Deleted from the System", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetWorkingTime();

            }
            else
            {
                MessageBox.Show("Select Working Time To delete the record", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Slotuadd_Click(object sender, EventArgs e)
        {
            if (IsValid3())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Timeslots VALUES(@Slot) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Slot", Slottype.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("No of Working Days Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTimeSlot();

            }
        }

        private bool IsValid3()
        {
            if (Selectnumber.Text == string.Empty)
            {
                MessageBox.Show("Select The Number Of Working Days", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void dataGridViewSlots_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridViewSlots.SelectedRows[0].Cells[0].Value);
            Slottype.Text = dataGridViewSlots.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Slotupdate_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Timeslots SET Slot= @Slot WHERE Id =@Id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Slot", Slottype.Text);

                cmd.Parameters.AddWithValue("@Id", this.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Time Slot Successfully Upadated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTimeSlot();
            }
            else
            {
                MessageBox.Show("Select a Slot to UpdateTimeslots", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cleartime_Click(object sender, EventArgs e)
        {

        }

        private void Addsdt_Click(object sender, EventArgs e)
        {
            
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into SessionDateTime values(@Sid,@Day,@Starttime,@Endtime)", con);
                cmd.Parameters.AddWithValue("@Sid", int.Parse(txtsid.Text));
                cmd.Parameters.AddWithValue("@Day", txtdaysdt.Text);
                cmd.Parameters.AddWithValue("@Starttime", txtStsdt.Text);
                cmd.Parameters.AddWithValue("@Endtime", txtEDsdt.Text);

                //con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Insertred");

        
        }

      
       

        private void Editsdt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update  SessionDateTime set Day= @Day, Starttime=@Starttime, Endtime=@Endtime where Sid=@Sid", con);
            cmd.Parameters.AddWithValue("@Sid", int.Parse(txtsid.Text));
            cmd.Parameters.AddWithValue("@Day", txtdaysdt.Text);
            cmd.Parameters.AddWithValue("@Starttime", txtStsdt.Text);
            cmd.Parameters.AddWithValue("@Endtime", txtEDsdt.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");

        }

        private void Deletesdt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete SessionDateTime where Sid=@Sid ", con);
            cmd.Parameters.AddWithValue("@Sid", int.Parse(txtsid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Successfully Deleted");
        }

        private void Searchsdt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from SessionDateTime ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSDt.DataSource = dt;
            con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

