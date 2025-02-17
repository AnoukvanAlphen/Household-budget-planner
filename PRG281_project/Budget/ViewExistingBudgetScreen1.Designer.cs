namespace Goals_PRG281_project
{
    partial class frmExistingBudgetScreen1
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
            this.lbltotMInc = new System.Windows.Forms.Label();
            this.lblTotIncAmount = new System.Windows.Forms.Label();
            this.lblExistingBudget = new System.Windows.Forms.Label();
            this.llblMainMenu = new System.Windows.Forms.LinkLabel();
            this.llblBudgetsetup = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.dgvExistingBudget = new System.Windows.Forms.DataGridView();
            this.btnDetailedExpenses = new System.Windows.Forms.Button();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingBudget)).BeginInit();
            this.pnlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotMInc
            // 
            this.lbltotMInc.AutoSize = true;
            this.lbltotMInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotMInc.Location = new System.Drawing.Point(29, 24);
            this.lbltotMInc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotMInc.Name = "lbltotMInc";
            this.lbltotMInc.Size = new System.Drawing.Size(203, 20);
            this.lbltotMInc.TabIndex = 1;
            this.lbltotMInc.Text = "Total montly income: R";
            // 
            // lblTotIncAmount
            // 
            this.lblTotIncAmount.AutoSize = true;
            this.lblTotIncAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotIncAmount.Location = new System.Drawing.Point(231, 9);
            this.lblTotIncAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotIncAmount.Name = "lblTotIncAmount";
            this.lblTotIncAmount.Size = new System.Drawing.Size(69, 20);
            this.lblTotIncAmount.TabIndex = 2;
            this.lblTotIncAmount.Text = "______";
            this.lblTotIncAmount.Click += new System.EventHandler(this.lblTotIncAmount_Click);
            // 
            // lblExistingBudget
            // 
            this.lblExistingBudget.AutoSize = true;
            this.lblExistingBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingBudget.Location = new System.Drawing.Point(255, 21);
            this.lblExistingBudget.Name = "lblExistingBudget";
            this.lblExistingBudget.Size = new System.Drawing.Size(105, 18);
            this.lblExistingBudget.TabIndex = 5;
            this.lblExistingBudget.Text = "existing budget";
            this.lblExistingBudget.Click += new System.EventHandler(this.label1_Click);
            // 
            // llblMainMenu
            // 
            this.llblMainMenu.AutoSize = true;
            this.llblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMainMenu.Location = new System.Drawing.Point(17, 21);
            this.llblMainMenu.Name = "llblMainMenu";
            this.llblMainMenu.Size = new System.Drawing.Size(94, 18);
            this.llblMainMenu.TabIndex = 6;
            this.llblMainMenu.TabStop = true;
            this.llblMainMenu.Text = "Main menu >";
            this.llblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMainMenu_LinkClicked);
            // 
            // llblBudgetsetup
            // 
            this.llblBudgetsetup.AutoSize = true;
            this.llblBudgetsetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblBudgetsetup.Location = new System.Drawing.Point(131, 21);
            this.llblBudgetsetup.Name = "llblBudgetsetup";
            this.llblBudgetsetup.Size = new System.Drawing.Size(107, 18);
            this.llblBudgetsetup.TabIndex = 7;
            this.llblBudgetsetup.TabStop = true;
            this.llblBudgetsetup.Text = "Budget setup >";
            this.llblBudgetsetup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBudgetsetup_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotIncAmount);
            this.panel1.Location = new System.Drawing.Point(26, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 40);
            this.panel1.TabIndex = 41;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Location = new System.Drawing.Point(23, 61);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(982, 416);
            this.pnlBackground.TabIndex = 40;
            // 
            // dgvExistingBudget
            // 
            this.dgvExistingBudget.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvExistingBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingBudget.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvExistingBudget.Location = new System.Drawing.Point(33, 109);
            this.dgvExistingBudget.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExistingBudget.Name = "dgvExistingBudget";
            this.dgvExistingBudget.RowHeadersWidth = 51;
            this.dgvExistingBudget.Size = new System.Drawing.Size(958, 297);
            this.dgvExistingBudget.TabIndex = 0;
            this.dgvExistingBudget.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExistingBudget_CellContentClick);
            // 
            // btnDetailedExpenses
            // 
            this.btnDetailedExpenses.Location = new System.Drawing.Point(33, 437);
            this.btnDetailedExpenses.Name = "btnDetailedExpenses";
            this.btnDetailedExpenses.Size = new System.Drawing.Size(958, 30);
            this.btnDetailedExpenses.TabIndex = 4;
            this.btnDetailedExpenses.Text = "Detailed expenses";
            this.btnDetailedExpenses.UseVisualStyleBackColor = true;
            this.btnDetailedExpenses.Click += new System.EventHandler(this.btnDetailedExpenses_Click);
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(29, 71);
            this.lblExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(87, 20);
            this.lblExpenses.TabIndex = 3;
            this.lblExpenses.Text = "Expenses:";
            // 
            // pnlBox
            // 
            this.pnlBox.Controls.Add(this.dgvExistingBudget);
            this.pnlBox.Controls.Add(this.lblExpenses);
            this.pnlBox.Controls.Add(this.lbltotMInc);
            this.pnlBox.Controls.Add(this.btnDetailedExpenses);
            this.pnlBox.Controls.Add(this.pnlBackground);
            this.pnlBox.Controls.Add(this.panel1);
            this.pnlBox.Controls.Add(this.picBackground);
            this.pnlBox.Location = new System.Drawing.Point(12, 50);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(1043, 492);
            this.pnlBox.TabIndex = 10;
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(-12, -53);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1055, 545);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 33;
            this.picBackground.TabStop = false;
            // 
            // frmExistingBudgetScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1064, 554);
            this.Controls.Add(this.llblBudgetsetup);
            this.Controls.Add(this.llblMainMenu);
            this.Controls.Add(this.lblExistingBudget);
            this.Controls.Add(this.pnlBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExistingBudgetScreen1";
            this.Text = "Existing Budget";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExistingBudgetScreen1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExistingBudgetScreen1_FormClosed);
            this.Load += new System.EventHandler(this.ViewExistingBudgetScreen1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingBudget)).EndInit();
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltotMInc;
        private System.Windows.Forms.Label lblTotIncAmount;
        private System.Windows.Forms.Label lblExistingBudget;
        private System.Windows.Forms.LinkLabel llblMainMenu;
        private System.Windows.Forms.LinkLabel llblBudgetsetup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dgvExistingBudget;
        private System.Windows.Forms.Button btnDetailedExpenses;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.PictureBox picBackground;
    }
}