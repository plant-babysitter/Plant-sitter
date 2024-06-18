namespace plant_sitter
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxQ = new System.Windows.Forms.PictureBox();
            this.Button_set_image = new System.Windows.Forms.PictureBox();
            this.Button_set_info = new System.Windows.Forms.PictureBox();
            this.HeightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HumidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnMonthChart = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.식물정보변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사진불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일내보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.currentDay = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnWeekChart = new System.Windows.Forms.Button();
            this.BtnTodayChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityChart)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "식물 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "식물의 종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "목표 습도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "목표 온도";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "펌프 주기";
            // 
            // pictureBoxQ
            // 
            this.pictureBoxQ.Image = global::plant_sitter.Properties.Resources.basic;
            this.pictureBoxQ.Location = new System.Drawing.Point(74, 99);
            this.pictureBoxQ.Name = "pictureBoxQ";
            this.pictureBoxQ.Size = new System.Drawing.Size(149, 201);
            this.pictureBoxQ.TabIndex = 1;
            this.pictureBoxQ.TabStop = false;
            // 
            // Button_set_image
            // 
            this.Button_set_image.Image = global::plant_sitter.Properties.Resources.reset;
            this.Button_set_image.Location = new System.Drawing.Point(229, 99);
            this.Button_set_image.Name = "Button_set_image";
            this.Button_set_image.Size = new System.Drawing.Size(17, 23);
            this.Button_set_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_set_image.TabIndex = 12;
            this.Button_set_image.TabStop = false;
            this.Button_set_image.Click += new System.EventHandler(this.Button_set_image1);
            // 
            // Button_set_info
            // 
            this.Button_set_info.Image = global::plant_sitter.Properties.Resources.reset;
            this.Button_set_info.Location = new System.Drawing.Point(142, 322);
            this.Button_set_info.Name = "Button_set_info";
            this.Button_set_info.Size = new System.Drawing.Size(17, 15);
            this.Button_set_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_set_info.TabIndex = 11;
            this.Button_set_info.TabStop = false;
            this.Button_set_info.Click += new System.EventHandler(this.Button_set_info_Click);
            // 
            // HeightChart
            // 
            chartArea1.Name = "ChartArea1";
            this.HeightChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HeightChart.Legends.Add(legend1);
            this.HeightChart.Location = new System.Drawing.Point(422, 90);
            this.HeightChart.Name = "HeightChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.HeightChart.Series.Add(series1);
            this.HeightChart.Size = new System.Drawing.Size(433, 192);
            this.HeightChart.TabIndex = 13;
            this.HeightChart.Text = "chart1";
            // 
            // HumidityChart
            // 
            chartArea2.Name = "ChartArea1";
            this.HumidityChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.HumidityChart.Legends.Add(legend2);
            this.HumidityChart.Location = new System.Drawing.Point(422, 308);
            this.HumidityChart.Name = "HumidityChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.HumidityChart.Series.Add(series2);
            this.HumidityChart.Size = new System.Drawing.Size(433, 203);
            this.HumidityChart.TabIndex = 14;
            this.HumidityChart.Text = "chart2";
            // 
            // BtnMonthChart
            // 
            this.BtnMonthChart.Location = new System.Drawing.Point(780, 45);
            this.BtnMonthChart.Name = "BtnMonthChart";
            this.BtnMonthChart.Size = new System.Drawing.Size(75, 39);
            this.BtnMonthChart.TabIndex = 15;
            this.BtnMonthChart.Text = "한 달";
            this.BtnMonthChart.UseVisualStyleBackColor = true;
            this.BtnMonthChart.Click += new System.EventHandler(this.BtnMonth_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(941, 28);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.식물정보변경ToolStripMenuItem,
            this.파일내보내기ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 식물정보변경ToolStripMenuItem
            // 
            this.식물정보변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사진불러오기ToolStripMenuItem});
            this.식물정보변경ToolStripMenuItem.Name = "식물정보변경ToolStripMenuItem";
            this.식물정보변경ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.식물정보변경ToolStripMenuItem.Text = "식물 정보 변경";
            // 
            // 사진불러오기ToolStripMenuItem
            // 
            this.사진불러오기ToolStripMenuItem.Name = "사진불러오기ToolStripMenuItem";
            this.사진불러오기ToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.사진불러오기ToolStripMenuItem.Text = "사진 불러오기";
            this.사진불러오기ToolStripMenuItem.Click += new System.EventHandler(this.사진불러오기ToolStripMenuItem_Click);
            // 
            // 파일내보내기ToolStripMenuItem
            // 
            this.파일내보내기ToolStripMenuItem.Name = "파일내보내기ToolStripMenuItem";
            this.파일내보내기ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.파일내보내기ToolStripMenuItem.Text = "파일 내보내기";
            this.파일내보내기ToolStripMenuItem.Click += new System.EventHandler(this.파일내보내기ToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(23, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "Plant Sitter";
            // 
            // currentDay
            // 
            this.currentDay.AutoSize = true;
            this.currentDay.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentDay.Location = new System.Drawing.Point(419, 50);
            this.currentDay.Name = "currentDay";
            this.currentDay.Size = new System.Drawing.Size(86, 17);
            this.currentDay.TabIndex = 18;
            this.currentDay.Text = "검색 기간";
            // 
            // BtnWeekChart
            // 
            this.BtnWeekChart.Location = new System.Drawing.Point(684, 45);
            this.BtnWeekChart.Name = "BtnWeekChart";
            this.BtnWeekChart.Size = new System.Drawing.Size(75, 39);
            this.BtnWeekChart.TabIndex = 19;
            this.BtnWeekChart.Text = "일주일";
            this.BtnWeekChart.UseVisualStyleBackColor = true;
            this.BtnWeekChart.Click += new System.EventHandler(this.BtnWeek_Click);
            // 
            // BtnTodayChart
            // 
            this.BtnTodayChart.Location = new System.Drawing.Point(590, 45);
            this.BtnTodayChart.Name = "BtnTodayChart";
            this.BtnTodayChart.Size = new System.Drawing.Size(75, 39);
            this.BtnTodayChart.TabIndex = 20;
            this.BtnTodayChart.Text = "당일";
            this.BtnTodayChart.UseVisualStyleBackColor = true;
            this.BtnTodayChart.Click += new System.EventHandler(this.BtnDay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(941, 545);
            this.Controls.Add(this.BtnTodayChart);
            this.Controls.Add(this.BtnWeekChart);
            this.Controls.Add(this.currentDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnMonthChart);
            this.Controls.Add(this.HumidityChart);
            this.Controls.Add(this.HeightChart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxQ);
            this.Controls.Add(this.Button_set_image);
            this.Controls.Add(this.Button_set_info);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Plant-Sitter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityChart)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Button_set_image;
        private System.Windows.Forms.PictureBox Button_set_info;
        private System.Windows.Forms.DataVisualization.Charting.Chart HeightChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart HumidityChart;
        private System.Windows.Forms.Button BtnMonthChart;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 식물정보변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사진불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일내보내기ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentDay;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button BtnWeekChart;
        private System.Windows.Forms.Button BtnTodayChart;
    }
}

