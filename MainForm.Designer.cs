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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.ChartButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.식물정보변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사진불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일내보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "식물 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "식물의 종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "목표 습도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "목표 온도";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "펌프 주기";
            // 
            // pictureBoxQ
            // 
            this.pictureBoxQ.Image = global::plant_sitter.Properties.Resources.basic;
            this.pictureBoxQ.Location = new System.Drawing.Point(12, 45);
            this.pictureBoxQ.Name = "pictureBoxQ";
            this.pictureBoxQ.Size = new System.Drawing.Size(149, 201);
            this.pictureBoxQ.TabIndex = 1;
            this.pictureBoxQ.TabStop = false;
            // 
            // Button_set_image
            // 
            this.Button_set_image.Image = global::plant_sitter.Properties.Resources.reset;
            this.Button_set_image.Location = new System.Drawing.Point(167, 45);
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
            this.Button_set_info.Location = new System.Drawing.Point(149, 271);
            this.Button_set_info.Name = "Button_set_info";
            this.Button_set_info.Size = new System.Drawing.Size(17, 15);
            this.Button_set_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_set_info.TabIndex = 11;
            this.Button_set_info.TabStop = false;
            // 
            // HeightChart
            // 
            chartArea13.Name = "ChartArea1";
            this.HeightChart.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.HeightChart.Legends.Add(legend13);
            this.HeightChart.Location = new System.Drawing.Point(422, 90);
            this.HeightChart.Name = "HeightChart";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.HeightChart.Series.Add(series13);
            this.HeightChart.Size = new System.Drawing.Size(433, 192);
            this.HeightChart.TabIndex = 13;
            this.HeightChart.Text = "chart1";
            // 
            // HumidityChart
            // 
            chartArea14.Name = "ChartArea1";
            this.HumidityChart.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.HumidityChart.Legends.Add(legend14);
            this.HumidityChart.Location = new System.Drawing.Point(422, 308);
            this.HumidityChart.Name = "HumidityChart";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.HumidityChart.Series.Add(series14);
            this.HumidityChart.Size = new System.Drawing.Size(433, 203);
            this.HumidityChart.TabIndex = 14;
            this.HumidityChart.Text = "chart2";
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(780, 45);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 39);
            this.ChartButton.TabIndex = 15;
            this.ChartButton.Text = "버튼";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.식물정보변경ToolStripMenuItem,
            this.파일내보내기ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.설정ToolStripMenuItem.Text = "설정";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // 식물정보변경ToolStripMenuItem
            // 
            this.식물정보변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사진불러오기ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.식물정보변경ToolStripMenuItem.Name = "식물정보변경ToolStripMenuItem";
            this.식물정보변경ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.식물정보변경ToolStripMenuItem.Text = "식물 정보 변경";
            // 
            // 사진불러오기ToolStripMenuItem
            // 
            this.사진불러오기ToolStripMenuItem.Name = "사진불러오기ToolStripMenuItem";
            this.사진불러오기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.사진불러오기ToolStripMenuItem.Text = "사진 불러오기";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.정보ToolStripMenuItem.Text = "기본정보 변경";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // 파일내보내기ToolStripMenuItem
            // 
            this.파일내보내기ToolStripMenuItem.Name = "파일내보내기ToolStripMenuItem";
            this.파일내보내기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.파일내보내기ToolStripMenuItem.Text = "파일 내보내기";
            this.파일내보내기ToolStripMenuItem.Click += new System.EventHandler(this.파일내보내기ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 545);
            this.Controls.Add(this.ChartButton);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.Button_set_info1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_set_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button ChartButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 식물정보변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사진불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일내보내기ToolStripMenuItem;
    }
}

