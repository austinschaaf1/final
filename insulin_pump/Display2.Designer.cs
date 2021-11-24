
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
            System.Windows.Forms.DataVisualization.Charting.HorizontalLineAnnotation horizontalLineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.HorizontalLineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangleAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 115D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 108D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 125D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 140D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 150D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 110D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 96D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 92D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 90D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 112D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 122D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(13D, 108D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(14D, 98D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(15D, 115D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(16D, 125D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(17D, 136D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(18D, 140D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(19D, 165D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 132D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(21D, 118D);
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
            horizontalLineAnnotation1.AnchorDataPointName = "Insulin Levels\\r0";
            horizontalLineAnnotation1.AnchorX = 0D;
            horizontalLineAnnotation1.AnchorY = 160D;
            horizontalLineAnnotation1.AxisXName = "ChartArea1\\rX";
            horizontalLineAnnotation1.ClipToChartArea = "ChartArea1";
            horizontalLineAnnotation1.LineColor = System.Drawing.Color.Red;
            horizontalLineAnnotation1.LineWidth = 3;
            horizontalLineAnnotation1.Name = "HorizontalLineAnnotation1";
            horizontalLineAnnotation1.Width = 100D;
            rectangleAnnotation1.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            rectangleAnnotation1.AnchorAlignment = System.Drawing.ContentAlignment.MiddleRight;
            rectangleAnnotation1.AnchorDataPointName = "Insulin Levels\\r0";
            rectangleAnnotation1.AnchorX = 0D;
            rectangleAnnotation1.AnchorY = 0D;
            rectangleAnnotation1.AxisXName = "ChartArea1\\rX";
            rectangleAnnotation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            rectangleAnnotation1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent70;
            rectangleAnnotation1.BackSecondaryColor = System.Drawing.Color.Transparent;
            rectangleAnnotation1.ClipToChartArea = "ChartArea1";
            rectangleAnnotation1.Height = 30D;
            rectangleAnnotation1.Name = "RectangleAnnotation1";
            rectangleAnnotation1.Text = "TEXT";
            rectangleAnnotation1.Visible = false;
            rectangleAnnotation1.Width = 100D;
            rectangleAnnotation1.X = 0D;
            rectangleAnnotation1.Y = 160D;
            rectangleAnnotation1.YAxisName = "ChartArea1\\rY";
            this.insulinDosingChart.Annotations.Add(horizontalLineAnnotation1);
            this.insulinDosingChart.Annotations.Add(rectangleAnnotation1);
            this.insulinDosingChart.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.Interval = 6D;
            chartArea1.AxisX.Maximum = 24D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisX.Title = "Time(Hours)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Interval = 40D;
            chartArea1.AxisY.Maximum = 400D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Blood Sugar(mg/dL)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.LightSlateGray;
            chartArea1.Name = "ChartArea1";
            this.insulinDosingChart.ChartAreas.Add(chartArea1);
            legendItem1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legendItem1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            legendItem1.Color = System.Drawing.Color.LimeGreen;
            legendItem1.MarkerBorderColor = System.Drawing.Color.White;
            legendItem1.MarkerColor = System.Drawing.Color.White;
            legendItem1.Name = "Blood Glucose";
            legendItem1.SeparatorColor = System.Drawing.Color.Bisque;
            legend1.CustomItems.Add(legendItem1);
            legend1.Name = "Legend1";
            this.insulinDosingChart.Legends.Add(legend1);
            this.insulinDosingChart.Location = new System.Drawing.Point(19, 8);
            this.insulinDosingChart.Name = "insulinDosingChart";
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Insulin Levels";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.Points.Add(dataPoint12);
            series1.Points.Add(dataPoint13);
            series1.Points.Add(dataPoint14);
            series1.Points.Add(dataPoint15);
            series1.Points.Add(dataPoint16);
            series1.Points.Add(dataPoint17);
            series1.Points.Add(dataPoint18);
            series1.Points.Add(dataPoint19);
            series1.Points.Add(dataPoint20);
            series1.Points.Add(dataPoint21);
            this.insulinDosingChart.Series.Add(series1);
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