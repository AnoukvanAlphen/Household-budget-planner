namespace Goals_PRG281_project
{
    partial class frmCurrent_goals
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
            this.llblGoalSetting = new System.Windows.Forms.LinkLabel();
            this.lblCurrentGoals = new System.Windows.Forms.Label();
            this.lblNoGoalsyet = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llblMainMenu = new System.Windows.Forms.LinkLabel();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // llblGoalSetting
            // 
            this.llblGoalSetting.AutoSize = true;
            this.llblGoalSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGoalSetting.Location = new System.Drawing.Point(119, 7);
            this.llblGoalSetting.Name = "llblGoalSetting";
            this.llblGoalSetting.Size = new System.Drawing.Size(87, 18);
            this.llblGoalSetting.TabIndex = 1;
            this.llblGoalSetting.TabStop = true;
            this.llblGoalSetting.Text = "Goal setting";
            this.llblGoalSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGoalSetting_LinkClicked);
            // 
            // lblCurrentGoals
            // 
            this.lblCurrentGoals.AutoSize = true;
            this.lblCurrentGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGoals.Location = new System.Drawing.Point(212, 9);
            this.lblCurrentGoals.Name = "lblCurrentGoals";
            this.lblCurrentGoals.Size = new System.Drawing.Size(110, 18);
            this.lblCurrentGoals.TabIndex = 2;
            this.lblCurrentGoals.Text = "> Current goals";
            // 
            // lblNoGoalsyet
            // 
            this.lblNoGoalsyet.AutoSize = true;
            this.lblNoGoalsyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoGoalsyet.Location = new System.Drawing.Point(3, 0);
            this.lblNoGoalsyet.Name = "lblNoGoalsyet";
            this.lblNoGoalsyet.Size = new System.Drawing.Size(63, 20);
            this.lblNoGoalsyet.TabIndex = 5;
            this.lblNoGoalsyet.Text = "Goals :";
            this.lblNoGoalsyet.Click += new System.EventHandler(this.lblNoGoalsyet_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lblNoGoalsyet);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 58);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(609, 470);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // llblMainMenu
            // 
            this.llblMainMenu.AutoSize = true;
            this.llblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMainMenu.Location = new System.Drawing.Point(8, 7);
            this.llblMainMenu.Name = "llblMainMenu";
            this.llblMainMenu.Size = new System.Drawing.Size(94, 18);
            this.llblMainMenu.TabIndex = 14;
            this.llblMainMenu.TabStop = true;
            this.llblMainMenu.Text = "Main Menu >";
            this.llblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMainMenu_LinkClicked);
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(-68, 28);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(747, 531);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 34;
            this.picBackground.TabStop = false;
            this.picBackground.Click += new System.EventHandler(this.picBackground_Click);
            // 
            // frmCurrent_goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(676, 557);
            this.Controls.Add(this.llblMainMenu);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCurrentGoals);
            this.Controls.Add(this.llblGoalSetting);
            this.Controls.Add(this.picBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCurrent_goals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current goals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCurrent_goals_FormClosed);
            this.Load += new System.EventHandler(this.frmCurrent_goals_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llblGoalSetting;
        private System.Windows.Forms.Label lblCurrentGoals;
        private System.Windows.Forms.Label lblNoGoalsyet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llblMainMenu;
        private System.Windows.Forms.PictureBox picBackground;
    }
}