using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace HealthTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float bmi;
        public string cat;
        public int counter = 0;

        private void CalcButton_Click(object sender, EventArgs e)
        {
            float Weight;
            bool WeightValid = float.TryParse(WeightTxt.Text,out Weight);
            if (WeightValid == false)
            {
                MessageBox.Show("the input in the weight textbox was invalid, please enter a valid weight in kg between 25 and 300", "Weight textbox error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            float Height;
            bool HeightValid = float.TryParse(HeightTxt.Text, out Height);
            if (HeightValid == false)
            {
                MessageBox.Show("the input in the Height textbox was invalid, please enter a valid height in metres between 0.6 and 3", "Height textbox error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool HeightValid2 = false;
            bool WeightValid2 = false;
            if (HeightValid == true && WeightValid == true)
            {
                if (Weight >= 25 && Weight <= 300)
                {
                    WeightValid2 = true;
                }
                else
                {
                    MessageBox.Show("the input in the Weight textbox was invalid, please enter a valid weight in kg between 25 and 300", "Weight textbox error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Height >= 0.6 && Height <= 3)
                {
                    HeightValid2 = true;
                }
                else
                {
                    MessageBox.Show("the input in the Height textbox was invalid, please enter a valid height in metres between 0.6 and 3", "Height textbox error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (HeightValid2 == true && WeightValid2 == true)
            {
                
                bmi = Weight / (Height * Height);
                if (bmi < 18.5)
                {
                    ResultTxt.Text = bmi.ToString() + "      Underweight";
                    HistoryTxt.AppendText(bmi.ToString() + "      Underweight" + "\r\n");
                    cat = "underweight";
                }
                if (18.5 <= bmi && bmi <= 24.9)
                {
                    ResultTxt.Text = bmi.ToString() + "      Normal weight";
                    HistoryTxt.AppendText(bmi.ToString() + "      Normal weight" + "\r\n");
                    cat = "Normal Weight";
                }
                if (25 <= bmi && bmi <= 29.9)
                {
                    ResultTxt.Text = bmi.ToString() + "      Overweight";
                    HistoryTxt.AppendText(bmi.ToString() + "      Overweight" + "\r\n");
                    cat = "Overweight";
                }
                if (bmi >= 30)
                {
                    
                    ResultTxt.Text = bmi.ToString() + "      Obese";
                    HistoryTxt.AppendText(bmi.ToString() + "      Obese" + "\r\n");
                    cat = "Obese";
                }
                MakeChart();
            }
            
        }

        

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"G:\HealthData" + NameTxt.Text + ".txt", true);


            //writer.WriteLine(DateTime.Now.ToString() + ',' + bmi.ToString() + "," + cat);
            writer.WriteLine(HistoryTxt);
            
            writer.Close();
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"G:\HealthData" + NameTxt.Text + ".txt", true);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lines = line.Split(',');
                bmi = float.Parse(lines[1]);
                counter = counter++;
                MakeChart();
                HistoryTxt.AppendText(lines[1] + "     " + lines[2] + "\r\n");
            }
            
            reader.Close();            
                                    
        }

        private void HistoryClearButton_Click(object sender, EventArgs e)
        {
            HistoryTxt.Clear();
        }

        void ClearChart()
        {
            this.chart1.Series.Clear();
            this.chart1.Series.Add("BMI Data");
            Series series = this.chart1.Series.FindByName("BMI Data");
            series.ChartType = SeriesChartType.Line;
            counter = 0;
        }

        void MakeChart()
        {                                                                       
            
            Series series = this.chart1.Series.FindByName("BMI Data");            
            this.chart1.ChartAreas[0].AxisX.Minimum = 0;            
            series.Points.AddXY(counter, bmi);
            counter = counter + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("BMI values of the user");
            Series series = this.chart1.Series.FindByName("BMI Data");
            series.ChartType = SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearChart();
            counter = 0;
        }
    }
}
