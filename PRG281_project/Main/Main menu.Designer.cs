namespace Goals_PRG281_project
{
    partial class frmMainMenu
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
            this.btnCreateNewBudget = new System.Windows.Forms.Button();
            this.btnViewExistingBudget = new System.Windows.Forms.Button();
            this.btnTrackExpenses = new System.Windows.Forms.Button();
            this.btnSetGoals = new System.Windows.Forms.Button();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnOptimizeMeal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBox.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNewBudget
            // 
            this.btnCreateNewBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewBudget.Location = new System.Drawing.Point(44, 18);
            this.btnCreateNewBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNewBudget.Name = "btnCreateNewBudget";
            this.btnCreateNewBudget.Size = new System.Drawing.Size(169, 114);
            this.btnCreateNewBudget.TabIndex = 0;
            this.btnCreateNewBudget.Text = "Create new budget";
            this.btnCreateNewBudget.UseVisualStyleBackColor = true;
            this.btnCreateNewBudget.Click += new System.EventHandler(this.btnCreateNewBudget_Click);
            // 
            // btnViewExistingBudget
            // 
            this.btnViewExistingBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExistingBudget.Location = new System.Drawing.Point(246, 18);
            this.btnViewExistingBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewExistingBudget.Name = "btnViewExistingBudget";
            this.btnViewExistingBudget.Size = new System.Drawing.Size(169, 114);
            this.btnViewExistingBudget.TabIndex = 1;
            this.btnViewExistingBudget.Text = "View existing budget";
            this.btnViewExistingBudget.UseVisualStyleBackColor = true;
            this.btnViewExistingBudget.Click += new System.EventHandler(this.btnViewExistingBudget_Click);
            // 
            // btnTrackExpenses
            // 
            this.btnTrackExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackExpenses.Location = new System.Drawing.Point(44, 144);
            this.btnTrackExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrackExpenses.Name = "btnTrackExpenses";
            this.btnTrackExpenses.Size = new System.Drawing.Size(169, 114);
            this.btnTrackExpenses.TabIndex = 2;
            this.btnTrackExpenses.Text = "Track expenses";
            this.btnTrackExpenses.UseVisualStyleBackColor = true;
            this.btnTrackExpenses.Click += new System.EventHandler(this.btnTrackExpenses_Click);
            // 
            // btnSetGoals
            // 
            this.btnSetGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetGoals.Location = new System.Drawing.Point(246, 144);
            this.btnSetGoals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetGoals.Name = "btnSetGoals";
            this.btnSetGoals.Size = new System.Drawing.Size(169, 114);
            this.btnSetGoals.TabIndex = 3;
            this.btnSetGoals.Text = "Set financial goals";
            this.btnSetGoals.UseVisualStyleBackColor = true;
            this.btnSetGoals.Click += new System.EventHandler(this.btnSetGoals_Click);
            // 
            // pnlBox
            // 
            this.pnlBox.Controls.Add(this.pnlExit);
            this.pnlBox.Controls.Add(this.btnCreateNewBudget);
            this.pnlBox.Controls.Add(this.btnViewExistingBudget);
            this.pnlBox.Controls.Add(this.btnSetGoals);
            this.pnlBox.Controls.Add(this.btnTrackExpenses);
            this.pnlBox.Controls.Add(this.btnOptimizeMeal);
            this.pnlBox.Location = new System.Drawing.Point(75, 104);
            this.pnlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(633, 298);
            this.pnlBox.TabIndex = 5;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnYes);
            this.pnlExit.Controls.Add(this.btnNo);
            this.pnlExit.Controls.Add(this.lblExit);
            this.pnlExit.Location = new System.Drawing.Point(197, 79);
            this.pnlExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(244, 93);
            this.pnlExit.TabIndex = 7;
            this.pnlExit.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(139, 46);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(72, 28);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(29, 46);
            this.btnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(72, 28);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(26, 12);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(181, 16);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "Are you sure you want to exit?";
            // 
            // btnOptimizeMeal
            // 
            this.btnOptimizeMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptimizeMeal.Location = new System.Drawing.Point(434, 18);
            this.btnOptimizeMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOptimizeMeal.Name = "btnOptimizeMeal";
            this.btnOptimizeMeal.Size = new System.Drawing.Size(169, 240);
            this.btnOptimizeMeal.TabIndex = 7;
            this.btnOptimizeMeal.Text = "Optimize meal plan";
            this.btnOptimizeMeal.UseVisualStyleBackColor = true;
            this.btnOptimizeMeal.Click += new System.EventHandler(this.btnOptimizeMeal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(721, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(88, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(447, 69);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Budget planner";
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(-62, -36);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(901, 509);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 33;
            this.picBackground.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(75, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 105);
            this.panel1.TabIndex = 42;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(776, 436);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlBox.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewBudget;
        private System.Windows.Forms.Button btnViewExistingBudget;
        private System.Windows.Forms.Button btnTrackExpenses;
        private System.Windows.Forms.Button btnSetGoals;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnOptimizeMeal;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel panel1;
    }
}

