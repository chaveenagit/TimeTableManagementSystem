namespace TimeTableMangment
{
    partial class location
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBuildingId = new System.Windows.Forms.Label();
            this.txtBuildingId = new System.Windows.Forms.TextBox();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.dropBuilding = new System.Windows.Forms.ComboBox();
            this.dropRoomName = new System.Windows.Forms.ComboBox();
            this.lblRoomname = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.dropRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridLocationDetails = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuildingId
            // 
            this.lblBuildingId.AutoSize = true;
            this.lblBuildingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingId.Location = new System.Drawing.Point(33, 54);
            this.lblBuildingId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildingId.Name = "lblBuildingId";
            this.lblBuildingId.Size = new System.Drawing.Size(113, 25);
            this.lblBuildingId.TabIndex = 0;
            this.lblBuildingId.Text = "Building Id";
            // 
            // txtBuildingId
            // 
            this.txtBuildingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingId.Location = new System.Drawing.Point(178, 49);
            this.txtBuildingId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuildingId.Name = "txtBuildingId";
            this.txtBuildingId.ReadOnly = true;
            this.txtBuildingId.Size = new System.Drawing.Size(292, 30);
            this.txtBuildingId.TabIndex = 1;
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.Location = new System.Drawing.Point(33, 120);
            this.lblBuilding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(89, 25);
            this.lblBuilding.TabIndex = 2;
            this.lblBuilding.Text = "Building";
            this.lblBuilding.Click += new System.EventHandler(this.lblBuilding_Click);
            // 
            // dropBuilding
            // 
            this.dropBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropBuilding.FormattingEnabled = true;
            this.dropBuilding.Items.AddRange(new object[] {
            "New Building",
            "Main Building",
            "Faculty of Engineering Building",
            "Faculty of Business Building",
            "Auditorium"});
            this.dropBuilding.Location = new System.Drawing.Point(178, 112);
            this.dropBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.dropBuilding.Name = "dropBuilding";
            this.dropBuilding.Size = new System.Drawing.Size(292, 33);
            this.dropBuilding.TabIndex = 3;
            this.dropBuilding.SelectedIndexChanged += new System.EventHandler(this.dropBuilding_SelectedIndexChanged);
            // 
            // dropRoomName
            // 
            this.dropRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropRoomName.FormattingEnabled = true;
            this.dropRoomName.Items.AddRange(new object[] {
            "B600",
            "B601",
            "NB310",
            "NB320",
            "NB330",
            "En101",
            "En102",
            "BS760",
            "BS761",
            "A510",
            "A511"});
            this.dropRoomName.Location = new System.Drawing.Point(178, 198);
            this.dropRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.dropRoomName.Name = "dropRoomName";
            this.dropRoomName.Size = new System.Drawing.Size(292, 33);
            this.dropRoomName.TabIndex = 5;
            // 
            // lblRoomname
            // 
            this.lblRoomname.AutoSize = true;
            this.lblRoomname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomname.Location = new System.Drawing.Point(26, 206);
            this.lblRoomname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomname.Name = "lblRoomname";
            this.lblRoomname.Size = new System.Drawing.Size(129, 25);
            this.lblRoomname.TabIndex = 4;
            this.lblRoomname.Text = "Room Name";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(178, 285);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(292, 30);
            this.txtCapacity.TabIndex = 7;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(33, 290);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(97, 25);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "Capacity";
            // 
            // dropRoomType
            // 
            this.dropRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropRoomType.FormattingEnabled = true;
            this.dropRoomType.Items.AddRange(new object[] {
            "Lecture Hall",
            "Pc Lab",
            "Engineering Lab"});
            this.dropRoomType.Location = new System.Drawing.Point(178, 369);
            this.dropRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.dropRoomType.Name = "dropRoomType";
            this.dropRoomType.Size = new System.Drawing.Size(292, 33);
            this.dropRoomType.TabIndex = 9;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(33, 377);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(122, 25);
            this.lblRoomType.TabIndex = 8;
            this.lblRoomType.Text = "Room Type";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(22, 482);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 60);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(178, 482);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 60);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(340, 482);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 60);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(22, 591);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(460, 42);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gridLocationDetails
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLocationDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLocationDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocationDetails.GridColor = System.Drawing.SystemColors.Control;
            this.gridLocationDetails.Location = new System.Drawing.Point(537, 87);
            this.gridLocationDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gridLocationDetails.Name = "gridLocationDetails";
            this.gridLocationDetails.RowHeadersWidth = 51;
            this.gridLocationDetails.Size = new System.Drawing.Size(718, 546);
            this.gridLocationDetails.TabIndex = 14;
            this.gridLocationDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLocationDetails_CellContentClick);
            this.gridLocationDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLocationDetails_RowHeaderMouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(618, 37);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 25);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(746, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(425, 30);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1268, 672);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gridLocationDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dropRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.dropRoomName);
            this.Controls.Add(this.lblRoomname);
            this.Controls.Add(this.dropBuilding);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.txtBuildingId);
            this.Controls.Add(this.lblBuildingId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "location";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocationDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuildingId;
        private System.Windows.Forms.TextBox txtBuildingId;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.ComboBox dropBuilding;
        private System.Windows.Forms.ComboBox dropRoomName;
        private System.Windows.Forms.Label lblRoomname;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.ComboBox dropRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridLocationDetails;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

