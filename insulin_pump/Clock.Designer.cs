
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
            this.Clock1 = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // Clock1
            // 
            //this.Clock1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Clock1.AnimationSpeed = 500;
            this.Clock1.BackColor = System.Drawing.Color.Transparent;
            this.Clock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Clock1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clock1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Clock1.InnerMargin = 2;
            this.Clock1.InnerWidth = -1;
            this.Clock1.Location = new System.Drawing.Point(342, 100);
            this.Clock1.MarqueeAnimationSpeed = 2000;
            this.Clock1.Name = "Clock1";
            this.Clock1.OuterColor = System.Drawing.Color.Gray;
            this.Clock1.OuterMargin = -25;
            this.Clock1.OuterWidth = 26;
            this.Clock1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clock1.ProgressWidth = 25;
            this.Clock1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Clock1.Size = new System.Drawing.Size(320, 320);
            this.Clock1.StartAngle = 270;
            this.Clock1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Clock1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Clock1.SubscriptText = ".23";
            this.Clock1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Clock1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Clock1.SuperscriptText = "°C";
            this.Clock1.TabIndex = 0;
            this.Clock1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Clock1.Value = 68;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Clock1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);

        }

        public CircularProgressBar.CircularProgressBar Clock1;

        #endregion

        //private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}