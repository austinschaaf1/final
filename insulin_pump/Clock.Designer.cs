using System.Drawing;

namespace insulin_pump
{
    partial class Clock
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
            this.components = new System.ComponentModel.Container();
            this.Clock1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Clock1
            // 
            this.Clock1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Clock1.AnimationSpeed = 500;
            this.Clock1.BackColor = System.Drawing.Color.Transparent;
            this.Clock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock1.ForeColor = System.Drawing.Color.White;
            this.Clock1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.Clock1.InnerMargin = 2;
            this.Clock1.InnerWidth = -1;
            this.Clock1.Location = new System.Drawing.Point(198, 60);
            this.Clock1.Margin = new System.Windows.Forms.Padding(2);
            this.Clock1.MarqueeAnimationSpeed = 6000;
            this.Clock1.Name = "Clock1";
            this.Clock1.OuterColor = System.Drawing.Color.Gray;
            this.Clock1.OuterMargin = -25;
            this.Clock1.OuterWidth = 26;
            this.Clock1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(217)))), ((int)(((byte)(50)))));
            this.Clock1.ProgressWidth = 25;
            this.Clock1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Clock1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Clock1.Size = new System.Drawing.Size(395, 360);
            this.Clock1.StartAngle = 270;
            this.Clock1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Clock1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Clock1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Clock1.SubscriptText = "";
            this.Clock1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Clock1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Clock1.SuperscriptText = "";
            this.Clock1.TabIndex = 0;
            this.Clock1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.toolTip1.SetToolTip(this.Clock1, "Total remaining time until doses reset. Once time reaches 24 doses will reset");
            this.Clock1.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time until dosage reset";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clock1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public CircularProgressBar.CircularProgressBar Clock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;

        #endregion

        //private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}
