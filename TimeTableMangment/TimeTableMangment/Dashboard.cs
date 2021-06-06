using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableMangment
{
    public partial class Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDays);
            openChildForm(new Form2());
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
            moveSidePanel(btnSubject);
            openChildForm(new Lecturer());

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
            if(isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if(panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width <= 61)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLecturer);
            openChildForm(new Lecturer());
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStudent);
            openChildForm(new Student());
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLocation);
            openChildForm(new location());
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTags);
            openChildForm(new Student());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDashboard);
            openChildForm(new Statistics());
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("hh:mm:ss");
        }

        private void moveUpPanel(Control btn)
        {
            panelUp.Width = btn.Width;
            panelUp.Left = btn.Left;
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            moveUpPanel(btnSession);
            openChildForm(new Session());
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            moveUpPanel(btnRoom);
            openChildForm(new rooms());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            moveUpPanel(btnAdvanced);
            openChildForm(new Advanced());
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            moveUpPanel(btnGenarate);
            openChildForm(new notAvailable());
        }

        private void btnMins_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                panelContainer.Controls.Add(childForm);
                panelContainer.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
