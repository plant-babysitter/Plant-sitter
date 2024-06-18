using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plant_sitter
{
    public partial class MainForm : Form
    {
        int[] timeSlice = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        double[] huminity = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        double[] height = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] sunshine = { 0 };
        double[] temperature = { 0 };
        double[] waterPerSe = { 0 };

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();

        }

        private void InitializeCustomComponents()
        {
            
        }

        private void Button_set_info1(object sender, EventArgs e)
        {
            InfoChangeForm infoChangeForm = new InfoChangeForm(label1, label2, label3, label4, label5);
            infoChangeForm.ShowDialog();
        }

   
        private void Button_set_image1(object sender, EventArgs e)
        {
            ImageChangeForm imageChangeForm = new ImageChangeForm(pictureBoxQ);
            imageChangeForm.ShowDialog();
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HumidityChart.Series.Clear();
            HumidityChart.Series.Add("Humidity");
            HumidityChart.ChartAreas[0].AxisY.Maximum = 100;
            HumidityChart.ChartAreas[0].AxisY.Minimum = 0;
            HumidityChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            for (int i = 0; i < 10; i++)
            {
                HumidityChart.Series["Humidity"].Points.AddXY(timeSlice[i], huminity[i]);
            }


            HumidityChart.Series["Humidity"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            HeightChart.Series.Clear();
            HeightChart.Series.Add("Height");
            HeightChart.ChartAreas[0].AxisY.Maximum = 10;
            HeightChart.ChartAreas[0].AxisY.Minimum = 0;
            HeightChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            for (int i = 0; i < 10; i++)
            {
                HeightChart.Series["Height"].Points.AddXY(timeSlice[i], height[i]);
            }
            HeightChart.Series["Height"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void ChartBtn_Click(object sender, EventArgs e)
        {
            HumidityChart.Series.Clear();
            HumidityChart.Series.Add("Humidity");
            HumidityChart.ChartAreas[0].AxisY.Maximum = 100;
            HumidityChart.ChartAreas[0].AxisY.Minimum = 0;
            HumidityChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Humidity에 0~100 사이의 랜덤값을 넣어주고 이를 차트에 표시
            Random rand = new Random(); //이건 테스트로 넣었습니다
            for (int i = 0; i < 10; i++)
            {
                HumidityChart.Series["Humidity"].Points.AddXY(timeSlice[i], rand.Next(0, 100));
            }

            HumidityChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            HumidityChart.Series["Humidity"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            HeightChart.Series.Clear();
            HeightChart.Series.Add("Height");
            HeightChart.ChartAreas[0].AxisY.Maximum = 10;
            HeightChart.ChartAreas[0].AxisY.Minimum = 0;
            HeightChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            for (int i = 0; i < 10; i++)
            {
                HeightChart.Series["Height"].Points.AddXY(timeSlice[i], rand.Next(0, 10));
            }

            HeightChart.Series["Height"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                    Byte[] info = new UTF8Encoding(true).GetBytes(timeSlice[i] + "," + huminity[i] + "," + height[i] + "\n");
                    fs.Write(info, 0, info.Length);
                }
                fs.Close();
            }
        }
    }

}
