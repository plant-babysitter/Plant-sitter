﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace plant_sitter
{
    public partial class MainForm : Form
    {
        int[] timeSlice = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        double[] humidity = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        double[] height = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] sunshine = { 0 };
        double[] temperature = { 0 };
        double[] waterPerSe = { 0 };

        DateTime now = DateTime.Now;


        public MainForm()
        {
            InitializeComponent();
            currentDay.Text = now.ToString("yyyy-MM-dd");
            InitializeCustomComponents();
            LoadSettings();

        }

        private void LoadSettings()
        {
            label1.Text = Properties.Settings.Default.Label1Text;
            label2.Text = Properties.Settings.Default.Label2Text;
            label3.Text = Properties.Settings.Default.Label3Text;
            label4.Text = Properties.Settings.Default.Label4Text;
            label5.Text = Properties.Settings.Default.Label5Text;

            string imagePath = Properties.Settings.Default.PlantImagePath;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // 디버깅 코드


                if (File.Exists(imagePath))
                {
                    pictureBoxQ.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image file does not exist: " + imagePath);
                }
            }
        }

        private void InitializeCustomComponents()
        {

        }


        private void Button_set_image1(object sender, EventArgs e)
        {
            ImageChangeForm imageChangeForm = new ImageChangeForm(pictureBoxQ);
            imageChangeForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timeSlice = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            humidity = new double[] { 25, 30, 56, 78, 82, 90, 80, 77, 56, 50, 40, 48 };
            height = new double[] { 10, 11, 12.5, 13, 13.8, 14, 15, 17, 17.5, 19, 19.3, 20 };

            HumidityChart.Series.Clear();
            HumidityChart.Series.Add("Humidity");
            HumidityChart.ChartAreas[0].AxisY.Maximum = 100;
            HumidityChart.ChartAreas[0].AxisY.Minimum = 0;
            HumidityChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HumidityChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;


            for (int i = 0; i < 12; i++)
            {
                HumidityChart.Series["Humidity"].Points.AddXY(timeSlice[i], humidity[i]);
            }

            HumidityChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            HumidityChart.Series["Humidity"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            HeightChart.Series.Clear();
            HeightChart.Series.Add("Height");
            HeightChart.ChartAreas[0].AxisY.Maximum = 30;
            HeightChart.ChartAreas[0].AxisY.Minimum = 0;
            HeightChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HeightChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            HeightChart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;


            for (int i = 0; i < 12; i++)
            {
                HeightChart.Series["Height"].Points.AddXY(timeSlice[i], height[i]);
            }

            HeightChart.Series["Height"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }


        private void 파일내보내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Save a CSV File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                //파일에 timeSlice, huminity, height를 저장
                for (int i = 0; i < 10; i++)
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(timeSlice[i] + "," + humidity[i] + "," + height[i] + "\n");
                    fs.Write(info, 0, info.Length);
                }
                fs.Close();
            }
        }

        private void Button_set_info_Click(object sender, EventArgs e)
        {
            InfoChangeForm infoChangeForm = new InfoChangeForm(label1, label2, label3, label4, label5);
            infoChangeForm.ShowDialog();
        }

        private void BtnDay_Click(object sender, EventArgs e)
        {
            timeSlice = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            humidity = new double[] { 25, 30, 56, 78, 82, 90, 80, 77, 56, 50, 40, 48 };
            height = new double[] { 10, 11, 12.5, 13, 13.8, 14, 15, 17, 17.5, 19, 19.3, 20 };

            HumidityChart.Series.Clear();
            HumidityChart.Series.Add("Humidity");
            HumidityChart.ChartAreas[0].AxisY.Maximum = 100;
            HumidityChart.ChartAreas[0].AxisY.Minimum = 0;
            HumidityChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HumidityChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;


            for (int i = 0; i < 12; i++)
            {
                HumidityChart.Series["Humidity"].Points.AddXY(timeSlice[i], humidity[i]);
            }

            HumidityChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            HumidityChart.Series["Humidity"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            HeightChart.Series.Clear();
            HeightChart.Series.Add("Height");
            HeightChart.ChartAreas[0].AxisY.Maximum = 30;
            HeightChart.ChartAreas[0].AxisY.Minimum = 0;
            HeightChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HeightChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            HeightChart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            for (int i = 0; i < 12; i++)
            {
                HeightChart.Series["Height"].Points.AddXY(timeSlice[i], height[i]);
            }

            HeightChart.Series["Height"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }

        private void BtnWeek_Click(object sender, EventArgs e)
        {

            timeSlice = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            humidity = new double[] { 46, 30, 56, 78, 82, 54, 80, 77, 56, 50, 64, 48, 59, 62, 70, 80, 73, 64, 70, 62, 51, 41, 65, 48 };
            height = new double[] { 5, 5.6, 5.8, 6.7, 7, 7.3, 8, 8.2, 9, 9.5, 10, 11, 12.5, 13, 13.8, 14, 15, 17, 17.5, 19, 19.3, 20 };


            HumidityChart.Series.Clear();
            HumidityChart.Series.Add("Humidity");
            HumidityChart.ChartAreas[0].AxisY.Maximum = 100;
            HumidityChart.ChartAreas[0].AxisY.Minimum = 0;
            HumidityChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HumidityChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;


            for (int i = 0; i < 12; i++)
            {
                HumidityChart.Series["Humidity"].Points.AddXY(timeSlice[i], humidity[i]);
            }

            HumidityChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            HumidityChart.Series["Humidity"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            HeightChart.Series.Clear();
            HeightChart.Series.Add("Height");
            HeightChart.ChartAreas[0].AxisY.Maximum = 30;
            HeightChart.ChartAreas[0].AxisY.Minimum = 0;
            HeightChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HeightChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            HeightChart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;


            for (int i = 0; i < 12; i++)
            {
                HeightChart.Series["Height"].Points.AddXY(timeSlice[i], height[i]);
            }

            HeightChart.Series["Height"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void BtnMonth_Click(object sender, EventArgs e)
        {
            timeSlice = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            humidity = new double[] { 46, 30, 56, 64, 51, 62, 51, 41, 65, 48, 56, 64, 52 };
            height = new double[] { 0, 2, 2.4, 5, 6, 7.3, 9, 12, 13.8, 14.2, 16.5, 19, 20 };

            HumidityChart.Series.Clear();
            HumidityChart.Series.Add("Humidity");
            HumidityChart.ChartAreas[0].AxisY.Maximum = 100;
            HumidityChart.ChartAreas[0].AxisY.Minimum = 0;
            HumidityChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HumidityChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;


            for (int i = 0; i < 12; i++)
            {
                HumidityChart.Series["Humidity"].Points.AddXY(timeSlice[i], humidity[i]);
            }

            HumidityChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            HumidityChart.Series["Humidity"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            HeightChart.Series.Clear();
            HeightChart.Series.Add("Height");
            HeightChart.ChartAreas[0].AxisY.Maximum = 30;
            HeightChart.ChartAreas[0].AxisY.Minimum = 0;
            HeightChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            HeightChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            HeightChart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            for (int i = 0; i < 12; i++)
            {
                HeightChart.Series["Height"].Points.AddXY(timeSlice[i], height[i]);
            }

            HeightChart.Series["Height"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void 사진불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //이미지 파일 불러와서 현재 폴더에 저장

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";
            openFileDialog.ShowDialog();

            //이미지를 Application.StartupPath에 저장
            if (openFileDialog.FileName != "")
            {
                string imagePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(imagePath);
                string destPath = Path.Combine(Application.StartupPath, fileName);
                File.Copy(imagePath, destPath, true);

                //이미지를 pictureBoxQ에 띄워줌
                if (File.Exists(destPath))
                {
                    pictureBoxQ.Image = Image.FromFile(destPath);
                    Properties.Settings.Default.PlantImagePath = destPath;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Image file does not exist: " + destPath);
                }
            }
        }
    }

    }


