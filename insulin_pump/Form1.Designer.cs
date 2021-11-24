
namespace insulin_pump
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.BatterylvlLbl = new System.Windows.Forms.Label();
            this.RemainingDoseslbl = new System.Windows.Forms.Label();
            this.QuickNotificationlbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testScenariosButton = new System.Windows.Forms.Button();
            this.btn_clock = new System.Windows.Forms.Button();
            this.btn_display_2 = new System.Windows.Forms.Button();
            this.btn_display_1 = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Label();
            this.panelSide.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.panelSide.Controls.Add(this.Line);
            this.panelSide.Controls.Add(this.BatterylvlLbl);
            this.panelSide.Controls.Add(this.RemainingDoseslbl);
            this.panelSide.Controls.Add(this.QuickNotificationlbl);
            this.panelSide.Controls.Add(this.timeLbl);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 44);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(251, 527);
            this.panelSide.TabIndex = 0;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // BatterylvlLbl
            // 
            this.BatterylvlLbl.AutoSize = true;
            this.BatterylvlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatterylvlLbl.ForeColor = System.Drawing.Color.White;
            this.BatterylvlLbl.Location = new System.Drawing.Point(12, 489);
            this.BatterylvlLbl.Name = "BatterylvlLbl";
            this.BatterylvlLbl.Size = new System.Drawing.Size(163, 29);
            this.BatterylvlLbl.TabIndex = 4;
            this.BatterylvlLbl.Text = "Battery Level: ";
            // 
            // RemainingDoseslbl
            // 
            this.RemainingDoseslbl.AutoSize = true;
            this.RemainingDoseslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingDoseslbl.ForeColor = System.Drawing.Color.White;
            this.RemainingDoseslbl.Location = new System.Drawing.Point(8, 58);
            this.RemainingDoseslbl.Name = "RemainingDoseslbl";
            this.RemainingDoseslbl.Size = new System.Drawing.Size(216, 29);
            this.RemainingDoseslbl.TabIndex = 3;
            this.RemainingDoseslbl.Text = "Remaining Doses: ";
            // 
            // QuickNotificationlbl
            // 
            this.QuickNotificationlbl.AutoSize = true;
            this.QuickNotificationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickNotificationlbl.ForeColor = System.Drawing.Color.White;
            this.QuickNotificationlbl.Location = new System.Drawing.Point(7, 3);
            this.QuickNotificationlbl.Name = "QuickNotificationlbl";
            this.QuickNotificationlbl.Size = new System.Drawing.Size(241, 31);
            this.QuickNotificationlbl.TabIndex = 2;
            this.QuickNotificationlbl.Text = "Quick Notifications";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.timeLbl.Location = new System.Drawing.Point(12, 447);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(103, 29);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "20:59:56";
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.panelheader.Controls.Add(this.tableLayoutPanel1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1180, 44);
            this.panelheader.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.10169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.372881F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.Controls.Add(this.testScenariosButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_clock, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_display_2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_display_1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // testScenariosButton
            // 
            this.testScenariosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(217)))), ((int)(((byte)(26)))));
            this.testScenariosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.testScenariosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScenariosButton.ForeColor = System.Drawing.Color.White;
            this.testScenariosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testScenariosButton.Location = new System.Drawing.Point(3, 3);
            this.testScenariosButton.Name = "testScenariosButton";
            this.testScenariosButton.Size = new System.Drawing.Size(225, 38);
            this.testScenariosButton.TabIndex = 4;
            this.testScenariosButton.Text = "Test Scenarios";
            this.testScenariosButton.UseVisualStyleBackColor = false;
            this.testScenariosButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_clock
            // 
            this.btn_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(217)))), ((int)(((byte)(26)))));
            this.btn_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clock.ForeColor = System.Drawing.Color.Black;
            this.btn_clock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clock.Location = new System.Drawing.Point(901, 3);
            this.btn_clock.Name = "btn_clock";
            this.btn_clock.Size = new System.Drawing.Size(251, 38);
            this.btn_clock.TabIndex = 2;
            this.btn_clock.Text = "Clock";
            this.btn_clock.UseVisualStyleBackColor = false;
            this.btn_clock.Click += new System.EventHandler(this.btn_clock_Click);
            // 
            // btn_display_2
            // 
            this.btn_display_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(217)))), ((int)(((byte)(26)))));
            this.btn_display_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_display_2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display_2.ForeColor = System.Drawing.Color.White;
            this.btn_display_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_display_2.Location = new System.Drawing.Point(620, 3);
            this.btn_display_2.Name = "btn_display_2";
            this.btn_display_2.Size = new System.Drawing.Size(251, 38);
            this.btn_display_2.TabIndex = 1;
            this.btn_display_2.Text = "Administer Insulin";
            this.btn_display_2.UseVisualStyleBackColor = false;
            this.btn_display_2.Click += new System.EventHandler(this.btn_display_2_Click);
            // 
            // btn_display_1
            // 
            this.btn_display_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(217)))), ((int)(((byte)(26)))));
            this.btn_display_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_display_1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display_1.ForeColor = System.Drawing.Color.White;
            this.btn_display_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_display_1.Location = new System.Drawing.Point(339, 3);
            this.btn_display_1.Name = "btn_display_1";
            this.btn_display_1.Size = new System.Drawing.Size(251, 38);
            this.btn_display_1.TabIndex = 0;
            this.btn_display_1.Text = "Messages";
            this.btn_display_1.UseVisualStyleBackColor = false;
            this.btn_display_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(251, 44);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(929, 527);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.BackColor = System.Drawing.Color.Transparent;
            this.Line.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Line.Location = new System.Drawing.Point(0, 34);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(253, 13);
            this.Line.TabIndex = 5;
            this.Line.Text = "_________________________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 571);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelheader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
 
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btn_display_1;
        private System.Windows.Forms.Button btn_clock;
        private System.Windows.Forms.Button btn_display_2;
        public System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label QuickNotificationlbl;
        private System.Windows.Forms.Label RemainingDoseslbl;
        private System.Windows.Forms.Label BatterylvlLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button testScenariosButton;
        private System.Windows.Forms.Label Line;
    }
}

