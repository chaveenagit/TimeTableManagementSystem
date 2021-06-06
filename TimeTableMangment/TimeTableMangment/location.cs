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

    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();
        }

        timetableclass d = new timetableclass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the values from the input fields
            d.Building = dropBuilding.Text;
            d.RoomName = dropRoomName.Text;
            d.Capacity = txtCapacity.Text;
            d.RoomType = dropRoomType.Text;

            //inserting data into the databse usimg Insert method
            bool success = d.Insert(d);

            if (success == true)
            {
                MessageBox.Show("Location details successfully inserted!");
                //call the clear method here
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add Location details.Try again!!");
            }
            //load data into the grid view
            DataTable dt = d.Select();
            gridLocationDetails.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from text boxes
            d.BuildingId = int.Parse(txtBuildingId.Text);
            d.Building = dropBuilding.Text;
            d.RoomName = dropRoomName.Text;
            d.Capacity = txtCapacity.Text;
            d.RoomType = dropRoomType.Text;

            //update data in database
            bool success = d.Update(d);
            if(success == true)
            {
                MessageBox.Show("Location details has been successfully updated!");
                //load data into the grid view
                DataTable dt = d.Select();
                gridLocationDetails.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update location details!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the building id from the database
            d.BuildingId = Convert.ToInt32(txtBuildingId.Text);
            bool success = d.Delete(d);
            if(success == true)
            {
                MessageBox.Show("Location details successfully deleted!");
                //load data into the grid view
                DataTable dt = d.Select();
                gridLocationDetails.DataSource = dt;

                //call the clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Faild to delete!");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load data into the grid view
            DataTable dt = d.Select();
            gridLocationDetails.DataSource = dt;
        }

        //clear the fields
        public void Clear()
        {
            txtBuildingId.Text = " ";
            dropBuilding.Text = " ";
            dropRoomName.Text = " ";
            txtCapacity.Text = " ";
            dropRoomType.Text = " ";
        }

        private void gridLocationDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from the grid view and load into the text fields
            int rowIndex = e.RowIndex;
            txtBuildingId.Text = gridLocationDetails.Rows[rowIndex].Cells[0].Value.ToString();
            dropBuilding.Text = gridLocationDetails.Rows[rowIndex].Cells[1].Value.ToString();
            dropRoomName.Text = gridLocationDetails.Rows[rowIndex].Cells[2].Value.ToString();
            txtCapacity.Text = gridLocationDetails.Rows[rowIndex].Cells[3].Value.ToString();
            dropRoomType.Text = gridLocationDetails.Rows[rowIndex].Cells[4].Value.ToString();

        }
        static string myconn = ConfigurationManager.ConnectionStrings["TimeTablemanagementdbEntities1"].ConnectionString;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(myconn);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM location_table WHERE Building LIKE '%"+keyword+"%' OR RoomName LIKE '%"+keyword+"%' OR Capacity LIKE '%"+keyword+"%' OR RoomType LIKE '%"+keyword+"%'",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridLocationDetails.DataSource = dt;
        }

        private void lblBuilding_Click(object sender, EventArgs e)
        {

        }

        private void dropBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridLocationDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
