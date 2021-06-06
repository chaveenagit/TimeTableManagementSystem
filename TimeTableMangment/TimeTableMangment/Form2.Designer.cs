namespace TimeTableMangment
{
    partial class Form2
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
            this.dataGridViewDays = new System.Windows.Forms.DataGridView();
            this.Addno = new System.Windows.Forms.Button();
            this.Clearday = new System.Windows.Forms.Button();
            this.Editday = new System.Windows.Forms.Button();
            this.Addday = new System.Windows.Forms.Button();
            this.dataGridViewNoofwd = new System.Windows.Forms.DataGridView();
            this.Deleteday = new System.Windows.Forms.Button();
            this.dataGridViewSlots = new System.Windows.Forms.DataGridView();
            this.Slotremove = new System.Windows.Forms.Button();
            this.Slotuadd = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtworkingtime = new System.Windows.Forms.TextBox();
            this.dataGridViewWorktime = new System.Windows.Forms.DataGridView();
            this.Cleartime = new System.Windows.Forms.Button();
            this.Deletetime = new System.Windows.Forms.Button();
            this.Edittime = new System.Windows.Forms.Button();
            this.Addtime = new System.Windows.Forms.Button();
            this.UpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.UpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txthour = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Slotupdate = new System.Windows.Forms.Button();
            this.Slottype = new System.Windows.Forms.ComboBox();
            this.Removeno = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Selectnumber = new System.Windows.Forms.ComboBox();
            this.Editno = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Day7 = new System.Windows.Forms.ComboBox();
            this.Day6 = new System.Windows.Forms.ComboBox();
            this.Day5 = new System.Windows.Forms.ComboBox();
            this.Day4 = new System.Windows.Forms.ComboBox();
            this.Day3 = new System.Windows.Forms.ComboBox();
            this.Day2 = new System.Windows.Forms.ComboBox();
            this.Day1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewSDt = new System.Windows.Forms.DataGridView();
            this.txtdaysdt = new System.Windows.Forms.TextBox();
            this.Searchsdt = new System.Windows.Forms.Button();
            this.Deletesdt = new System.Windows.Forms.Button();
            this.Editsdt = new System.Windows.Forms.Button();
            this.Addsdt = new System.Windows.Forms.Button();
            this.txtEDsdt = new System.Windows.Forms.TextBox();
            this.txtStsdt = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoofwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorktime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHours)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDays
            // 
            this.dataGridViewDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDays.Location = new System.Drawing.Point(649, 137);
            this.dataGridViewDays.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDays.Name = "dataGridViewDays";
            this.dataGridViewDays.RowHeadersWidth = 51;
            this.dataGridViewDays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDays.Size = new System.Drawing.Size(507, 390);
            this.dataGridViewDays.TabIndex = 18;
            this.dataGridViewDays.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDays_CellClick);
            // 
            // Addno
            // 
            this.Addno.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Addno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addno.ForeColor = System.Drawing.Color.Black;
            this.Addno.Location = new System.Drawing.Point(245, 235);
            this.Addno.Margin = new System.Windows.Forms.Padding(4);
            this.Addno.Name = "Addno";
            this.Addno.Size = new System.Drawing.Size(213, 55);
            this.Addno.TabIndex = 16;
            this.Addno.Text = "Add";
            this.Addno.UseVisualStyleBackColor = false;
            this.Addno.Click += new System.EventHandler(this.Addno_Click);
            // 
            // Clearday
            // 
            this.Clearday.BackColor = System.Drawing.Color.Goldenrod;
            this.Clearday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearday.ForeColor = System.Drawing.Color.Black;
            this.Clearday.Location = new System.Drawing.Point(425, 472);
            this.Clearday.Margin = new System.Windows.Forms.Padding(4);
            this.Clearday.Name = "Clearday";
            this.Clearday.Size = new System.Drawing.Size(160, 55);
            this.Clearday.TabIndex = 10;
            this.Clearday.Text = "Clear";
            this.Clearday.UseVisualStyleBackColor = false;
            this.Clearday.Click += new System.EventHandler(this.button8_Click);
            // 
            // Editday
            // 
            this.Editday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Editday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editday.ForeColor = System.Drawing.Color.Black;
            this.Editday.Location = new System.Drawing.Point(425, 247);
            this.Editday.Margin = new System.Windows.Forms.Padding(4);
            this.Editday.Name = "Editday";
            this.Editday.Size = new System.Drawing.Size(160, 55);
            this.Editday.TabIndex = 8;
            this.Editday.Text = "Edit";
            this.Editday.UseVisualStyleBackColor = false;
            this.Editday.Click += new System.EventHandler(this.button6_Click);
            // 
            // Addday
            // 
            this.Addday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Addday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addday.ForeColor = System.Drawing.Color.Black;
            this.Addday.Location = new System.Drawing.Point(425, 144);
            this.Addday.Margin = new System.Windows.Forms.Padding(4);
            this.Addday.Name = "Addday";
            this.Addday.Size = new System.Drawing.Size(160, 55);
            this.Addday.TabIndex = 7;
            this.Addday.Text = "Add";
            this.Addday.UseVisualStyleBackColor = false;
            this.Addday.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewNoofwd
            // 
            this.dataGridViewNoofwd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoofwd.Location = new System.Drawing.Point(355, 348);
            this.dataGridViewNoofwd.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNoofwd.Name = "dataGridViewNoofwd";
            this.dataGridViewNoofwd.RowHeadersWidth = 51;
            this.dataGridViewNoofwd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNoofwd.Size = new System.Drawing.Size(531, 218);
            this.dataGridViewNoofwd.TabIndex = 17;
            this.dataGridViewNoofwd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNoofwd_CellClick);
            // 
            // Deleteday
            // 
            this.Deleteday.BackColor = System.Drawing.Color.Crimson;
            this.Deleteday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleteday.ForeColor = System.Drawing.Color.Black;
            this.Deleteday.Location = new System.Drawing.Point(425, 357);
            this.Deleteday.Margin = new System.Windows.Forms.Padding(4);
            this.Deleteday.Name = "Deleteday";
            this.Deleteday.Size = new System.Drawing.Size(160, 55);
            this.Deleteday.TabIndex = 9;
            this.Deleteday.Text = "Delete";
            this.Deleteday.UseVisualStyleBackColor = false;
            this.Deleteday.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridViewSlots
            // 
            this.dataGridViewSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlots.Location = new System.Drawing.Point(316, 262);
            this.dataGridViewSlots.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSlots.Name = "dataGridViewSlots";
            this.dataGridViewSlots.RowHeadersWidth = 51;
            this.dataGridViewSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSlots.Size = new System.Drawing.Size(619, 348);
            this.dataGridViewSlots.TabIndex = 22;
            this.dataGridViewSlots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSlots_CellClick);
            // 
            // Slotremove
            // 
            this.Slotremove.BackColor = System.Drawing.Color.Crimson;
            this.Slotremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slotremove.Location = new System.Drawing.Point(752, 165);
            this.Slotremove.Margin = new System.Windows.Forms.Padding(4);
            this.Slotremove.Name = "Slotremove";
            this.Slotremove.Size = new System.Drawing.Size(183, 53);
            this.Slotremove.TabIndex = 20;
            this.Slotremove.Text = "Remove Slot";
            this.Slotremove.UseVisualStyleBackColor = false;
            this.Slotremove.Click += new System.EventHandler(this.button18_Click);
            // 
            // Slotuadd
            // 
            this.Slotuadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Slotuadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slotuadd.Location = new System.Drawing.Point(316, 165);
            this.Slotuadd.Margin = new System.Windows.Forms.Padding(4);
            this.Slotuadd.Name = "Slotuadd";
            this.Slotuadd.Size = new System.Drawing.Size(181, 53);
            this.Slotuadd.TabIndex = 19;
            this.Slotuadd.Text = "Add Slot";
            this.Slotuadd.UseVisualStyleBackColor = false;
            this.Slotuadd.Click += new System.EventHandler(this.Slotuadd_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Thistle;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(424, 98);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(176, 23);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Time Slot :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Thistle;
            this.tabPage3.Controls.Add(this.txtworkingtime);
            this.tabPage3.Controls.Add(this.dataGridViewWorktime);
            this.tabPage3.Controls.Add(this.Cleartime);
            this.tabPage3.Controls.Add(this.Deletetime);
            this.tabPage3.Controls.Add(this.Edittime);
            this.tabPage3.Controls.Add(this.Addtime);
            this.tabPage3.Controls.Add(this.UpDownMinutes);
            this.tabPage3.Controls.Add(this.UpDownHours);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.txthour);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1388, 793);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Working Time";
            // 
            // txtworkingtime
            // 
            this.txtworkingtime.BackColor = System.Drawing.Color.Thistle;
            this.txtworkingtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtworkingtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtworkingtime.Location = new System.Drawing.Point(265, 95);
            this.txtworkingtime.Margin = new System.Windows.Forms.Padding(4);
            this.txtworkingtime.Name = "txtworkingtime";
            this.txtworkingtime.Size = new System.Drawing.Size(291, 30);
            this.txtworkingtime.TabIndex = 20;
            this.txtworkingtime.Text = "Working Time Per Day :";
            this.txtworkingtime.TextChanged += new System.EventHandler(this.txtworkingtime_TextChanged);
            // 
            // dataGridViewWorktime
            // 
            this.dataGridViewWorktime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorktime.Location = new System.Drawing.Point(246, 253);
            this.dataGridViewWorktime.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewWorktime.Name = "dataGridViewWorktime";
            this.dataGridViewWorktime.RowHeadersWidth = 51;
            this.dataGridViewWorktime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWorktime.Size = new System.Drawing.Size(792, 373);
            this.dataGridViewWorktime.TabIndex = 18;
            this.dataGridViewWorktime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorktime_CellClick);
            // 
            // Cleartime
            // 
            this.Cleartime.BackColor = System.Drawing.Color.Goldenrod;
            this.Cleartime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cleartime.ForeColor = System.Drawing.Color.Black;
            this.Cleartime.Location = new System.Drawing.Point(882, 159);
            this.Cleartime.Margin = new System.Windows.Forms.Padding(4);
            this.Cleartime.Name = "Cleartime";
            this.Cleartime.Size = new System.Drawing.Size(179, 53);
            this.Cleartime.TabIndex = 18;
            this.Cleartime.Text = "Clear";
            this.Cleartime.UseVisualStyleBackColor = false;
            this.Cleartime.Click += new System.EventHandler(this.Cleartime_Click);
            // 
            // Deletetime
            // 
            this.Deletetime.BackColor = System.Drawing.Color.Crimson;
            this.Deletetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletetime.ForeColor = System.Drawing.Color.Black;
            this.Deletetime.Location = new System.Drawing.Point(658, 159);
            this.Deletetime.Margin = new System.Windows.Forms.Padding(4);
            this.Deletetime.Name = "Deletetime";
            this.Deletetime.Size = new System.Drawing.Size(179, 53);
            this.Deletetime.TabIndex = 17;
            this.Deletetime.Text = "Delete";
            this.Deletetime.UseVisualStyleBackColor = false;
            this.Deletetime.Click += new System.EventHandler(this.Deletetime_Click);
            // 
            // Edittime
            // 
            this.Edittime.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Edittime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edittime.ForeColor = System.Drawing.Color.Black;
            this.Edittime.Location = new System.Drawing.Point(431, 159);
            this.Edittime.Margin = new System.Windows.Forms.Padding(4);
            this.Edittime.Name = "Edittime";
            this.Edittime.Size = new System.Drawing.Size(179, 53);
            this.Edittime.TabIndex = 16;
            this.Edittime.Text = "Edit";
            this.Edittime.UseVisualStyleBackColor = false;
            this.Edittime.Click += new System.EventHandler(this.Edittime_Click);
            // 
            // Addtime
            // 
            this.Addtime.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Addtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addtime.ForeColor = System.Drawing.Color.Black;
            this.Addtime.Location = new System.Drawing.Point(217, 159);
            this.Addtime.Margin = new System.Windows.Forms.Padding(4);
            this.Addtime.Name = "Addtime";
            this.Addtime.Size = new System.Drawing.Size(179, 53);
            this.Addtime.TabIndex = 15;
            this.Addtime.Text = "Add";
            this.Addtime.UseVisualStyleBackColor = false;
            this.Addtime.Click += new System.EventHandler(this.Addtime_Click);
            // 
            // UpDownMinutes
            // 
            this.UpDownMinutes.Location = new System.Drawing.Point(933, 95);
            this.UpDownMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.UpDownMinutes.Name = "UpDownMinutes";
            this.UpDownMinutes.Size = new System.Drawing.Size(78, 30);
            this.UpDownMinutes.TabIndex = 14;
            // 
            // UpDownHours
            // 
            this.UpDownHours.Location = new System.Drawing.Point(710, 93);
            this.UpDownHours.Margin = new System.Windows.Forms.Padding(4);
            this.UpDownHours.Name = "UpDownHours";
            this.UpDownHours.Size = new System.Drawing.Size(64, 30);
            this.UpDownHours.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Thistle;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(832, 93);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 30);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Minutes :";
            // 
            // txthour
            // 
            this.txthour.BackColor = System.Drawing.Color.Thistle;
            this.txthour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthour.Location = new System.Drawing.Point(613, 95);
            this.txthour.Margin = new System.Windows.Forms.Padding(4);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(77, 23);
            this.txthour.TabIndex = 11;
            this.txthour.Text = "Hours :";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Thistle;
            this.tabPage4.Controls.Add(this.Slotupdate);
            this.tabPage4.Controls.Add(this.Slottype);
            this.tabPage4.Controls.Add(this.dataGridViewSlots);
            this.tabPage4.Controls.Add(this.Slotremove);
            this.tabPage4.Controls.Add(this.Slotuadd);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1388, 793);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Time Slots";
            // 
            // Slotupdate
            // 
            this.Slotupdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Slotupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slotupdate.Location = new System.Drawing.Point(527, 165);
            this.Slotupdate.Margin = new System.Windows.Forms.Padding(4);
            this.Slotupdate.Name = "Slotupdate";
            this.Slotupdate.Size = new System.Drawing.Size(181, 53);
            this.Slotupdate.TabIndex = 24;
            this.Slotupdate.Text = "Update Slot";
            this.Slotupdate.UseVisualStyleBackColor = false;
            this.Slotupdate.Click += new System.EventHandler(this.Slotupdate_Click);
            // 
            // Slottype
            // 
            this.Slottype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slottype.FormattingEnabled = true;
            this.Slottype.Items.AddRange(new object[] {
            "01.00",
            "00.30"});
            this.Slottype.Location = new System.Drawing.Point(608, 88);
            this.Slottype.Margin = new System.Windows.Forms.Padding(4);
            this.Slottype.Name = "Slottype";
            this.Slottype.Size = new System.Drawing.Size(247, 33);
            this.Slottype.TabIndex = 23;
            this.Slottype.Text = "Slot Type";
            // 
            // Removeno
            // 
            this.Removeno.BackColor = System.Drawing.Color.Crimson;
            this.Removeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removeno.ForeColor = System.Drawing.Color.Black;
            this.Removeno.Location = new System.Drawing.Point(777, 235);
            this.Removeno.Margin = new System.Windows.Forms.Padding(4);
            this.Removeno.Name = "Removeno";
            this.Removeno.Size = new System.Drawing.Size(213, 55);
            this.Removeno.TabIndex = 11;
            this.Removeno.Text = "Remove";
            this.Removeno.UseVisualStyleBackColor = false;
            this.Removeno.Click += new System.EventHandler(this.Removeno_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "";
            this.tabPage1.BackColor = System.Drawing.Color.Thistle;
            this.tabPage1.Controls.Add(this.Selectnumber);
            this.tabPage1.Controls.Add(this.dataGridViewNoofwd);
            this.tabPage1.Controls.Add(this.Addno);
            this.tabPage1.Controls.Add(this.Removeno);
            this.tabPage1.Controls.Add(this.Editno);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1388, 793);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "No Of Working Days";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Selectnumber
            // 
            this.Selectnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectnumber.FormattingEnabled = true;
            this.Selectnumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.Selectnumber.Location = new System.Drawing.Point(693, 115);
            this.Selectnumber.Margin = new System.Windows.Forms.Padding(4);
            this.Selectnumber.Name = "Selectnumber";
            this.Selectnumber.Size = new System.Drawing.Size(297, 33);
            this.Selectnumber.TabIndex = 22;
            this.Selectnumber.Text = "Selelct Number";
            // 
            // Editno
            // 
            this.Editno.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Editno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editno.ForeColor = System.Drawing.Color.Black;
            this.Editno.Location = new System.Drawing.Point(506, 235);
            this.Editno.Margin = new System.Windows.Forms.Padding(4);
            this.Editno.Name = "Editno";
            this.Editno.Size = new System.Drawing.Size(213, 55);
            this.Editno.TabIndex = 10;
            this.Editno.Text = "Edit";
            this.Editno.UseVisualStyleBackColor = false;
            this.Editno.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(255, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 34);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "No of Working Days Per Week :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Thistle;
            this.tabPage2.Controls.Add(this.Day7);
            this.tabPage2.Controls.Add(this.Day6);
            this.tabPage2.Controls.Add(this.Day5);
            this.tabPage2.Controls.Add(this.Day4);
            this.tabPage2.Controls.Add(this.Day3);
            this.tabPage2.Controls.Add(this.Day2);
            this.tabPage2.Controls.Add(this.Day1);
            this.tabPage2.Controls.Add(this.dataGridViewDays);
            this.tabPage2.Controls.Add(this.Clearday);
            this.tabPage2.Controls.Add(this.Deleteday);
            this.tabPage2.Controls.Add(this.Editday);
            this.tabPage2.Controls.Add(this.Addday);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1388, 793);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Working Days";
            // 
            // Day7
            // 
            this.Day7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day7.FormattingEnabled = true;
            this.Day7.Items.AddRange(new object[] {
            "Sunday",
            "None"});
            this.Day7.Location = new System.Drawing.Point(101, 533);
            this.Day7.Margin = new System.Windows.Forms.Padding(4);
            this.Day7.Name = "Day7";
            this.Day7.Size = new System.Drawing.Size(247, 33);
            this.Day7.TabIndex = 27;
            this.Day7.Text = "Day 7";
            this.Day7.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // Day6
            // 
            this.Day6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day6.FormattingEnabled = true;
            this.Day6.Items.AddRange(new object[] {
            "Saturday",
            "None"});
            this.Day6.Location = new System.Drawing.Point(101, 461);
            this.Day6.Margin = new System.Windows.Forms.Padding(4);
            this.Day6.Name = "Day6";
            this.Day6.Size = new System.Drawing.Size(247, 33);
            this.Day6.TabIndex = 26;
            this.Day6.Text = "Day 6";
            // 
            // Day5
            // 
            this.Day5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day5.FormattingEnabled = true;
            this.Day5.Items.AddRange(new object[] {
            "Friday",
            "None"});
            this.Day5.Location = new System.Drawing.Point(101, 390);
            this.Day5.Margin = new System.Windows.Forms.Padding(4);
            this.Day5.Name = "Day5";
            this.Day5.Size = new System.Drawing.Size(247, 33);
            this.Day5.TabIndex = 25;
            this.Day5.Text = "Day 5";
            // 
            // Day4
            // 
            this.Day4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day4.FormattingEnabled = true;
            this.Day4.Items.AddRange(new object[] {
            "Thursday",
            "None"});
            this.Day4.Location = new System.Drawing.Point(101, 315);
            this.Day4.Margin = new System.Windows.Forms.Padding(4);
            this.Day4.Name = "Day4";
            this.Day4.Size = new System.Drawing.Size(247, 33);
            this.Day4.TabIndex = 24;
            this.Day4.Text = "Day 4";
            // 
            // Day3
            // 
            this.Day3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day3.FormattingEnabled = true;
            this.Day3.Items.AddRange(new object[] {
            "Wednesday",
            "None"});
            this.Day3.Location = new System.Drawing.Point(101, 238);
            this.Day3.Margin = new System.Windows.Forms.Padding(4);
            this.Day3.Name = "Day3";
            this.Day3.Size = new System.Drawing.Size(247, 33);
            this.Day3.TabIndex = 23;
            this.Day3.Text = "Day 3";
            // 
            // Day2
            // 
            this.Day2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day2.FormattingEnabled = true;
            this.Day2.Items.AddRange(new object[] {
            "Tuesday",
            "None"});
            this.Day2.Location = new System.Drawing.Point(101, 166);
            this.Day2.Margin = new System.Windows.Forms.Padding(4);
            this.Day2.Name = "Day2";
            this.Day2.Size = new System.Drawing.Size(247, 33);
            this.Day2.TabIndex = 22;
            this.Day2.Text = "Day 2";
            // 
            // Day1
            // 
            this.Day1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day1.FormattingEnabled = true;
            this.Day1.Items.AddRange(new object[] {
            "Monday",
            "None"});
            this.Day1.Location = new System.Drawing.Point(101, 103);
            this.Day1.Margin = new System.Windows.Forms.Padding(4);
            this.Day1.Name = "Day1";
            this.Day1.Size = new System.Drawing.Size(247, 33);
            this.Day1.TabIndex = 21;
            this.Day1.Text = "Day 1";
            this.Day1.SelectedIndexChanged += new System.EventHandler(this.Slectstl_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1396, 831);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Thistle;
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.dataGridViewSDt);
            this.tabPage5.Controls.Add(this.txtdaysdt);
            this.tabPage5.Controls.Add(this.Searchsdt);
            this.tabPage5.Controls.Add(this.Deletesdt);
            this.tabPage5.Controls.Add(this.Editsdt);
            this.tabPage5.Controls.Add(this.Addsdt);
            this.tabPage5.Controls.Add(this.txtEDsdt);
            this.tabPage5.Controls.Add(this.txtStsdt);
            this.tabPage5.Controls.Add(this.txtsid);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.textBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1388, 793);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Session Date And Time";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // dataGridViewSDt
            // 
            this.dataGridViewSDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSDt.Location = new System.Drawing.Point(245, 397);
            this.dataGridViewSDt.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSDt.Name = "dataGridViewSDt";
            this.dataGridViewSDt.RowHeadersWidth = 51;
            this.dataGridViewSDt.Size = new System.Drawing.Size(714, 207);
            this.dataGridViewSDt.TabIndex = 26;
            // 
            // txtdaysdt
            // 
            this.txtdaysdt.Location = new System.Drawing.Point(652, 121);
            this.txtdaysdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtdaysdt.Name = "txtdaysdt";
            this.txtdaysdt.Size = new System.Drawing.Size(221, 30);
            this.txtdaysdt.TabIndex = 25;
            // 
            // Searchsdt
            // 
            this.Searchsdt.BackColor = System.Drawing.Color.Goldenrod;
            this.Searchsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchsdt.ForeColor = System.Drawing.Color.Black;
            this.Searchsdt.Location = new System.Drawing.Point(855, 303);
            this.Searchsdt.Margin = new System.Windows.Forms.Padding(4);
            this.Searchsdt.Name = "Searchsdt";
            this.Searchsdt.Size = new System.Drawing.Size(179, 53);
            this.Searchsdt.TabIndex = 22;
            this.Searchsdt.Text = "Refresh";
            this.Searchsdt.UseVisualStyleBackColor = false;
            this.Searchsdt.Click += new System.EventHandler(this.Searchsdt_Click);
            // 
            // Deletesdt
            // 
            this.Deletesdt.BackColor = System.Drawing.Color.Crimson;
            this.Deletesdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletesdt.ForeColor = System.Drawing.Color.Black;
            this.Deletesdt.Location = new System.Drawing.Point(625, 303);
            this.Deletesdt.Margin = new System.Windows.Forms.Padding(4);
            this.Deletesdt.Name = "Deletesdt";
            this.Deletesdt.Size = new System.Drawing.Size(179, 53);
            this.Deletesdt.TabIndex = 21;
            this.Deletesdt.Text = "Delete";
            this.Deletesdt.UseVisualStyleBackColor = false;
            this.Deletesdt.Click += new System.EventHandler(this.Deletesdt_Click);
            // 
            // Editsdt
            // 
            this.Editsdt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Editsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editsdt.ForeColor = System.Drawing.Color.Black;
            this.Editsdt.Location = new System.Drawing.Point(406, 303);
            this.Editsdt.Margin = new System.Windows.Forms.Padding(4);
            this.Editsdt.Name = "Editsdt";
            this.Editsdt.Size = new System.Drawing.Size(179, 53);
            this.Editsdt.TabIndex = 20;
            this.Editsdt.Text = "Edit";
            this.Editsdt.UseVisualStyleBackColor = false;
            this.Editsdt.Click += new System.EventHandler(this.Editsdt_Click);
            // 
            // Addsdt
            // 
            this.Addsdt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Addsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsdt.ForeColor = System.Drawing.Color.Black;
            this.Addsdt.Location = new System.Drawing.Point(193, 303);
            this.Addsdt.Margin = new System.Windows.Forms.Padding(4);
            this.Addsdt.Name = "Addsdt";
            this.Addsdt.Size = new System.Drawing.Size(179, 53);
            this.Addsdt.TabIndex = 19;
            this.Addsdt.Text = "Add";
            this.Addsdt.UseVisualStyleBackColor = false;
            this.Addsdt.Click += new System.EventHandler(this.Addsdt_Click);
            // 
            // txtEDsdt
            // 
            this.txtEDsdt.Location = new System.Drawing.Point(652, 241);
            this.txtEDsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtEDsdt.Name = "txtEDsdt";
            this.txtEDsdt.Size = new System.Drawing.Size(221, 30);
            this.txtEDsdt.TabIndex = 7;
            this.txtEDsdt.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtStsdt
            // 
            this.txtStsdt.Location = new System.Drawing.Point(652, 181);
            this.txtStsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtStsdt.Name = "txtStsdt";
            this.txtStsdt.Size = new System.Drawing.Size(221, 30);
            this.txtStsdt.TabIndex = 6;
            this.txtStsdt.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(652, 37);
            this.txtsid.Margin = new System.Windows.Forms.Padding(4);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(221, 30);
            this.txtsid.TabIndex = 4;
            this.txtsid.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Thistle;
            this.textBox7.Location = new System.Drawing.Point(420, 241);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 30);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "End Time";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Thistle;
            this.textBox6.Location = new System.Drawing.Point(420, 181);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 30);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "Start Time";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Thistle;
            this.textBox3.Location = new System.Drawing.Point(420, 121);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 30);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Day";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Thistle;
            this.textBox2.Location = new System.Drawing.Point(420, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 30);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Session ID";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "(Add a unique number which already haven\'t add to the table )";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 712);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoofwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorktime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownHours)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDays;
        private System.Windows.Forms.Button Addno;
        private System.Windows.Forms.Button Clearday;
        private System.Windows.Forms.Button Editday;
        private System.Windows.Forms.Button Addday;
        private System.Windows.Forms.DataGridView dataGridViewNoofwd;
        private System.Windows.Forms.Button Deleteday;
        private System.Windows.Forms.DataGridView dataGridViewSlots;
        private System.Windows.Forms.Button Slotremove;
        private System.Windows.Forms.Button Slotuadd;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewWorktime;
        private System.Windows.Forms.Button Cleartime;
        private System.Windows.Forms.Button Deletetime;
        private System.Windows.Forms.Button Edittime;
        private System.Windows.Forms.Button Addtime;
        private System.Windows.Forms.NumericUpDown UpDownMinutes;
        private System.Windows.Forms.NumericUpDown UpDownHours;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txthour;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Removeno;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Editno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox Day1;
        private System.Windows.Forms.ComboBox Day7;
        private System.Windows.Forms.ComboBox Day6;
        private System.Windows.Forms.ComboBox Day5;
        private System.Windows.Forms.ComboBox Day4;
        private System.Windows.Forms.ComboBox Day3;
        private System.Windows.Forms.ComboBox Day2;
        private System.Windows.Forms.TextBox txtworkingtime;
        private System.Windows.Forms.Button Slotupdate;
        private System.Windows.Forms.ComboBox Slottype;
        private System.Windows.Forms.ComboBox Selectnumber;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtEDsdt;
        private System.Windows.Forms.TextBox txtStsdt;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Searchsdt;
        private System.Windows.Forms.Button Deletesdt;
        private System.Windows.Forms.Button Editsdt;
        private System.Windows.Forms.Button Addsdt;
        private System.Windows.Forms.TextBox txtdaysdt;
        private System.Windows.Forms.DataGridView dataGridViewSDt;
        private System.Windows.Forms.Label label1;
    }
}