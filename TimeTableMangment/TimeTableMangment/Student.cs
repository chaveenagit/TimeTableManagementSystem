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
    public partial class Student : Form
    {
        int PanelWidth;
        bool isCollapsed;

        Asset c = new Asset();
        Tags t = new Tags();

        public Student()
        {
            InitializeComponent();
            timerTime.Start();
            //PanelWidth = panelLeft.Width;
            isCollapsed = false;
            DataTable dt = c.Select(); //table autofill when page loading
            dgvassetlist.DataSource = dt;

            DataTable dt2 = t.Select();
            dgvasselist2.DataSource = dt2;

            txtid.Enabled = false;
            txtTID.Enabled = false;
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;




        }
        



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
            //moveSidePanel(btnSubject);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(isCollapsed)
            //{
            //    panelLeft.Width = panelLeft.Width + 10;
            //    if(panelLeft.Width >= PanelWidth)
            //    {
            //        timer1.Stop();
            //        isCollapsed = false;
            //        this.Refresh();
            //    }
            //}
            //else
            //{
            //    panelLeft.Width = panelLeft.Width - 10;
            //    if(panelLeft.Width <= 61)
            //    {
            //        timer1.Stop();
            //        isCollapsed = true;
            //        this.Refresh();
            //    }
            //}
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            //panelSide.Top = btn.Top;
            //panelSide.Height = btn.Height;
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnLecturer);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnStudent);
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnLocation);
            //locationUI1.BringToFront();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnTags);
            //openChildForm(new TagsM());
        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel10.Controls.Add(childForm);
                panel10.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnDashboard);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //labelTime.Text = dt.ToString("hh:mm:ss");
        }

        private void moveUpPanel(Control btn)
        {
            //panelUp.Width = btn.Width;
            //panelUp.Left = btn.Left;
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            //moveUpPanel(btnSession);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            //moveUpPanel(btnRoom);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //moveUpPanel(btnAdvanced);
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            //moveUpPanel(btnGenarate);
        }

        private void btnMins_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
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

        private void locationUI1_Load(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tab1.BackColor = Color.MistyRose;
            //tab2.BackColor = Color.MistyRose;
            //tab3.BackColor = Color.MistyRose;
            //tab4.BackColor = Color.MistyRose;
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;
        }



        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void locationUI1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab2_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (com1.Text == "" || com2.Text == "" || n1.Text == "" || n2.Text == "" || n3.Text == "" || n4.Text == "" || txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {

                c.AcdYrSem = com1.Text;
                c.Programme = com2.Text;
                c.GrpNo = Convert.ToInt32(this.n1.Value);
                c.NumofStudinMainGrp = Convert.ToInt32(this.n2.Value);
                c.SubGrpNum = Convert.ToInt32(this.n3.Value);
                c.NumofStudinSubGrp = Convert.ToInt32(this.n4.Value);
                c.GrpID = txt1.Text;
                c.SubGrpID = txt2.Text;

                if (com1.Text == "Y1.S1" || com1.Text == "Y1.S2" || com1.Text == "Y2.S1" || com1.Text == "Y2.S2" || com1.Text == "Y3.S1" || com1.Text == "Y3.S2" || com1.Text == "Y4.S1" || com1.Text == "Y4.S2")
                {
                    bool success = c.Insert(c);
                    //bool success = c.Insert(c);
                    if (success == true)
                    {
                        MessageBox.Show("Successfully Inserted");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new record..Try Again!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid acedemic year and semester");
                }
                DataTable dt = c.Select();
                dgvassetlist.DataSource = dt;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            com1.Text = "";
            com2.Text = "";
            n1.Text = "";
            n2.Text = "";
            n3.Text = "";
            n4.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            com3.Text = "";
            com4.Text = "";
            n5.Text = "";
            n6.Text = "";
            n7.Text = "";
            n8.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txtid.Text = "";
            txtsearch.Text = "";
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvassetlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (com3.Text == "" || com4.Text == "" || n5.Text == "" || n6.Text == "" || n7.Text == "" || n8.Text == "" || txt3.Text == "" || txt4.Text == "")
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {
                c.ID = int.Parse(txtid.Text);
                c.AcdYrSem = com3.Text;
                c.Programme = com4.Text;
                c.GrpNo = Convert.ToInt32(this.n5.Value);
                c.NumofStudinMainGrp = Convert.ToInt32(this.n6.Value);
                c.SubGrpNum = Convert.ToInt32(this.n7.Value);
                c.NumofStudinSubGrp = Convert.ToInt32(this.n8.Value);
                c.GrpID = txt3.Text;
                c.SubGrpID = txt4.Text;



                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update..Try Again!");
                }
                DataTable dt = c.Select();
                dgvassetlist.DataSource = dt;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.ID = Convert.ToInt32(txtid.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete..Try Again!");
            }
            DataTable dt = c.Select();
            dgvassetlist.DataSource = dt;           
        }

        private void dgvassetlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtid.Text = dgvassetlist.Rows[rowIndex].Cells[0].Value.ToString();
            com3.Text = dgvassetlist.Rows[rowIndex].Cells[1].Value.ToString();
            com4.Text = dgvassetlist.Rows[rowIndex].Cells[2].Value.ToString();
            n5.Text = dgvassetlist.Rows[rowIndex].Cells[3].Value.ToString();
            n6.Text = dgvassetlist.Rows[rowIndex].Cells[4].Value.ToString();
            n7.Text = dgvassetlist.Rows[rowIndex].Cells[5].Value.ToString();
            n8.Text = dgvassetlist.Rows[rowIndex].Cells[6].Value.ToString();
            txt3.Text = dgvassetlist.Rows[rowIndex].Cells[7].Value.ToString();
            txt4.Text = dgvassetlist.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void btngen_Click(object sender, EventArgs e)
        {
           if(com1.Text == com2.Text)
            {
                txt1.Text = com1.Text.ToString() + "." + com2.Text.ToString() + "." + n1.Value.ToString();
            }
            else
            {
                txt1.Text = com1.Text.ToString()+"." + com2.Text.ToString()+"."  + n1.Value.ToString();
            }

            if (com1.Text == com2.Text)
            {
                txt2.Text = com1.Text.ToString() + "." + com2.Text.ToString() + "." +n1.Value.ToString()+"."+ n3.Value.ToString();
            }
            else
            {
                txt2.Text = com1.Text.ToString() + "." + com2.Text.ToString() + "."  + n1.Value.ToString() + "." + n3.Value.ToString();
            }

        }

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ManageStdTimeTB WHERE ID LIKE '%" + keyword + "%' OR Programme LIKE '%" + keyword + "%' OR GrpID LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvassetlist.DataSource = dt;
        }

        private void btngen2_Click(object sender, EventArgs e)
        {
            if (com3.Text == com4.Text)
            {
                txt3.Text = com3.Text.ToString() + "."+ com4.Text.ToString() + "." + n5.Value.ToString();
            }
            else
            {
                txt3.Text = com3.Text.ToString()+ "." + com4.Text.ToString()+ "."  + n5.Value.ToString();
            }

            if (com3.Text == com4.Text)
            {
                txt4.Text = com3.Text.ToString() + "."+ com4.Text.ToString() + "."  + n5.Value.ToString() + "."+ n7.Value.ToString();
            }
            else
            {
                txt4.Text = com3.Text.ToString() + "."+ com4.Text.ToString() + "."  + n5.Value.ToString() + "."+ n7.Value.ToString();
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dgvasselist2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtTID.Text = dgvasselist2.Rows[rowIndex].Cells[0].Value.ToString();
            txtTName2.Text = dgvasselist2.Rows[rowIndex].Cells[1].Value.ToString();
            txtTCode2.Text = dgvasselist2.Rows[rowIndex].Cells[2].Value.ToString();
            comTRel2.Text = dgvasselist2.Rows[rowIndex].Cells[3].Value.ToString();
            textTComm2.Text = dgvasselist2.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void dgvasselist2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab3_Click(object sender, EventArgs e)
        {
            DataTable dt2 = t.Select();
            dgvasselist2.DataSource = dt2;
        }

        private void tab4_Click(object sender, EventArgs e)
        {
            DataTable dt2 = t.Select();
            dgvasselist2.DataSource = dt2;
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            if (txtTName.Text == "" || txtTCode.Text == "" || comTRelate.Text == "")
            {
                MessageBox.Show("All Fields Are Required except the special comments");

            }
            else
            {

                t.TagName = txtTName.Text;
                t.TagCode = txtTCode.Text;
                t.RelatedTag = comTRelate.Text;
                t.SpecialComments = txtTComment.Text;

                if (comTRelate.Text == "Lecture" || comTRelate.Text == "Tutorial" || comTRelate.Text == "Practical" || comTRelate.Text == "Evaluation" || comTRelate.Text == "Other")
                {

                    bool success = t.Insert(t);
                    if (success == true)
                    {
                        MessageBox.Show("Successfully Inserted");
                        ClearTag();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add new Record..Try Again!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid related tag");
                }
                DataTable dt = t.Select();
                dgvasselist2.DataSource = dt;
            }

        }

        private void btnTClear_Click(object sender, EventArgs e)
        {
            ClearTag();
        }

        public void ClearTag()
        {
            txtTName.Text = "";
            txtTCode.Text = "";
            comTRelate.Text = "";
            txtTComment.Text = "";
            txtSearch2.Text = "";
            txtTID.Text = "";
            txtTName2.Text = "";
            txtTCode2.Text = "";
            comTRel2.Text = "";
            textTComm2.Text = "";
            
        }

        private void btnTClear2_Click(object sender, EventArgs e)
        {
            ClearTag();
        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            if (txtTID.Text == " " || txtTName2.Text == "" || txtTCode2.Text == " " || comTRel2.Text == "")
            {
                MessageBox.Show("All Fields Are Required except the special comments");

            }
            else
            {
                t.ID = int.Parse(txtTID.Text);
                t.TagName= txtTName2.Text;
                t.TagCode = txtTCode2.Text;
                t.RelatedTag = comTRel2.Text;
                t.SpecialComments = textTComm2.Text;
                

                bool success = t.Update(t);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    ClearTag();
                }
                else
                {
                    MessageBox.Show("Failed to Update..Try Again!");
                }
                DataTable dt = t.Select();
                dgvasselist2.DataSource = dt;
            }

        }

        private void btnTDelete_Click(object sender, EventArgs e)
        {
            t.ID = Convert.ToInt32(txtTID.Text);
            bool success = t.Delete(t);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                ClearTag();
            }
            else
            {
                MessageBox.Show("Failed to Deleted..Try Again!");
            }
            DataTable dt = t.Select();
            dgvasselist2.DataSource = dt;
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch2.Text;

            SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ManageTagTB WHERE ID LIKE '%" + keyword + "%' OR TagName LIKE '%" + keyword + "%' OR RelatedTag LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvasselist2.DataSource = dt;

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
