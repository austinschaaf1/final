
namespace insulin_pump
{
    partial class Display2
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
            System.Windows.Forms.DataVisualization.Charting.HorizontalLineAnnotation horizontalLineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.HorizontalLineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangleAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 115D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 108D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 125D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 140D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 150D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 110D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint49 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint50 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 96D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint51 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 92D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint52 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 90D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint53 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 112D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint54 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 122D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint55 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(13D, 108D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint56 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(14D, 98D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint57 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(15D, 115D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint58 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(16D, 125D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint59 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(17D, 136D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint60 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(18D, 140D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint61 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(19D, 165D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint62 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 132D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint63 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(21D, 118D);
            this.insulinInformationPanel = new loanCalculator.RoundPanel();
            this.remainingDosesLabel = new System.Windows.Forms.Label();
            this.lastDoseAmountLabel = new System.Windows.Forms.Label();
            this.lastDoseTimeLabel = new System.Windows.Forms.Label();
            this.lastDoseLabel = new System.Windows.Forms.Label();
            this.takeInsulinButton = new loanCalculator.RoundedButton();
            this.insulinDosingPanel = new loanCalculator.RoundPanel();
            this.insulinDosingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.insulinInformationPanel.SuspendLayout();
            this.insulinDosingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insulinDosingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // insulinInformationPanel
            // 
            this.insulinInformationPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insulinInformationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.insulinInformationPanel.ColumnCount = 1;
            this.insulinInformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.insulinInformationPanel.Controls.Add(this.remainingDosesLabel, 0, 3);
            this.insulinInformationPanel.Controls.Add(this.lastDoseAmountLabel, 0, 2);
            this.insulinInformationPanel.Controls.Add(this.lastDoseTimeLabel, 0, 1);
            this.insulinInformationPanel.Controls.Add(this.lastDoseLabel, 0, 0);
            this.insulinInformationPanel.Controls.Add(this.takeInsulinButton, 0, 5);
            this.insulinInformationPanel.Location = new System.Drawing.Point(594, 77);
            this.insulinInformationPanel.Name = "insulinInformationPanel";
            this.insulinInformationPanel.Radious = 25;
            this.insulinInformationPanel.RowCount = 6;
            this.insulinInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.02325F));
            this.insulinInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.97675F));
            this.insulinInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.insulinInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.insulinInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.insulinInformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.insulinInformationPanel.Size = new System.Drawing.Size(293, 347);
            this.insulinInformationPanel.TabIndex = 3;
            this.insulinInformationPanel.TitleBackColor = System.Drawing.Color.Empty;
            this.insulinInformationPanel.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.insulinInformationPanel.TitleForeColor = System.Drawing.Color.Empty;
            this.insulinInformationPanel.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // remainingDosesLabel
            // 
            this.remainingDosesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remainingDosesLabel.AutoSize = true;
            this.remainingDosesLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingDosesLabel.Location = new System.Drawing.Point(48, 184);
            this.remainingDosesLabel.Name = "remainingDosesLabel";
            this.remainingDosesLabel.Size = new System.Drawing.Size(196, 19);
            this.remainingDosesLabel.TabIndex = 2;
            this.remainingDosesLabel.Text = "Remaining Doses (Units): 4";
            // 
            // lastDoseAmountLabel
            // 
            this.lastDoseAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastDoseAmountLabel.AutoSize = true;
            this.lastDoseAmountLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDoseAmountLabel.Location = new System.Drawing.Point(44, 114);
            this.lastDoseAmountLabel.Name = "lastDoseAmountLabel";
            this.lastDoseAmountLabel.Size = new System.Drawing.Size(204, 19);
            this.lastDoseAmountLabel.TabIndex = 1;
            this.lastDoseAmountLabel.Text = "Last Dose Amount (Units): 1";
            // 
            // lastDoseTimeLabel
            // 
            this.lastDoseTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastDoseTimeLabel.AutoSize = true;
            this.lastDoseTimeLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDoseTimeLabel.Location = new System.Drawing.Point(59, 37);
            this.lastDoseTimeLabel.Name = "lastDoseTimeLabel";
            this.lastDoseTimeLabel.Size = new System.Drawing.Size(175, 38);
            this.lastDoseTimeLabel.TabIndex = 0;
            this.lastDoseTimeLabel.Text = "\nHH:mm:ss mm/dd/yyyy";
            this.lastDoseTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastDoseLabel
            // 
            this.lastDoseLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lastDoseLabel.AutoSize = true;
            this.lastDoseLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDoseLabel.Location = new System.Drawing.Point(80, 18);
            this.lastDoseLabel.Name = "lastDoseLabel";
            this.lastDoseLabel.Size = new System.Drawing.Size(132, 19);
            this.lastDoseLabel.TabIndex = 4;
            this.lastDoseLabel.Text = "Last Insulin Dose:";
            // 
            // takeInsulinButton
            // 
            this.takeInsulinButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takeInsulinButton.BackColor = System.Drawing.Color.PaleGreen;
            this.takeInsulinButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeInsulinButton.Location = new System.Drawing.Point(56, 272);
            this.takeInsulinButton.Name = "takeInsulinButton";
            this.takeInsulinButton.Size = new System.Drawing.Size(180, 60);
            this.takeInsulinButton.TabIndex = 3;
            this.takeInsulinButton.Text = "Dose 1 Unit of Insulin";
            this.takeInsulinButton.UseVisualStyleBackColor = false;
            // 
            // insulinDosingPanel
            // 
            this.insulinDosingPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.insulinDosingPanel.ColumnCount = 1;
            this.insulinDosingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.insulinDosingPanel.Controls.Add(this.insulinDosingChart, 0, 0);
            this.insulinDosingPanel.Location = new System.Drawing.Point(50, 60);
            this.insulinDosingPanel.Name = "insulinDosingPanel";
            this.insulinDosingPanel.Radious = 25;
            this.insulinDosingPanel.RowCount = 1;
            this.insulinDosingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.insulinDosingPanel.Size = new System.Drawing.Size(468, 394);
            this.insulinDosingPanel.TabIndex = 2;
            this.insulinDosingPanel.TitleBackColor = System.Drawing.Color.Empty;
            this.insulinDosingPanel.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.insulinDosingPanel.TitleForeColor = System.Drawing.Color.Empty;
            this.insulinDosingPanel.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // insulinDosingChart
            // 
            this.insulinDosingChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            horizontalLineAnnotation3.AnchorDataPointName = "Insulin Levels\\r0";
            horizontalLineAnnotation3.AnchorX = 0D;
            horizontalLineAnnotation3.AnchorY = 160D;
            horizontalLineAnnotation3.AxisXName = "ChartArea1\\rX";
            horizontalLineAnnotation3.ClipToChartArea = "ChartArea1";
            horizontalLineAnnotation3.LineColor = System.Drawing.Color.Red;
            horizontalLineAnnotation3.LineWidth = 3;
            horizontalLineAnnotation3.Name = "HorizontalLineAnnotation1";
            horizontalLineAnnotation3.Width = 100D;
            rectangleAnnotation3.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            rectangleAnnotation3.AnchorAlignment = System.Drawing.ContentAlignment.MiddleRight;
            rectangleAnnotation3.AnchorDataPointName = "Insulin Levels\\r0";
            rectangleAnnotation3.AnchorX = 0D;
            rectangleAnnotation3.AnchorY = 0D;
            rectangleAnnotation3.AxisXName = "ChartArea1\\rX";
            rectangleAnnotation3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            rectangleAnnotation3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent70;
            rectangleAnnotation3.BackSecondaryColor = System.Drawing.Color.Transparent;
            rectangleAnnotation3.ClipToChartArea = "ChartArea1";
            rectangleAnnotation3.Height = 30D;
            rectangleAnnotation3.Name = "RectangleAnnotation1";
            rectangleAnnotation3.Text = "TEXT";
            rectangleAnnotation3.Visible = false;
            rectangleAnnotation3.Width = 100D;
            rectangleAnnotation3.X = 0D;
            rectangleAnnotation3.Y = 160D;
            rectangleAnnotation3.YAxisName = "ChartArea1\\rY";
            this.insulinDosingChart.Annotations.Add(horizontalLineAnnotation3);
            this.insulinDosingChart.Annotations.Add(rectangleAnnotation3);
            this.insulinDosingChart.BackColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.Interval = 6D;
            chartArea3.AxisX.Maximum = 24D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea3.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea3.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea3.AxisX.Title = "Time(Hours)";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.Interval = 40D;
            chartArea3.AxisY.Maximum = 400D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Blood Sugar(mg/dL)";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.LightSlateGray;
            chartArea3.Name = "ChartArea1";
            this.insulinDosingChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.insulinDosingChart.Legends.Add(legend3);
            this.insulinDosingChart.Location = new System.Drawing.Point(19, 8);
            this.insulinDosingChart.Name = "insulinDosingChart";
            series3.BorderColor = System.Drawing.Color.White;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Insulin Levels";
            series3.Points.Add(dataPoint43);
            series3.Points.Add(dataPoint44);
            series3.Points.Add(dataPoint45);
            series3.Points.Add(dataPoint46);
            series3.Points.Add(dataPoint47);
            series3.Points.Add(dataPoint48);
            series3.Points.Add(dataPoint49);
            series3.Points.Add(dataPoint50);
            series3.Points.Add(dataPoint51);
            series3.Points.Add(dataPoint52);
            series3.Points.Add(dataPoint53);
            series3.Points.Add(dataPoint54);
            series3.Points.Add(dataPoint55);
            series3.Points.Add(dataPoint56);
            series3.Points.Add(dataPoint57);
            series3.Points.Add(dataPoint58);
            series3.Points.Add(dataPoint59);
            series3.Points.Add(dataPoint60);
            series3.Points.Add(dataPoint61);
            series3.Points.Add(dataPoint62);
            series3.Points.Add(dataPoint63);
            this.insulinDosingChart.Series.Add(series3);
            this.insulinDosingChart.Size = new System.Drawing.Size(429, 377);
            this.insulinDosingChart.TabIndex = 1;
            this.insulinDosingChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Display2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 527);
            this.Controls.Add(this.insulinInformationPanel);
            this.Controls.Add(this.insulinDosingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Display2";
            this.Text = "Display2";
            this.Load += new System.EventHandler(this.Display2_Load);
            this.insulinInformationPanel.ResumeLayout(false);
            this.insulinInformationPanel.PerformLayout();
            this.insulinDosingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.insulinDosingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart insulinDosingChart;
        private loanCalculator.RoundPanel insulinDosingPanel;
        private loanCalculator.RoundPanel insulinInformationPanel;
        private System.Windows.Forms.Label lastDoseTimeLabel;
        private System.Windows.Forms.Label lastDoseAmountLabel;
        private System.Windows.Forms.Label remainingDosesLabel;
        private loanCalculator.RoundedButton takeInsulinButton;
        private System.Windows.Forms.Label lastDoseLabel;
    }
}