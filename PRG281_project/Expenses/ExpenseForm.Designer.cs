namespace Goals_PRG281_project
{
    partial class frmExpenseForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvExpenseDetails = new System.Windows.Forms.ListView();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.llblExistingBudget = new System.Windows.Forms.LinkLabel();
            this.llblMainMenu = new System.Windows.Forms.LinkLabel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(287, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 28);
            this.txtSearch.TabIndex = 0;
            // 
            // lvExpenseDetails
            // 
            this.lvExpenseDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvExpenseDetails.HideSelection = false;
            this.lvExpenseDetails.Location = new System.Drawing.Point(33, 71);
            this.lvExpenseDetails.Name = "lvExpenseDetails";
            this.lvExpenseDetails.Size = new System.Drawing.Size(691, 240);
            this.lvExpenseDetails.TabIndex = 1;
            this.lvExpenseDetails.UseCompatibleStateImageBehavior = false;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(584, 21);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(140, 28);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "Search";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Goal setting";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // llblExistingBudget
            // 
            this.llblExistingBudget.AutoSize = true;
            this.llblExistingBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblExistingBudget.Location = new System.Drawing.Point(123, 9);
            this.llblExistingBudget.Name = "llblExistingBudget";
            this.llblExistingBudget.Size = new System.Drawing.Size(126, 18);
            this.llblExistingBudget.TabIndex = 12;
            this.llblExistingBudget.TabStop = true;
            this.llblExistingBudget.Text = "Track expenses >";
            this.llblExistingBudget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblExistingBudget_LinkClicked);
            // 
            // llblMainMenu
            // 
            this.llblMainMenu.AutoSize = true;
            this.llblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMainMenu.Location = new System.Drawing.Point(12, 9);
            this.llblMainMenu.Name = "llblMainMenu";
            this.llblMainMenu.Size = new System.Drawing.Size(94, 18);
            this.llblMainMenu.TabIndex = 13;
            this.llblMainMenu.TabStop = true;
            this.llblMainMenu.Text = "Main menu >";
            this.llblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMainMenu_LinkClicked);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(29, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(252, 22);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search by Category or Notes :";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // pnlBox
            // 
            this.pnlBox.Controls.Add(this.btnDelete);
            this.pnlBox.Controls.Add(this.lblSearch);
            this.pnlBox.Controls.Add(this.txtSearch);
            this.pnlBox.Controls.Add(this.lvExpenseDetails);
            this.pnlBox.Controls.Add(this.btnViewDetails);
            this.pnlBox.Location = new System.Drawing.Point(12, 68);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(760, 370);
            this.pnlBox.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(33, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(691, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(-1, 30);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(801, 426);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 33;
            this.picBackground.TabStop = false;
            // 
            // frmExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llblMainMenu);
            this.Controls.Add(this.llblExistingBudget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.picBackground);
            this.Name = "frmExpenseForm";
            this.Text = "Search Expenses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExpenseForm_FormClosed);
            this.Load += new System.EventHandler(this.frmExpenseForm_Load);
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvExpenseDetails;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblExistingBudget;
        private System.Windows.Forms.LinkLabel llblMainMenu;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Button btnDelete;
    }
}