using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableMangment.AssetClasses;

namespace TimeTableMangment
{
    public partial class Lecturer : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Lecturer()
        {
            InitializeComponent();
            timerTime.Start();
            //PanelWidth = panelLeft.Width;
            isCollapsed = false;
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;

            DataTable dt2 = s.Select();
            dgvassetlist.DataSource = dt2;
            stxt2.Enabled = false;
            
            
        }
        crud c = new crud();
        student s = new student();

        private void button1_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnDays);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  moveSidePanel(btnSubject);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        //    if(isCollapsed)
        //    {
        //        panelLeft.Width = panelLeft.Width + 10;
        //        if(panelLeft.Width >= PanelWidth)
        //        {
        //            timer1.Stop();
        //            isCollapsed = false;
        //            this.Refresh();
        //        }
        //    }
        //    else
        //    {
        //        panelLeft.Width = panelLeft.Width - 10;
        //        if(panelLeft.Width <= 61)
        //        {
        //            timer1.Stop();
        //            isCollapsed = true;
        //            this.Refresh();
        //        }
        //    }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
           // panelSide.Top = btn.Top;
            //panelSide.Height = btn.Height;
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
          //  moveSidePanel(btnLecturer);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
           // moveSidePanel(btnStudent);
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
          //  moveSidePanel(btnLocation);
           // panelInfo.BringToFront();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnTags);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
          //  moveSidePanel(btnDashboard);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
           // DateTime dt = DateTime.Now;
          //  labelTime.Text = dt.ToString("hh:mm:ss");
        }

        private void moveUpPanel(Control btn)
        {
           // panelUp.Width = btn.Width;
           // panelUp.Left = btn.Left;
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
           // moveUpPanel(btnSession);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            //moveUpPanel(btnRoom);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           // moveUpPanel(btnAdvanced);
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
           // moveUpPanel(btnGenarate);
        }

        private void btnMins_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;


        //look at thisssssssssssssssss
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 0;
                mouseY = MousePosition.Y - 0;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void tabP1_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;
        }

        private void tabP2_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;
        }

        string AvailableDays;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || com1.Text == "" || com2.Text == "" || com3.Text == "" || com4.Text == "" || com5.Text == "" || txt3.Text == "" || txt4.Text == "")
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                c.EmployeeID = txt1.Text;
                c.LecturerName = txt2.Text;
                c.Faculty = com1.Text;
                c.Department = com2.Text;
                c.Center = com3.Text;
                c.Building = com4.Text;
                c.Levl = com5.Text;
                c.Rank = txt3.Text;
                c.ActiveHours = txt4.Text;
                c.AvailableDays = AvailableDays.ToString();


                bool success = c.Insert(c); 
                if (success == true)
                {
                    MessageBox.Show("Successfully Inserted");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Add new Lecturer..Try Again!");
                }
                DataTable dt = c.Select();
                dgvassetlist.DataSource = dt;
            }
        }

        private void genrank_Click(object sender, EventArgs e)
        {
            if(com5.Text == "1" || com5.Text == "2" || com5.Text == "3" || com5.Text == "4" || com5.Text == "5" || com5.Text == "6")
            {
                txt3.Text =  com5.Text.ToString()+"."+ txt1.Text.ToString();
            }
            
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Monday";
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Tuesday";
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Wednesday";
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Thursday";
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Friday";
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Saturday";
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Sunday";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            com1.Text = "";
            com2.Text = "";
            com3.Text = "";
            com4.Text = "";
            com5.Text = "";
            com6.Text = "";
            com7.Text = "";
            com8.Text = "";
            com9.Text = "";
            com10.Text = "";
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb6.Checked = false;
            cb7.Checked = false;
            cb8.Checked = false;
            cb9.Checked = false;
            cb10.Checked = false;
            cb11.Checked = false;
            cb12.Checked = false;
            cb13.Checked = false;
            cb14.Checked = false;
            txtsearch.Text = "";
        }

        static string ManageLecturerdbEntities = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
       //
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM LecManageTB2 WHERE EmployeeID LIKE '%" + keyword + "%' OR LecturerName LIKE '%" + keyword + "%' OR Faculty LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvassetlist.DataSource = dt;
        }

        private void dgvassetlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt5.Text = dgvassetlist.Rows[rowIndex].Cells[0].Value.ToString();
            txt6.Text = dgvassetlist.Rows[rowIndex].Cells[1].Value.ToString();
            com6.Text = dgvassetlist.Rows[rowIndex].Cells[2].Value.ToString();
            com7.Text = dgvassetlist.Rows[rowIndex].Cells[3].Value.ToString();
            com8.Text = dgvassetlist.Rows[rowIndex].Cells[4].Value.ToString();
            com9.Text = dgvassetlist.Rows[rowIndex].Cells[5].Value.ToString();
            com10.Text = dgvassetlist.Rows[rowIndex].Cells[6].Value.ToString();
            txt7.Text = dgvassetlist.Rows[rowIndex].Cells[7].Value.ToString();
            txt8.Text = dgvassetlist.Rows[rowIndex].Cells[8].Value.ToString();           
        }

        private void btnrank_Click(object sender, EventArgs e)
        {
            if (com10.Text == "1" || com10.Text == "2" || com10.Text == "3" || com10.Text == "4" || com10.Text == "5" || com10.Text == "6")
            {
                txt7.Text = com10.Text.ToString() + "." + txt5.Text.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.EmployeeID = txt5.Text;
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Deleted Shop..Try Again!");
            }
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txt5.Text == "" || txt6.Text == "" || com6.Text == "" || com7.Text == "" || com8.Text == "" || com9.Text == "" || com10.Text == "" || txt7.Text == "" || txt8.Text == "")
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                c.EmployeeID = txt5.Text;
                c.LecturerName = txt6.Text;
                c.Faculty = com6.Text;
                c.Department = com7.Text;
                c.Center = com8.Text;
                c.Building = com9.Text;
                c.Levl = com10.Text;
                c.Rank = txt7.Text;
                c.ActiveHours = txt8.Text;
                c.AvailableDays = AvailableDays.ToString();



                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Updated ..Try Again!");
                }
                DataTable dt = c.Select();
                dgvassetlist.DataSource = dt;
            }
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
                    
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 6 && ch != 0)
            {
                e.Handled = true;
            }
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Monday";
        }

        private void cb9_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Tuesday";
        }

        private void cb10_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Wednesday";
        }

        private void cb11_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Thursday";
        }

        private void cb12_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Friday";
        }

        private void cb13_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Saturday";
        }

        private void cb14_CheckedChanged(object sender, EventArgs e)
        {
            AvailableDays = "Sunday";
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void tabP4_Click(object sender, EventArgs e)
        {
            DataTable dt2 = s.Select();
            dataGridView1.DataSource = dt2;
        }

        private void tabP5_Click(object sender, EventArgs e)
        {
            DataTable dt2 = s.Select();
            dataGridView1.DataSource = dt2;
        }


        //Insert
        private void sbtn1_Click(object sender, EventArgs e)
        {

            if (scb2.Text == "" || scb3.Text == "" || scb4.Text == "" || scb5.Text == "" || snud1.Text == "" || snud2.Text == "" || snud3.Text == "" || snud4.Text == "")
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                
                s.OfferedYear = scb2.Text;
                s.OfferedSemester = scb3.Text;
                s.SubjectName = scb4.Text;
                s.SubjectCode = scb5.Text;
                s.NoofLecHours = Convert.ToInt32(this.snud1.Value);
                s.NoofTuteHours = Convert.ToInt32(this.snud2.Value);
                s.NoofLabHours = Convert.ToInt32(this.snud3.Value);
                s.NoofEvaluationHours = Convert.ToInt32(this.snud4.Value);



                bool success = s.Insert(s);
                if (success == true)
                {
                    MessageBox.Show("Successfully Inserted");
                    Clear_Sub();
                }
                else
                {
                    MessageBox.Show("Failed to Add new subject..Try Again!");
                }
                DataTable dt2 = s.Select();
                dataGridView1.DataSource = dt2;
                
            }




        }

        //search
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;

            SqlConnection conn = new SqlConnection(ManageLecturerdbEntities);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SubManageTB2 WHERE SubjectCode LIKE '%" + keyword + "%' OR SubjectName LIKE '%" + keyword + "%' OR OfferedYear LIKE '%" + keyword + "%'", conn);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }



        //delete
        private void sbtn4_Click(object sender, EventArgs e)
        {
            s.SubjectID = Convert.ToInt32(stxt2.Text);
            bool success = s.Delete(s);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                Clear_Sub();
            }
            else
            {
                MessageBox.Show("Failed to Deleted..Try Again!");
            }
            DataTable dt2 = s.Select();
            dataGridView1.DataSource = dt2;
        }



        //update
        private void sbtn3_Click(object sender, EventArgs e)
        {

            if (scb6.Text == "" || scb7.Text == "" || scb8.Text == "" || scb9.Text == "" || snud5.Text == "" || snud6.Text == "" || snud7.Text == "" || snud8.Text == "")
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                s.SubjectID = int.Parse(stxt2.Text);
                s.OfferedYear = scb6.Text;
                s.OfferedSemester = scb7.Text;
                s.SubjectName = scb8.Text;
                s.SubjectCode = scb9.Text;
                s.NoofLecHours = Convert.ToInt32(this.snud5.Value);
                s.NoofTuteHours = Convert.ToInt32(this.snud6.Value);
                s.NoofLabHours = Convert.ToInt32(this.snud7.Value);
                s.NoofEvaluationHours = Convert.ToInt32(this.snud8.Value);




                bool success = s.Update(s);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    Clear_Sub();
                }
                else
                {
                    MessageBox.Show("Failed to Updated.Try Again!");
                }
                DataTable dt2 = s.Select();
                dataGridView1.DataSource = dt2;
            }
        }

        private void dgvassetlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvassetlist_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; 
            stxt2.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            scb6.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            scb7.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            scb8.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            scb9.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            snud5.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            snud6.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            snud7.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            snud8.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void sbtn2_Click(object sender, EventArgs e)
        {
            Clear_Sub();
        }

        public void Clear_Sub()
        {

            scb6.Text = "";
            scb7.Text = "";
            scb8.Text = "";
            scb9.Text = "";
            snud1.Text = "";
            snud2.Text = "";
            snud3.Text = "";
            snud4.Text = "";
            scb4.Text = "";
            scb2.Text = "";
            scb3.Text = "";
            scb5.Text = "";
            snud1.Text = "";
            snud2.Text = "";
            snud3.Text = "";
            snud4.Text = "";




        }






    }
}
