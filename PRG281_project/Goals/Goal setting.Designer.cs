namespace Goals_PRG281_project
{
    partial class frmGoal_setting
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
            this.lblGoalName = new System.Windows.Forms.Label();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.pnlSetGoal = new System.Windows.Forms.Panel();
            this.dtDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.Deadline = new System.Windows.Forms.Label();
            this.btnSaveGoal = new System.Windows.Forms.Button();
            this.btnViewGoals = new System.Windows.Forms.Button();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.llblGotoBudget = new System.Windows.Forms.LinkLabel();
            this.llblMainMenu = new System.Windows.Forms.LinkLabel();
            this.lblCurrentScreen = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlSetGoal.SuspendLayout();
            this.pnlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGoalName
            // 
            this.lblGoalName.AutoSize = true;
            this.lblGoalName.Location = new System.Drawing.Point(19, 26);
            this.lblGoalName.Name = "lblGoalName";
            this.lblGoalName.Size = new System.Drawing.Size(175, 25);
            this.lblGoalName.TabIndex = 0;
            this.lblGoalName.Text = "Enter goal name:";
            this.lblGoalName.Click += new System.EventHandler(this.lblGoalName_Click);
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.AutoSize = true;
            this.lblTargetAmount.Location = new System.Drawing.Point(19, 82);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(188, 25);
            this.lblTargetAmount.TabIndex = 1;
            this.lblTargetAmount.Text = "Set target amount:";
            // 
            // pnlSetGoal
            // 
            this.pnlSetGoal.Controls.Add(this.dtDeadline);
            this.pnlSetGoal.Controls.Add(this.txtTargetAmount);
            this.pnlSetGoal.Controls.Add(this.txtGoalName);
            this.pnlSetGoal.Controls.Add(this.Deadline);
            this.pnlSetGoal.Controls.Add(this.lblGoalName);
            this.pnlSetGoal.Controls.Add(this.lblTargetAmount);
            this.pnlSetGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSetGoal.Location = new System.Drawing.Point(25, 78);
            this.pnlSetGoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSetGoal.Name = "pnlSetGoal";
            this.pnlSetGoal.Size = new System.Drawing.Size(788, 279);
            this.pnlSetGoal.TabIndex = 2;
            // 
            // dtDeadline
            // 
            this.dtDeadline.Location = new System.Drawing.Point(216, 136);
            this.dtDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDeadline.Name = "dtDeadline";
            this.dtDeadline.Size = new System.Drawing.Size(372, 31);
            this.dtDeadline.TabIndex = 3;
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.Location = new System.Drawing.Point(216, 79);
            this.txtTargetAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(372, 31);
            this.txtTargetAmount.TabIndex = 5;
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(216, 26);
            this.txtGoalName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(372, 31);
            this.txtGoalName.TabIndex = 4;
            // 
            // Deadline
            // 
            this.Deadline.AutoSize = true;
            this.Deadline.Location = new System.Drawing.Point(19, 145);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(138, 25);
            this.Deadline.TabIndex = 3;
            this.Deadline.Text = "Set deadline:";
            this.Deadline.Click += new System.EventHandler(this.Deadline_Click);
            // 
            // btnSaveGoal
            // 
            this.btnSaveGoal.Location = new System.Drawing.Point(216, 41);
            this.btnSaveGoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveGoal.Name = "btnSaveGoal";
            this.btnSaveGoal.Size = new System.Drawing.Size(372, 54);
            this.btnSaveGoal.TabIndex = 4;
            this.btnSaveGoal.Text = "Save goal";
            this.btnSaveGoal.UseVisualStyleBackColor = true;
            this.btnSaveGoal.Click += new System.EventHandler(this.btnSaveGoal_Click);
            // 
            // btnViewGoals
            // 
            this.btnViewGoals.Location = new System.Drawing.Point(216, 114);
            this.btnViewGoals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewGoals.Name = "btnViewGoals";
            this.btnViewGoals.Size = new System.Drawing.Size(372, 55);
            this.btnViewGoals.TabIndex = 5;
            this.btnViewGoals.Text = "View current goals";
            this.btnViewGoals.UseVisualStyleBackColor = true;
            this.btnViewGoals.Click += new System.EventHandler(this.btnViewGoals_Click);
            // 
            // pnlBox
            // 
            this.pnlBox.Controls.Add(this.btnViewGoals);
            this.pnlBox.Controls.Add(this.btnSaveGoal);
            this.pnlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBox.Location = new System.Drawing.Point(25, 376);
            this.pnlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(788, 189);
            this.pnlBox.TabIndex = 6;
            // 
            // llblGotoBudget
            // 
            this.llblGotoBudget.AutoSize = true;
            this.llblGotoBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGotoBudget.Location = new System.Drawing.Point(744, 11);
            this.llblGotoBudget.Name = "llblGotoBudget";
            this.llblGotoBudget.Size = new System.Drawing.Size(110, 22);
            this.llblGotoBudget.TabIndex = 6;
            this.llblGotoBudget.TabStop = true;
            this.llblGotoBudget.Text = "go to budget";
            this.llblGotoBudget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGotoBudget_LinkClicked);
            // 
            // llblMainMenu
            // 
            this.llblMainMenu.AutoSize = true;
            this.llblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMainMenu.Location = new System.Drawing.Point(12, 9);
            this.llblMainMenu.Name = "llblMainMenu";
            this.llblMainMenu.Size = new System.Drawing.Size(97, 22);
            this.llblMainMenu.TabIndex = 7;
            this.llblMainMenu.TabStop = true;
            this.llblMainMenu.Text = "Main menu";
            this.llblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMainMenu_LinkClicked);
            // 
            // lblCurrentScreen
            // 
            this.lblCurrentScreen.AutoSize = true;
            this.lblCurrentScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScreen.Location = new System.Drawing.Point(100, 9);
            this.lblCurrentScreen.Name = "lblCurrentScreen";
            this.lblCurrentScreen.Size = new System.Drawing.Size(122, 22);
            this.lblCurrentScreen.TabIndex = 6;
            this.lblCurrentScreen.Text = "> Goal setting";
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(-70, 35);
            this.picBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(951, 575);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 34;
            this.picBackground.TabStop = false;
            // 
            // frmGoal_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(873, 584);
            this.Controls.Add(this.llblGotoBudget);
            this.Controls.Add(this.lblCurrentScreen);
            this.Controls.Add(this.llblMainMenu);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.pnlSetGoal);
            this.Controls.Add(this.picBackground);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGoal_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goal setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGoal_setting_FormClosed);
            this.Load += new System.EventHandler(this.frmGoal_setting_Load_1);
            this.pnlSetGoal.ResumeLayout(false);
            this.pnlSetGoal.PerformLayout();
            this.pnlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoalName;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.Panel pnlSetGoal;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.Label Deadline;
        private System.Windows.Forms.TextBox txtTargetAmount;
        private System.Windows.Forms.DateTimePicker dtDeadline;
        private System.Windows.Forms.Button btnSaveGoal;
        private System.Windows.Forms.Button btnViewGoals;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.LinkLabel llblGotoBudget;
        private System.Windows.Forms.LinkLabel llblMainMenu;
        private System.Windows.Forms.Label lblCurrentScreen;
        private System.Windows.Forms.PictureBox picBackground;
    }
}