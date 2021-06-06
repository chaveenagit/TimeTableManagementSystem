namespace TimeTableMangment
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LecturesBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yearSubBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.depLecPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenaratePie = new System.Windows.Forms.Button();
            this.studentDepChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSubBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depLecPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LecturesBar
            // 
            this.LecturesBar.BackColor = System.Drawing.Color.Thistle;
            chartArea1.Name = "ChartArea1";
            this.LecturesBar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LecturesBar.Legends.Add(legend1);
            this.LecturesBar.Location = new System.Drawing.Point(51, 27);
            this.LecturesBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LecturesBar.Name = "LecturesBar";
            this.LecturesBar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "lecOfFaculty";
            this.LecturesBar.Series.Add(series1);
            this.LecturesBar.Size = new System.Drawing.Size(579, 287);
            this.LecturesBar.TabIndex = 0;
            this.LecturesBar.Text = "chart1";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            title1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalBrick;
            title1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Lectures of Faculties";
            this.LecturesBar.Titles.Add(title1);
            this.LecturesBar.Click += new System.EventHandler(this.chartLocation_Click);
            // 
            // yearSubBar
            // 
            this.yearSubBar.BackColor = System.Drawing.Color.Thistle;
            chartArea2.Name = "ChartArea1";
            this.yearSubBar.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.yearSubBar.Legends.Add(legend2);
            this.yearSubBar.Location = new System.Drawing.Point(715, 27);
            this.yearSubBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearSubBar.Name = "yearSubBar";
            this.yearSubBar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "yearSub";
            this.yearSubBar.Series.Add(series2);
            this.yearSubBar.Size = new System.Drawing.Size(552, 287);
            this.yearSubBar.TabIndex = 1;
            this.yearSubBar.Text = "chart1";
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            title2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedDownwardDiagonal;
            title2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Modules per Year";
            this.yearSubBar.Titles.Add(title2);
            // 
            // depLecPie
            // 
            this.depLecPie.BackColor = System.Drawing.Color.Thistle;
            chartArea3.Name = "ChartArea1";
            this.depLecPie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.depLecPie.Legends.Add(legend3);
            this.depLecPie.Location = new System.Drawing.Point(111, 353);
            this.depLecPie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depLecPie.Name = "depLecPie";
            this.depLecPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "lecFacPie";
            this.depLecPie.Series.Add(series3);
            this.depLecPie.Size = new System.Drawing.Size(417, 268);
            this.depLecPie.TabIndex = 2;
            this.depLecPie.Text = "chart1";
            title3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            title3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            title3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Lectures of Departments";
            this.depLecPie.Titles.Add(title3);
            this.depLecPie.Click += new System.EventHandler(this.depLecPie_Click);
            // 
            // btnGenaratePie
            // 
            this.btnGenaratePie.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnGenaratePie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenaratePie.Location = new System.Drawing.Point(172, 619);
            this.btnGenaratePie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenaratePie.Name = "btnGenaratePie";
            this.btnGenaratePie.Size = new System.Drawing.Size(221, 40);
            this.btnGenaratePie.TabIndex = 3;
            this.btnGenaratePie.Text = "Show Pie Chart";
            this.btnGenaratePie.UseVisualStyleBackColor = false;
            this.btnGenaratePie.Click += new System.EventHandler(this.btnGenaratePie_Click);
            // 
            // studentDepChart
            // 
            this.studentDepChart.BackColor = System.Drawing.Color.Thistle;
            chartArea4.Name = "ChartArea1";
            this.studentDepChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.studentDepChart.Legends.Add(legend4);
            this.studentDepChart.Location = new System.Drawing.Point(715, 357);
            this.studentDepChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentDepChart.Name = "studentDepChart";
            this.studentDepChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "depStudent";
            this.studentDepChart.Series.Add(series4);
            this.studentDepChart.Size = new System.Drawing.Size(552, 300);
            this.studentDepChart.TabIndex = 4;
            this.studentDepChart.Text = "chart1";
            title4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            title4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalBrick;
            title4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Students of Departments";
            this.studentDepChart.Titles.Add(title4);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1315, 672);
            this.Controls.Add(this.studentDepChart);
            this.Controls.Add(this.btnGenaratePie);
            this.Controls.Add(this.depLecPie);
            this.Controls.Add(this.yearSubBar);
            this.Controls.Add(this.LecturesBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LecturesBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSubBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depLecPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LecturesBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearSubBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart depLecPie;
        private System.Windows.Forms.Button btnGenaratePie;
        private System.Windows.Forms.DataVisualization.Charting.Chart studentDepChart;
    }
}