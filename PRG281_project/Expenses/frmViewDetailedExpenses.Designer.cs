namespace Goals_PRG281_project
{
    partial class frmViewDetailedExpenses
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
            this.llblBudgetsetup = new System.Windows.Forms.LinkLabel();
            this.llblMainMenu = new System.Windows.Forms.LinkLabel();
            this.lblDetailedExpenses = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBudgetedAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerSpent = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.txtCategoryPercentage = new System.Windows.Forms.Label();
            this.tbCntrl1 = new System.Windows.Forms.TabControl();
            this.tbPg1 = new System.Windows.Forms.TabPage();
            this.pnlBox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbCntrl1.SuspendLayout();
            this.pnlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblBudgetsetup
            // 
            this.llblBudgetsetup.AutoSize = true;
            this.llblBudgetsetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblBudgetsetup.Location = new System.Drawing.Point(122, 9);
            this.llblBudgetsetup.Name = "llblBudgetsetup";
            this.llblBudgetsetup.Size = new System.Drawing.Size(107, 18);
            this.llblBudgetsetup.TabIndex = 10;
            this.llblBudgetsetup.TabStop = true;
            this.llblBudgetsetup.Text = "Budget setup >";
            this.llblBudgetsetup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBudgetsetup_LinkClicked_1);
            // 
            // llblMainMenu
            // 
            this.llblMainMenu.AutoSize = true;
            this.llblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMainMenu.Location = new System.Drawing.Point(14, 9);
            this.llblMainMenu.Name = "llblMainMenu";
            this.llblMainMenu.Size = new System.Drawing.Size(94, 18);
            this.llblMainMenu.TabIndex = 9;
            this.llblMainMenu.TabStop = true;
            this.llblMainMenu.Text = "Main menu >";
            this.llblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMainMenu_LinkClicked);
            // 
            // lblDetailedExpenses
            // 
            this.lblDetailedExpenses.AutoSize = true;
            this.lblDetailedExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailedExpenses.Location = new System.Drawing.Point(247, 9);
            this.lblDetailedExpenses.Name = "lblDetailedExpenses";
            this.lblDetailedExpenses.Size = new System.Drawing.Size(125, 18);
            this.lblDetailedExpenses.TabIndex = 12;
            this.lblDetailedExpenses.Text = "detailed expenses";
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(-1, 30);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1039, 484);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 33;
            this.picBackground.TabStop = false;
            this.picBackground.Click += new System.EventHandler(this.picBackground_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBudgetedAmount);
            this.panel1.Location = new System.Drawing.Point(29, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 74);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Budgeted Amount :";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblBudgetedAmount
            // 
            this.lblBudgetedAmount.AutoSize = true;
            this.lblBudgetedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetedAmount.Location = new System.Drawing.Point(15, 39);
            this.lblBudgetedAmount.Name = "lblBudgetedAmount";
            this.lblBudgetedAmount.Size = new System.Drawing.Size(108, 25);
            this.lblBudgetedAmount.TabIndex = 27;
            this.lblBudgetedAmount.Text = "________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Amount remaining :";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // lblPerSpent
            // 
            this.lblPerSpent.AutoSize = true;
            this.lblPerSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerSpent.Location = new System.Drawing.Point(555, 34);
            this.lblPerSpent.Name = "lblPerSpent";
            this.lblPerSpent.Size = new System.Drawing.Size(176, 25);
            this.lblPerSpent.TabIndex = 23;
            this.lblPerSpent.Text = "Percentage spent :";
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingAmount.Location = new System.Drawing.Point(289, 59);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(108, 25);
            this.lblRemainingAmount.TabIndex = 28;
            this.lblRemainingAmount.Text = "________";
            // 
            // txtCategoryPercentage
            // 
            this.txtCategoryPercentage.AutoSize = true;
            this.txtCategoryPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryPercentage.Location = new System.Drawing.Point(555, 59);
            this.txtCategoryPercentage.Name = "txtCategoryPercentage";
            this.txtCategoryPercentage.Size = new System.Drawing.Size(108, 25);
            this.txtCategoryPercentage.TabIndex = 24;
            this.txtCategoryPercentage.Text = "________";
            this.txtCategoryPercentage.Click += new System.EventHandler(this.txtCategoryPercentage_Click_1);
            // 
            // tbCntrl1
            // 
            this.tbCntrl1.Controls.Add(this.tbPg1);
            this.tbCntrl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrl1.Location = new System.Drawing.Point(25, 98);
            this.tbCntrl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCntrl1.Name = "tbCntrl1";
            this.tbCntrl1.SelectedIndex = 0;
            this.tbCntrl1.Size = new System.Drawing.Size(968, 303);
            this.tbCntrl1.TabIndex = 14;
            // 
            // tbPg1
            // 
            this.tbPg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPg1.Location = new System.Drawing.Point(4, 31);
            this.tbPg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPg1.Name = "tbPg1";
            this.tbPg1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPg1.Size = new System.Drawing.Size(960, 268);
            this.tbPg1.TabIndex = 0;
            this.tbPg1.Text = "place holder";
            this.tbPg1.UseVisualStyleBackColor = true;
            this.tbPg1.Click += new System.EventHandler(this.tbPg1_Click);
            // 
            // pnlBox
            // 
            this.pnlBox.Controls.Add(this.txtCategoryPercentage);
            this.pnlBox.Controls.Add(this.lblRemainingAmount);
            this.pnlBox.Controls.Add(this.lblPerSpent);
            this.pnlBox.Controls.Add(this.label2);
            this.pnlBox.Controls.Add(this.panel1);
            this.pnlBox.Controls.Add(this.tbCntrl1);
            this.pnlBox.Location = new System.Drawing.Point(17, 69);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(1010, 426);
            this.pnlBox.TabIndex = 29;
            // 
            // frmViewDetailedExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1037, 521);
            this.Controls.Add(this.lblDetailedExpenses);
            this.Controls.Add(this.llblBudgetsetup);
            this.Controls.Add(this.llblMainMenu);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.picBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmViewDetailedExpenses";
            this.Text = "Detailed Expenses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewDetailedExpenses_FormClosed);
            this.Load += new System.EventHandler(this.frmViewDetailedExpenses_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbCntrl1.ResumeLayout(false);
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llblBudgetsetup;
        private System.Windows.Forms.LinkLabel llblMainMenu;
        private System.Windows.Forms.Label lblDetailedExpenses;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBudgetedAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerSpent;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label txtCategoryPercentage;
        private System.Windows.Forms.TabControl tbCntrl1;
        private System.Windows.Forms.TabPage tbPg1;
        private System.Windows.Forms.Panel pnlBox;
    }
}