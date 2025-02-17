namespace Goals_PRG281_project
{
    partial class frmExpenseTracker
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
            this.cbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnLogExpense = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblDateOfExspense = new System.Windows.Forms.Label();
            this.lblWxspenseamount = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lnlExspenseCategorie = new System.Windows.Forms.Label();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.llblMainMenu = new System.Windows.Forms.LinkLabel();
            this.lblExp = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // cbExpenseCategory
            // 
            this.cbExpenseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExpenseCategory.FormattingEnabled = true;
            this.cbExpenseCategory.Items.AddRange(new object[] {
            "Entertainment",
            "Groceries",
            "Rent",
            "Medical"});
            this.cbExpenseCategory.Location = new System.Drawing.Point(19, 45);
            this.cbExpenseCategory.Name = "cbExpenseCategory";
            this.cbExpenseCategory.Size = new System.Drawing.Size(347, 28);
            this.cbExpenseCategory.TabIndex = 0;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenseAmount.Location = new System.Drawing.Point(19, 124);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(347, 27);
            this.txtExpenseAmount.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(19, 207);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(347, 27);
            this.dtpDate.TabIndex = 2;
            // 
            // btnLogExpense
            // 
            this.btnLogExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogExpense.Location = new System.Drawing.Point(31, 425);
            this.btnLogExpense.Name = "btnLogExpense";
            this.btnLogExpense.Size = new System.Drawing.Size(141, 34);
            this.btnLogExpense.TabIndex = 4;
            this.btnLogExpense.Text = " Log expense";
            this.btnLogExpense.UseVisualStyleBackColor = true;
            this.btnLogExpense.Click += new System.EventHandler(this.btnLogExpense_Click_1);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Location = new System.Drawing.Point(189, 380);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(177, 34);
            this.btnViewHistory.TabIndex = 5;
            this.btnViewHistory.Text = "View expense history";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click_1);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(19, 300);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(347, 59);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.Text = "";
            // 
            // lblDateOfExspense
            // 
            this.lblDateOfExspense.AutoSize = true;
            this.lblDateOfExspense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfExspense.Location = new System.Drawing.Point(15, 172);
            this.lblDateOfExspense.Name = "lblDateOfExspense";
            this.lblDateOfExspense.Size = new System.Drawing.Size(133, 20);
            this.lblDateOfExspense.TabIndex = 7;
            this.lblDateOfExspense.Text = "Date of Expense";
            // 
            // lblWxspenseamount
            // 
            this.lblWxspenseamount.AutoSize = true;
            this.lblWxspenseamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWxspenseamount.Location = new System.Drawing.Point(15, 92);
            this.lblWxspenseamount.Name = "lblWxspenseamount";
            this.lblWxspenseamount.Size = new System.Drawing.Size(133, 20);
            this.lblWxspenseamount.TabIndex = 9;
            this.lblWxspenseamount.Text = "Expense amount";
            this.lblWxspenseamount.Click += new System.EventHandler(this.lblWxspenseamount_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(15, 265);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(58, 20);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "Notes:";
            // 
            // lnlExspenseCategorie
            // 
            this.lnlExspenseCategorie.AutoSize = true;
            this.lnlExspenseCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlExspenseCategorie.Location = new System.Drawing.Point(15, 12);
            this.lnlExspenseCategorie.Name = "lnlExspenseCategorie";
            this.lnlExspenseCategorie.Size = new System.Drawing.Size(145, 20);
            this.lnlExspenseCategorie.TabIndex = 11;
            this.lnlExspenseCategorie.Text = "Expense Category";
            // 
            // pnlBox
            // 
            this.pnlBox.Controls.Add(this.lnlExspenseCategorie);
            this.pnlBox.Controls.Add(this.cbExpenseCategory);
            this.pnlBox.Controls.Add(this.btnViewHistory);
            this.pnlBox.Controls.Add(this.lblDateOfExspense);
            this.pnlBox.Controls.Add(this.lblNote);
            this.pnlBox.Controls.Add(this.txtExpenseAmount);
            this.pnlBox.Controls.Add(this.lblWxspenseamount);
            this.pnlBox.Controls.Add(this.dtpDate);
            this.pnlBox.Controls.Add(this.txtNotes);
            this.pnlBox.Location = new System.Drawing.Point(12, 45);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(652, 428);
            this.pnlBox.TabIndex = 12;
            this.pnlBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBox_Paint);
            // 
            // llblMainMenu
            // 
            this.llblMainMenu.AutoSize = true;
            this.llblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMainMenu.Location = new System.Drawing.Point(17, 9);
            this.llblMainMenu.Name = "llblMainMenu";
            this.llblMainMenu.Size = new System.Drawing.Size(94, 18);
            this.llblMainMenu.TabIndex = 13;
            this.llblMainMenu.TabStop = true;
            this.llblMainMenu.Text = "Main Menu >";
            this.llblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMainMenu_LinkClicked_1);
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.Location = new System.Drawing.Point(117, 9);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(108, 18);
            this.lblExp.TabIndex = 14;
            this.lblExp.Text = "enter expenses";
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(-46, 30);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(901, 467);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 33;
            this.picBackground.TabStop = false;
            // 
            // frmExpenseTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(808, 485);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.llblMainMenu);
            this.Controls.Add(this.btnLogExpense);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.picBackground);
            this.Name = "frmExpenseTracker";
            this.Text = "Log expenses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExpenseTracker_FormClosed);
            this.Load += new System.EventHandler(this.frmExpenseTracker_Load);
            this.ForeColorChanged += new System.EventHandler(this.frmExpenseTracker_ForeColorChanged);
            this.pnlBox.ResumeLayout(false);
            this.pnlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbExpenseCategory;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLogExpense;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblDateOfExspense;
        private System.Windows.Forms.Label lblWxspenseamount;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lnlExspenseCategorie;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.LinkLabel llblMainMenu;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.PictureBox picBackground;
    }
}

