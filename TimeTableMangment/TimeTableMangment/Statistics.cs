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
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeTableMangment
{
    public partial class Statistics : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;
        private DataSet dataTable;
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            lecFacChart();
            yearSubChart();
            depStudentChart();
        }

        private void lecFacChart()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Faculty as fac,COUNT(EmployeeID) as eId FROM LecManageTB2 GROUP BY Faculty", conn);
            adapter.Fill(ds,"fac");
            LecturesBar.DataSource = ds.Tables["fac"];

            LecturesBar.Series["lecOfFaculty"].XValueMember = "fac";
            LecturesBar.Series["lecOfFaculty"].YValueMembers = "eID";
            LecturesBar.Series["lecOfFaculty"].ChartType = SeriesChartType.Bar;

            LecturesBar.DataBind();
            conn.Close();
        }

        private void yearSubChart()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT OfferedYear as year,COUNT(SubjectID) as sId FROM SubManageTB2 GROUP BY OfferedYear",conn);
            adapter.Fill(ds, "year");
            yearSubBar.DataSource = ds.Tables["year"];

            yearSubBar.Series["yearSub"].XValueMember = "year";
            yearSubBar.Series["yearSub"].YValueMembers = "sId";
            yearSubBar.Series["yearSub"].ChartType = SeriesChartType.Bar;

            yearSubBar.DataBind();
            conn.Close();

        }

        private void lecDeptPie()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Department as dep,COUNT(EmployeeID) as eId FROM LecManageTB2 GROUP BY Department", conn);
            adapter.Fill(ds, "eId");
            depLecPie.DataSource = ds.Tables["eId"];

            depLecPie.Series["lecFacPie"].XValueMember = "dep";
            depLecPie.Series["lecFacPie"].YValueMembers = "eId";
            depLecPie.Series["lecFacPie"].ChartType = SeriesChartType.Pie;
        }

        private void depStudentChart()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Programme as pro,SUM(NumofStudinMainGrp) as stu FROM ManageStdTimeTB GROUP BY Programme", conn);
            adapter.Fill(ds, "pro");
            studentDepChart.DataSource = ds.Tables["pro"];

            studentDepChart.Series["depStudent"].XValueMember = "pro";
            studentDepChart.Series["depStudent"].YValueMembers = "stu";
            studentDepChart.Series["depStudent"].ChartType = SeriesChartType.Bar;
        }

        private void chartLocation_Click(object sender, EventArgs e)
        {

        }

        private void depLecPie_Click(object sender, EventArgs e)
        {

        }

        private void btnGenaratePie_Click(object sender, EventArgs e)
        {
            lecDeptPie();
        }

       
    }
}
