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
    public partial class Advanced : Form
    {
        Consecutive c = new Consecutive();
        AssetClasses.Parallel p = new AssetClasses.Parallel();
        NonOverlapping n = new NonOverlapping();

        static string TimeTablemanagementdbEntities1 = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
        SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
        SqlCommand cmd;

        int PanelWidth;
        bool isCollapsed;

        public Advanced()
        {
            InitializeComponent();
            isCollapsed = false;

            DataTable dt = c.Select(); //table autofill when page loading
            dataGridViewCon.DataSource = dt;

            DataTable dt2 = p.Select();
            dataGridViewPar.DataSource = dt2;

            DataTable dt3 = n.Select();
            dataGridViewNon.DataSource = dt3;



            textBoxConID.Enabled = false;
            textBoxParID.Enabled = false;
            textBoxNonID.Enabled = false;
            button1.Enabled = false;
            button6.Enabled = false;
            button2.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Advanced_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeTablemanagementdbDataSet2.SessionMangeTB2' table. You can move, or remove it, as needed.
            this.sessionMangeTB2TableAdapter.Fill(this.timeTablemanagementdbDataSet2.SessionMangeTB2);
            //consecutive session 1
            comboConS1.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT session FROM SessionMangeTB2";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboConS1.Items.Add(dr["session"].ToString());
            }

            //consecutive session 2
            comboConS2.Items.Clear();
            //conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT session FROM SessionMangeTB2";
            cmd.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                comboConS2.Items.Add(dr2["session"].ToString());
            }

            //Parallel session 1
            comboBoxParS1.Items.Clear();
            //conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT session FROM SessionMangeTB2";
            cmd.ExecuteNonQuery();

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd);
            da3.Fill(dt3);

            foreach (DataRow dr3 in dt3.Rows)
            {
                comboBoxParS1.Items.Add(dr3["session"].ToString());
            }

            //Parallel session 2
            comboBoxParS2.Items.Clear();
            //conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT session FROM SessionMangeTB2";
            cmd.ExecuteNonQuery();

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            da4.Fill(dt4);

            foreach (DataRow dr4 in dt4.Rows)
            {
                comboBoxParS2.Items.Add(dr4["session"].ToString());
            }

            //Non Overlapping session 1
            comboBoxNonS1.Items.Clear();
            //conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT session FROM SessionMangeTB2";
            cmd.ExecuteNonQuery();

            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            da5.Fill(dt5);

            foreach (DataRow dr5 in dt5.Rows)
            {
                comboBoxNonS1.Items.Add(dr5["session"].ToString());
            }

            //Non Overlapping session 2
            comboBoxNonS2.Items.Clear();
            //conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT session FROM SessionMangeTB2";
            cmd.ExecuteNonQuery();

            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(cmd);
            da6.Fill(dt6);

            foreach (DataRow dr6 in dt6.Rows)
            {
                comboBoxNonS2.Items.Add(dr6["session"].ToString());
            }

            conn.Close();

            //Checkbox
            //DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            //chkbox.HeaderText = "";
            //chkbox.Width = 30;
            //chkbox.Name = "checkBoxColumn";
            //dataGridViewMulti.Columns.Insert(0, chkbox);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboConS2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxConID.Text = dataGridViewCon.Rows[rowIndex].Cells[0].Value.ToString();
            comboConS1.Text = dataGridViewCon.Rows[rowIndex].Cells[1].Value.ToString();
            comboConS2.Text = dataGridViewCon.Rows[rowIndex].Cells[2].Value.ToString();
            
        }

        private void tabPageConsecutive_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridViewCon.DataSource = dt;
        }

        private void tabPageParallel_Click(object sender, EventArgs e)
        {
            DataTable dt = p.Select();
            dataGridViewPar.DataSource = dt;
        }

        private void tabPageNon_Click(object sender, EventArgs e)
        {
            DataTable dt = n.Select();
            dataGridViewNon.DataSource = dt;
        }

        public void ClearCon()
        {
            textBoxConID.Text = "";
            comboConS1.Text = "";
            comboConS2.Text = "";
        }

        private void btnConAdd_Click(object sender, EventArgs e)
        {
            if (comboConS1.Text == "" || comboConS2.Text == "" )
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {

                c.conSession1 = comboConS1.Text;
                c.conSession2 = comboConS2.Text;
                

                
                    bool success = c.Insert(c);
                    
                    if (success == true)
                    {
                        MessageBox.Show("Successfully Inserted");
                        ClearCon();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new record..Try Again!");
                    }
                
                DataTable dt = c.Select();
                dataGridViewCon.DataSource = dt;
            }
        }

        private void btnClearCon_Click(object sender, EventArgs e)
        {
            ClearCon();
        }

        private void btnConUp_Click(object sender, EventArgs e)
        {
            if (comboConS1.Text == "" || comboConS2.Text == "" )
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {
                c.IDcon = int.Parse(textBoxConID.Text);
                c.conSession1 = comboConS1.Text;
                c.conSession2 = comboConS2.Text;
                

                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    ClearCon();
                }
                else
                {
                    MessageBox.Show("Failed to Update..Try Again!");
                }
                DataTable dt = c.Select();
                dataGridViewCon.DataSource = dt;
            }
        }

        private void btnConDel_Click(object sender, EventArgs e)
        {
            c.IDcon = Convert.ToInt32(textBoxConID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                ClearCon();
            }
            else
            {
                MessageBox.Show("Failed to Delete..Try Again!");
            }
            DataTable dt = c.Select();
            dataGridViewCon.DataSource = dt;
        }

        private void textBoxConSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxConSearch.Text;

            //SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ConsecutiveSessions WHERE IDcon LIKE '%" + keyword + "%' OR conSession1 LIKE '%" + keyword + "%' OR conSession2 LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewCon.DataSource = dt;
        }

        public void ClearPar()
        {
            textBoxParID.Text = "";
            comboBoxParS1.Text = "";
            comboBoxParS2.Text = "";
            numericUpDownduration.Text = "";
            
        }

        private void btnParAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxParS1.Text == "" || comboBoxParS2.Text == "" || numericUpDownduration.Text == "" )
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {

                p.parSession1 = comboBoxParS1.Text;
                p.parSession2 = comboBoxParS2.Text;
                p.duration = Convert.ToInt32(this.numericUpDownduration.Value);

                bool success = p.Insert(p);
                    
                if (success == true)
                {
                      MessageBox.Show("Successfully Inserted");
                      ClearPar();
                }

                else
                {
                      MessageBox.Show("Failed to add new record..Try Again!");
                }
                
                DataTable dt = p.Select();
                dataGridViewPar.DataSource = dt;
            }
        }

        private void btnParClear_Click(object sender, EventArgs e)
        {
            ClearPar();
        }

        private void btnParUp_Click(object sender, EventArgs e)
        {
            if (comboBoxParS1.Text == "" || comboBoxParS2.Text == "" )
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {
                p.IDpar = int.Parse(textBoxParID.Text);
                p.parSession1 = comboBoxParS1.Text;
                p.parSession2 = comboBoxParS2.Text;
                p.duration = Convert.ToInt32(this.numericUpDownduration.Value);


                bool success = p.Update(p);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    ClearPar();
                }
                else
                {
                    MessageBox.Show("Failed to Update..Try Again!");
                }
                DataTable dt = p.Select();
                dataGridViewPar.DataSource = dt;
            }
        }

        private void btnParDel_Click(object sender, EventArgs e)
        {
            p.IDpar = Convert.ToInt32(textBoxParID.Text);
            bool success = p.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                ClearPar();
            }
            else
            {
                MessageBox.Show("Failed to Delete..Try Again!");
            }
            DataTable dt = p.Select();
            dataGridViewPar.DataSource = dt;
        }

        private void dataGridViewPar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxParID.Text = dataGridViewPar.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxParS1.Text = dataGridViewPar.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxParS2.Text = dataGridViewPar.Rows[rowIndex].Cells[2].Value.ToString();
            numericUpDownduration.Text = dataGridViewPar.Rows[rowIndex].Cells[3].Value.ToString();
            
        }

        private void textBoxParSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxParSearch.Text;

            //SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ParallelSessions WHERE parSession1 LIKE '%" + keyword + "%' OR parSession2 LIKE '%" + keyword + "%' OR duration LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewPar.DataSource = dt;
        }

        public void ClearNon()
        {
            textBoxNonID.Text = "";
            comboBoxNonS1.Text = "";
            comboBoxNonS2.Text = "";
           
        }

        private void btnNonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxNonS1.Text == "" || comboBoxNonS2.Text == "" )
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {

                n.nonSession1 = comboBoxNonS1.Text;
                n.nonSession2 = comboBoxNonS2.Text;
                

                bool success = n.Insert(n);
                 
                if (success == true)
                {
                        MessageBox.Show("Successfully Inserted");
                        ClearNon();
                }
                else
                {
                        MessageBox.Show("Failed to add new record..Try Again!");
                }
                
                DataTable dt = n.Select();
                dataGridViewNon.DataSource = dt;
            }
        }

        private void btnNonClear_Click(object sender, EventArgs e)
        {
            ClearNon();
        }

        private void btnNonUp_Click(object sender, EventArgs e)
        {
            if (comboBoxNonS1.Text == "" || comboBoxNonS2.Text == "" )
            {
                MessageBox.Show("All Fields Are Required");

            }
            else
            {
                n.IDnon = int.Parse(textBoxNonID.Text);
                n.nonSession1 = comboBoxNonS1.Text;
                n.nonSession2 = comboBoxNonS2.Text;
                
                bool success = n.Update(n);

                if (success == true)
                {
                    MessageBox.Show("Successfully Updated");
                    ClearNon();
                }
                else
                {
                    MessageBox.Show("Failed to Update..Try Again!");
                }
                DataTable dt = n.Select();
                dataGridViewNon.DataSource = dt;
            }
        }

        private void btnNonDel_Click(object sender, EventArgs e)
        {
            n.IDnon = Convert.ToInt32(textBoxNonID.Text);
            bool success = n.Delete(n);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");
                ClearNon();
            }
            else
            {
                MessageBox.Show("Failed to Delete..Try Again!");
            }
            DataTable dt = n.Select();
            dataGridViewNon.DataSource = dt;
        }

        private void dataGridViewNon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewNon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxNonID.Text = dataGridViewNon.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxNonS1.Text = dataGridViewNon.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxNonS2.Text = dataGridViewNon.Rows[rowIndex].Cells[2].Value.ToString();
           
        }

        private void textBoxNonSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxNonSearch.Text;

            //SqlConnection conn = new SqlConnection(TimeTablemanagementdbEntities1);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NonOverlappingSessions WHERE IDnon LIKE '%" + keyword + "%' OR nonSession1 LIKE '%" + keyword + "%' OR nonSession2 LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewNon.DataSource = dt;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPageMNon_Click(object sender, EventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNon_Click(object sender, EventArgs e)
        {
           
        }
    }
}
