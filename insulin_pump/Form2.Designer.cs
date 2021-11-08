
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
            this.removeNeedle = new loanCalculator.RoundedButton();
            this.batteryVoltageFailing = new loanCalculator.RoundedButton();
            this.sensorFailing = new loanCalculator.RoundedButton();
            this.pumpFailing = new loanCalculator.RoundedButton();
            this.failureToDeliver = new loanCalculator.RoundedButton();
            this.testScenariosHeaderLabel = new System.Windows.Forms.Label();
            this.removeInsulinResevoir = new loanCalculator.RoundedButton();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.roundPanel1.ColumnCount = 1;
            this.roundPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roundPanel1.Controls.Add(this.removeInsulinResevoir, 0, 1);
            this.roundPanel1.Controls.Add(this.removeNeedle, 0, 2);
            this.roundPanel1.Controls.Add(this.batteryVoltageFailing, 0, 3);
            this.roundPanel1.Controls.Add(this.sensorFailing, 0, 4);
            this.roundPanel1.Controls.Add(this.pumpFailing, 0, 5);
            this.roundPanel1.Controls.Add(this.failureToDeliver, 0, 6);
            this.roundPanel1.Controls.Add(this.testScenariosHeaderLabel, 0, 0);
            this.roundPanel1.Location = new System.Drawing.Point(34, 45);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radious = 25;
            this.roundPanel1.RowCount = 7;
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.roundPanel1.Size = new System.Drawing.Size(314, 446);
            this.roundPanel1.TabIndex = 0;
            this.roundPanel1.TitleBackColor = System.Drawing.Color.Empty;
            this.roundPanel1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.roundPanel1.TitleForeColor = System.Drawing.Color.Empty;
            this.roundPanel1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // removeNeedle
            // 
            this.removeNeedle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeNeedle.BackColor = System.Drawing.Color.SteelBlue;
            this.removeNeedle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeNeedle.ForeColor = System.Drawing.Color.White;
            this.removeNeedle.Location = new System.Drawing.Point(3, 129);
            this.removeNeedle.Name = "removeNeedle";
            this.removeNeedle.Size = new System.Drawing.Size(308, 57);
            this.removeNeedle.TabIndex = 1;
            this.removeNeedle.Text = "Removal of the Needle";
            this.removeNeedle.UseVisualStyleBackColor = false;
            this.removeNeedle.Click += new System.EventHandler(this.removeNeedle_Click);
            // 
            // batteryVoltageFailing
            // 
            this.batteryVoltageFailing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batteryVoltageFailing.BackColor = System.Drawing.Color.SteelBlue;
            this.batteryVoltageFailing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryVoltageFailing.ForeColor = System.Drawing.Color.White;
            this.batteryVoltageFailing.Location = new System.Drawing.Point(3, 192);
            this.batteryVoltageFailing.Name = "batteryVoltageFailing";
            this.batteryVoltageFailing.Size = new System.Drawing.Size(308, 57);
            this.batteryVoltageFailing.TabIndex = 2;
            this.batteryVoltageFailing.Text = "Battery Voltage Below 0.5v";
            this.batteryVoltageFailing.UseVisualStyleBackColor = false;
            // 
            // sensorFailing
            // 
            this.sensorFailing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorFailing.BackColor = System.Drawing.Color.SteelBlue;
            this.sensorFailing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorFailing.ForeColor = System.Drawing.Color.White;
            this.sensorFailing.Location = new System.Drawing.Point(3, 255);
            this.sensorFailing.Name = "sensorFailing";
            this.sensorFailing.Size = new System.Drawing.Size(308, 57);
            this.sensorFailing.TabIndex = 3;
            this.sensorFailing.Text = "Sensor Failing";
            this.sensorFailing.UseVisualStyleBackColor = false;
            // 
            // pumpFailing
            // 
            this.pumpFailing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pumpFailing.BackColor = System.Drawing.Color.SteelBlue;
            this.pumpFailing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumpFailing.ForeColor = System.Drawing.Color.White;
            this.pumpFailing.Location = new System.Drawing.Point(3, 318);
            this.pumpFailing.Name = "pumpFailing";
            this.pumpFailing.Size = new System.Drawing.Size(308, 57);
            this.pumpFailing.TabIndex = 4;
            this.pumpFailing.Text = "Insulin Pump Failing";
            this.pumpFailing.UseVisualStyleBackColor = false;
            // 
            // failureToDeliver
            // 
            this.failureToDeliver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.failureToDeliver.BackColor = System.Drawing.Color.SteelBlue;
            this.failureToDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failureToDeliver.ForeColor = System.Drawing.Color.White;
            this.failureToDeliver.Location = new System.Drawing.Point(3, 381);
            this.failureToDeliver.Name = "failureToDeliver";
            this.failureToDeliver.Size = new System.Drawing.Size(308, 62);
            this.failureToDeliver.TabIndex = 5;
            this.failureToDeliver.Text = "Failure to Deliver Insulin";
            this.failureToDeliver.UseVisualStyleBackColor = false;
            // 
            // testScenariosHeaderLabel
            // 
            this.testScenariosHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testScenariosHeaderLabel.AutoSize = true;
            this.testScenariosHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScenariosHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.testScenariosHeaderLabel.Name = "testScenariosHeaderLabel";
            this.testScenariosHeaderLabel.Size = new System.Drawing.Size(308, 63);
            this.testScenariosHeaderLabel.TabIndex = 6;
            this.testScenariosHeaderLabel.Text = "Test Scenarios";
            this.testScenariosHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeInsulinResevoir
            // 
            this.removeInsulinResevoir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeInsulinResevoir.BackColor = System.Drawing.Color.SteelBlue;
            this.removeInsulinResevoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeInsulinResevoir.ForeColor = System.Drawing.Color.White;
            this.removeInsulinResevoir.Location = new System.Drawing.Point(3, 66);
            this.removeInsulinResevoir.Name = "removeInsulinResevoir";
            this.removeInsulinResevoir.Size = new System.Drawing.Size(308, 57);
            this.removeInsulinResevoir.TabIndex = 0;
            this.removeInsulinResevoir.Text = "Removal of Insulin Resevoir";
            this.removeInsulinResevoir.UseVisualStyleBackColor = false;
            this.removeInsulinResevoir.Click += new System.EventHandler(this.removeInsulinResevoir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 530);
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
        private loanCalculator.RoundedButton removeInsulinResevoir;
        private loanCalculator.RoundedButton removeNeedle;
        private loanCalculator.RoundedButton batteryVoltageFailing;
        private loanCalculator.RoundedButton sensorFailing;
        private loanCalculator.RoundedButton pumpFailing;
        private loanCalculator.RoundedButton failureToDeliver;
        private System.Windows.Forms.Label testScenariosHeaderLabel;
    }
}