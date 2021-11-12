
namespace insulin_pump
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
            this.roundPanel1 = new loanCalculator.RoundPanel();
            this.deliveryFailingLabel = new System.Windows.Forms.Label();
            this.pumpFailingLabel = new System.Windows.Forms.Label();
            this.sensorFailingLabel = new System.Windows.Forms.Label();
            this.batteryLowLabel = new System.Windows.Forms.Label();
            this.needleRemovalLabel = new System.Windows.Forms.Label();
            this.testScenariosHeaderLabel = new System.Windows.Forms.Label();
            this.resevoirRemovalLabel = new System.Windows.Forms.Label();
            this.resevoirToggle = new insulin_pump.RJToggleButton();
            this.needleToggle = new insulin_pump.RJToggleButton();
            this.batteryToggle = new insulin_pump.RJToggleButton();
            this.sensorToggle = new insulin_pump.RJToggleButton();
            this.pumpToggle = new insulin_pump.RJToggleButton();
            this.deliveryToggle = new insulin_pump.RJToggleButton();
            this.runTestButton = new loanCalculator.RoundedButton();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.roundPanel1.ColumnCount = 2;
            this.roundPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roundPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.roundPanel1.Controls.Add(this.deliveryToggle, 1, 6);
            this.roundPanel1.Controls.Add(this.pumpToggle, 1, 5);
            this.roundPanel1.Controls.Add(this.sensorToggle, 1, 4);
            this.roundPanel1.Controls.Add(this.batteryToggle, 1, 3);
            this.roundPanel1.Controls.Add(this.needleToggle, 1, 2);
            this.roundPanel1.Controls.Add(this.deliveryFailingLabel, 0, 6);
            this.roundPanel1.Controls.Add(this.pumpFailingLabel, 0, 5);
            this.roundPanel1.Controls.Add(this.sensorFailingLabel, 0, 4);
            this.roundPanel1.Controls.Add(this.batteryLowLabel, 0, 3);
            this.roundPanel1.Controls.Add(this.needleRemovalLabel, 0, 2);
            this.roundPanel1.Controls.Add(this.testScenariosHeaderLabel, 0, 0);
            this.roundPanel1.Controls.Add(this.resevoirRemovalLabel, 0, 1);
            this.roundPanel1.Controls.Add(this.resevoirToggle, 1, 1);
            this.roundPanel1.Controls.Add(this.runTestButton, 0, 7);
            this.roundPanel1.Location = new System.Drawing.Point(34, 45);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radious = 25;
            this.roundPanel1.RowCount = 8;
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.roundPanel1.Size = new System.Drawing.Size(314, 499);
            this.roundPanel1.TabIndex = 0;
            this.roundPanel1.TitleBackColor = System.Drawing.Color.Empty;
            this.roundPanel1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.roundPanel1.TitleForeColor = System.Drawing.Color.Empty;
            this.roundPanel1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // deliveryFailingLabel
            // 
            this.deliveryFailingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryFailingLabel.AutoSize = true;
            this.deliveryFailingLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryFailingLabel.Location = new System.Drawing.Point(3, 378);
            this.deliveryFailingLabel.Name = "deliveryFailingLabel";
            this.deliveryFailingLabel.Size = new System.Drawing.Size(168, 63);
            this.deliveryFailingLabel.TabIndex = 15;
            this.deliveryFailingLabel.Text = "Failure to Deliver Insulin";
            this.deliveryFailingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pumpFailingLabel
            // 
            this.pumpFailingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pumpFailingLabel.AutoSize = true;
            this.pumpFailingLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumpFailingLabel.Location = new System.Drawing.Point(3, 315);
            this.pumpFailingLabel.Name = "pumpFailingLabel";
            this.pumpFailingLabel.Size = new System.Drawing.Size(168, 63);
            this.pumpFailingLabel.TabIndex = 14;
            this.pumpFailingLabel.Text = "Insulin Pump Failing";
            this.pumpFailingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sensorFailingLabel
            // 
            this.sensorFailingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorFailingLabel.AutoSize = true;
            this.sensorFailingLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorFailingLabel.Location = new System.Drawing.Point(3, 252);
            this.sensorFailingLabel.Name = "sensorFailingLabel";
            this.sensorFailingLabel.Size = new System.Drawing.Size(168, 63);
            this.sensorFailingLabel.TabIndex = 13;
            this.sensorFailingLabel.Text = "Sensor Failing";
            this.sensorFailingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batteryLowLabel
            // 
            this.batteryLowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batteryLowLabel.AutoSize = true;
            this.batteryLowLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryLowLabel.Location = new System.Drawing.Point(3, 189);
            this.batteryLowLabel.Name = "batteryLowLabel";
            this.batteryLowLabel.Size = new System.Drawing.Size(168, 63);
            this.batteryLowLabel.TabIndex = 12;
            this.batteryLowLabel.Text = "Battery Voltage Below 0.5v";
            this.batteryLowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // needleRemovalLabel
            // 
            this.needleRemovalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.needleRemovalLabel.AutoSize = true;
            this.needleRemovalLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needleRemovalLabel.Location = new System.Drawing.Point(3, 126);
            this.needleRemovalLabel.Name = "needleRemovalLabel";
            this.needleRemovalLabel.Size = new System.Drawing.Size(168, 63);
            this.needleRemovalLabel.TabIndex = 11;
            this.needleRemovalLabel.Text = "Removal of the Needle";
            this.needleRemovalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testScenariosHeaderLabel
            // 
            this.testScenariosHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testScenariosHeaderLabel.AutoSize = true;
            this.roundPanel1.SetColumnSpan(this.testScenariosHeaderLabel, 2);
            this.testScenariosHeaderLabel.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScenariosHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.testScenariosHeaderLabel.Name = "testScenariosHeaderLabel";
            this.testScenariosHeaderLabel.Size = new System.Drawing.Size(308, 63);
            this.testScenariosHeaderLabel.TabIndex = 6;
            this.testScenariosHeaderLabel.Text = "Test Scenarios";
            this.testScenariosHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resevoirRemovalLabel
            // 
            this.resevoirRemovalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resevoirRemovalLabel.AutoSize = true;
            this.resevoirRemovalLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resevoirRemovalLabel.Location = new System.Drawing.Point(3, 63);
            this.resevoirRemovalLabel.Name = "resevoirRemovalLabel";
            this.resevoirRemovalLabel.Size = new System.Drawing.Size(168, 63);
            this.resevoirRemovalLabel.TabIndex = 10;
            this.resevoirRemovalLabel.Text = "Removal of Insulin Resevoir";
            this.resevoirRemovalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resevoirToggle
            // 
            this.resevoirToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resevoirToggle.Location = new System.Drawing.Point(206, 79);
            this.resevoirToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.resevoirToggle.Name = "resevoirToggle";
            this.resevoirToggle.OffBackColor = System.Drawing.Color.Gray;
            this.resevoirToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.resevoirToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.resevoirToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.resevoirToggle.Size = new System.Drawing.Size(76, 31);
            this.resevoirToggle.TabIndex = 16;
            this.resevoirToggle.UseVisualStyleBackColor = true;
            this.resevoirToggle.CheckedChanged += new System.EventHandler(this.resevoirToggle_CheckedChanged);
            // 
            // needleToggle
            // 
            this.needleToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.needleToggle.Location = new System.Drawing.Point(206, 142);
            this.needleToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.needleToggle.Name = "needleToggle";
            this.needleToggle.OffBackColor = System.Drawing.Color.Gray;
            this.needleToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.needleToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.needleToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.needleToggle.Size = new System.Drawing.Size(76, 31);
            this.needleToggle.TabIndex = 17;
            this.needleToggle.UseVisualStyleBackColor = true;
            this.needleToggle.CheckedChanged += new System.EventHandler(this.needleToggle_CheckedChanged);
            // 
            // batteryToggle
            // 
            this.batteryToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batteryToggle.Location = new System.Drawing.Point(206, 205);
            this.batteryToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.batteryToggle.Name = "batteryToggle";
            this.batteryToggle.OffBackColor = System.Drawing.Color.Gray;
            this.batteryToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.batteryToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.batteryToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.batteryToggle.Size = new System.Drawing.Size(76, 31);
            this.batteryToggle.TabIndex = 18;
            this.batteryToggle.UseVisualStyleBackColor = true;
            this.batteryToggle.CheckedChanged += new System.EventHandler(this.batteryToggle_CheckedChanged);
            // 
            // sensorToggle
            // 
            this.sensorToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sensorToggle.Location = new System.Drawing.Point(206, 268);
            this.sensorToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.sensorToggle.Name = "sensorToggle";
            this.sensorToggle.OffBackColor = System.Drawing.Color.Gray;
            this.sensorToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.sensorToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.sensorToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.sensorToggle.Size = new System.Drawing.Size(76, 31);
            this.sensorToggle.TabIndex = 19;
            this.sensorToggle.UseVisualStyleBackColor = true;
            this.sensorToggle.CheckedChanged += new System.EventHandler(this.sensorToggle_CheckedChanged);
            // 
            // pumpToggle
            // 
            this.pumpToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pumpToggle.Location = new System.Drawing.Point(206, 331);
            this.pumpToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.pumpToggle.Name = "pumpToggle";
            this.pumpToggle.OffBackColor = System.Drawing.Color.Gray;
            this.pumpToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.pumpToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.pumpToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.pumpToggle.Size = new System.Drawing.Size(76, 31);
            this.pumpToggle.TabIndex = 20;
            this.pumpToggle.UseVisualStyleBackColor = true;
            this.pumpToggle.CheckedChanged += new System.EventHandler(this.pumpToggle_CheckedChanged);
            // 
            // deliveryToggle
            // 
            this.deliveryToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deliveryToggle.Location = new System.Drawing.Point(206, 394);
            this.deliveryToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.deliveryToggle.Name = "deliveryToggle";
            this.deliveryToggle.OffBackColor = System.Drawing.Color.Gray;
            this.deliveryToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.deliveryToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.deliveryToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.deliveryToggle.Size = new System.Drawing.Size(76, 31);
            this.deliveryToggle.TabIndex = 21;
            this.deliveryToggle.UseVisualStyleBackColor = true;
            this.deliveryToggle.CheckedChanged += new System.EventHandler(this.deliveryToggle_CheckedChanged);
            // 
            // runTestButton
            // 
            this.runTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundPanel1.SetColumnSpan(this.runTestButton, 2);
            this.runTestButton.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runTestButton.Location = new System.Drawing.Point(23, 444);
            this.runTestButton.Name = "runTestButton";
            this.runTestButton.Size = new System.Drawing.Size(268, 52);
            this.runTestButton.TabIndex = 22;
            this.runTestButton.Text = "Run Test Scenarios";
            this.runTestButton.UseVisualStyleBackColor = true;
            this.runTestButton.Click += new System.EventHandler(this.runTestButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 631);
            this.Controls.Add(this.roundPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private loanCalculator.RoundPanel roundPanel1;
        private System.Windows.Forms.Label testScenariosHeaderLabel;
        private System.Windows.Forms.Label deliveryFailingLabel;
        private System.Windows.Forms.Label pumpFailingLabel;
        private System.Windows.Forms.Label sensorFailingLabel;
        private System.Windows.Forms.Label batteryLowLabel;
        private System.Windows.Forms.Label needleRemovalLabel;
        private System.Windows.Forms.Label resevoirRemovalLabel;
        private RJToggleButton deliveryToggle;
        private RJToggleButton pumpToggle;
        private RJToggleButton sensorToggle;
        private RJToggleButton batteryToggle;
        private RJToggleButton needleToggle;
        private RJToggleButton resevoirToggle;
        private loanCalculator.RoundedButton runTestButton;
    }
}