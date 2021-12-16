namespace HealthTracker
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.WeightTxt = new System.Windows.Forms.TextBox();
            this.HeightTxt = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.HistoryTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.GenderTxt = new System.Windows.Forms.ComboBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tracker = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistoryClearButton = new System.Windows.Forms.Button();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.Tracker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // WeightTxt
            // 
            this.WeightTxt.Location = new System.Drawing.Point(96, 362);
            this.WeightTxt.Name = "WeightTxt";
            this.WeightTxt.Size = new System.Drawing.Size(100, 20);
            this.WeightTxt.TabIndex = 0;
            // 
            // HeightTxt
            // 
            this.HeightTxt.Location = new System.Drawing.Point(96, 388);
            this.HeightTxt.Name = "HeightTxt";
            this.HeightTxt.Size = new System.Drawing.Size(100, 20);
            this.HeightTxt.TabIndex = 1;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(222, 362);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(104, 46);
            this.CalcButton.TabIndex = 2;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ResultTxt
            // 
            this.ResultTxt.Location = new System.Drawing.Point(353, 362);
            this.ResultTxt.Multiline = true;
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(413, 46);
            this.ResultTxt.TabIndex = 3;
            // 
            // HistoryTxt
            // 
            this.HistoryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryTxt.Location = new System.Drawing.Point(52, 20);
            this.HistoryTxt.Name = "HistoryTxt";
            this.HistoryTxt.Size = new System.Drawing.Size(350, 260);
            this.HistoryTxt.TabIndex = 4;
            this.HistoryTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.UserTab);
            this.TabControl1.Controls.Add(this.Tracker);
            this.TabControl1.Location = new System.Drawing.Point(63, 22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1054, 503);
            this.TabControl1.TabIndex = 8;
            // 
            // UserTab
            // 
            this.UserTab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UserTab.Controls.Add(this.GenderTxt);
            this.UserTab.Controls.Add(this.AgeTxt);
            this.UserTab.Controls.Add(this.NameTxt);
            this.UserTab.Controls.Add(this.label5);
            this.UserTab.Controls.Add(this.label4);
            this.UserTab.Controls.Add(this.label3);
            this.UserTab.Location = new System.Drawing.Point(4, 22);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(1046, 477);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "User";
            // 
            // GenderTxt
            // 
            this.GenderTxt.FormattingEnabled = true;
            this.GenderTxt.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderTxt.Location = new System.Drawing.Point(80, 106);
            this.GenderTxt.Name = "GenderTxt";
            this.GenderTxt.Size = new System.Drawing.Size(144, 21);
            this.GenderTxt.TabIndex = 5;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(80, 80);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(142, 20);
            this.AgeTxt.TabIndex = 4;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(80, 54);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(292, 20);
            this.NameTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // Tracker
            // 
            this.Tracker.BackColor = System.Drawing.Color.Purple;
            this.Tracker.Controls.Add(this.button1);
            this.Tracker.Controls.Add(this.label7);
            this.Tracker.Controls.Add(this.label6);
            this.Tracker.Controls.Add(this.chart1);
            this.Tracker.Controls.Add(this.HistoryClearButton);
            this.Tracker.Controls.Add(this.LoadFileButton);
            this.Tracker.Controls.Add(this.SaveFileButton);
            this.Tracker.Controls.Add(this.HistoryTxt);
            this.Tracker.Controls.Add(this.label2);
            this.Tracker.Controls.Add(this.WeightTxt);
            this.Tracker.Controls.Add(this.label1);
            this.Tracker.Controls.Add(this.HeightTxt);
            this.Tracker.Controls.Add(this.CalcButton);
            this.Tracker.Controls.Add(this.ResultTxt);
            this.Tracker.Location = new System.Drawing.Point(4, 22);
            this.Tracker.Name = "Tracker";
            this.Tracker.Padding = new System.Windows.Forms.Padding(3);
            this.Tracker.Size = new System.Drawing.Size(1046, 477);
            this.Tracker.TabIndex = 1;
            this.Tracker.Text = "Tracker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(684, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(477, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "BMI";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(467, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "BMI Data";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(583, 350);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.UseWaitCursor = true;
            // 
            // HistoryClearButton
            // 
            this.HistoryClearButton.Location = new System.Drawing.Point(367, 427);
            this.HistoryClearButton.Name = "HistoryClearButton";
            this.HistoryClearButton.Size = new System.Drawing.Size(103, 38);
            this.HistoryClearButton.TabIndex = 10;
            this.HistoryClearButton.Text = "ClearHistory";
            this.HistoryClearButton.UseVisualStyleBackColor = true;
            this.HistoryClearButton.Click += new System.EventHandler(this.HistoryClearButton_Click);
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(222, 427);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(104, 38);
            this.LoadFileButton.TabIndex = 9;
            this.LoadFileButton.Text = "LoadUserHistory";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(97, 427);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(98, 38);
            this.SaveFileButton.TabIndex = 8;
            this.SaveFileButton.Text = "SaveToFile";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "ClearChart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1359, 650);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            this.Tracker.ResumeLayout(false);
            this.Tracker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox WeightTxt;
        private System.Windows.Forms.TextBox HeightTxt;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.RichTextBox HistoryTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Tracker;
        private System.Windows.Forms.ComboBox GenderTxt;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button HistoryClearButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

