namespace PROJECTPAIN
{
    partial class frmLinprog
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
            this.btnLp = new System.Windows.Forms.Button();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbohydrate = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.rtxtDisplay = new System.Windows.Forms.RichTextBox();
            this.txtCalorie = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.txtCarbohydrate = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.llblMainMenu = new System.Windows.Forms.LinkLabel();
            this.lblDetailedExpenses = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLp
            // 
            this.btnLp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLp.Location = new System.Drawing.Point(31, 240);
            this.btnLp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLp.Name = "btnLp";
            this.btnLp.Size = new System.Drawing.Size(267, 34);
            this.btnLp.TabIndex = 0;
            this.btnLp.Text = "Click to Calculate";
            this.btnLp.UseVisualStyleBackColor = true;
            this.btnLp.Click += new System.EventHandler(this.btnLp_Click);
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorie.Location = new System.Drawing.Point(27, 77);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(86, 22);
            this.lblCalorie.TabIndex = 1;
            this.lblCalorie.Text = "Calories :";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.Location = new System.Drawing.Point(27, 111);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(77, 22);
            this.lblProtein.TabIndex = 2;
            this.lblProtein.Text = "Protein :";
            // 
            // lblCarbohydrate
            // 
            this.lblCarbohydrate.AutoSize = true;
            this.lblCarbohydrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbohydrate.Location = new System.Drawing.Point(27, 151);
            this.lblCarbohydrate.Name = "lblCarbohydrate";
            this.lblCarbohydrate.Size = new System.Drawing.Size(129, 22);
            this.lblCarbohydrate.TabIndex = 3;
            this.lblCarbohydrate.Text = "Carbohydrate :";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.Location = new System.Drawing.Point(27, 187);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(46, 22);
            this.lblFat.TabIndex = 4;
            this.lblFat.Text = "Fat :";
            // 
            // rtxtDisplay
            // 
            this.rtxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDisplay.Location = new System.Drawing.Point(458, 75);
            this.rtxtDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtDisplay.Name = "rtxtDisplay";
            this.rtxtDisplay.Size = new System.Drawing.Size(375, 291);
            this.rtxtDisplay.TabIndex = 5;
            this.rtxtDisplay.Text = "";
            // 
            // txtCalorie
            // 
            this.txtCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorie.Location = new System.Drawing.Point(186, 65);
            this.txtCalorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalorie.Name = "txtCalorie";
            this.txtCalorie.Size = new System.Drawing.Size(112, 28);
            this.txtCalorie.TabIndex = 6;
            // 
            // txtProtein
            // 
            this.txtProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProtein.Location = new System.Drawing.Point(186, 105);
            this.txtProtein.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(112, 28);
            this.txtProtein.TabIndex = 7;
            // 
            // txtCarbohydrate
            // 
            this.txtCarbohydrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarbohydrate.Location = new System.Drawing.Point(186, 145);
            this.txtCarbohydrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarbohydrate.Name = "txtCarbohydrate";
            this.txtCarbohydrate.Size = new System.Drawing.Size(112, 28);
            this.txtCarbohydrate.TabIndex = 8;
            // 
            // txtFat
            // 
            this.txtFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFat.Location = new System.Drawing.Point(186, 181);
            this.txtFat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(112, 28);
            this.txtFat.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblInfo);
            this.pnlInput.Controls.Add(this.btnLp);
            this.pnlInput.Controls.Add(this.txtCalorie);
            this.pnlInput.Controls.Add(this.txtProtein);
            this.pnlInput.Controls.Add(this.txtCarbohydrate);
            this.pnlInput.Controls.Add(this.txtFat);
            this.pnlInput.Controls.Add(this.lblFat);
            this.pnlInput.Controls.Add(this.lblCarbohydrate);
            this.pnlInput.Controls.Add(this.lblCalorie);
            this.pnlInput.Controls.Add(this.lblProtein);
            this.pnlInput.Location = new System.Drawing.Point(16, 75);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(376, 293);
            this.pnlInput.TabIndex = 11;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(28, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(215, 22);
            this.lblInfo.TabIndex = 32;
            this.lblInfo.Text = "Enter minimium amounts :";
            // 
            // llblMainMenu
            // 
            this.llblMainMenu.AutoSize = true;
            this.llblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMainMenu.Location = new System.Drawing.Point(13, 9);
            this.llblMainMenu.Name = "llblMainMenu";
            this.llblMainMenu.Size = new System.Drawing.Size(94, 18);
            this.llblMainMenu.TabIndex = 14;
            this.llblMainMenu.TabStop = true;
            this.llblMainMenu.Text = "Main menu >";
            this.llblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMainMenu_LinkClicked);
            // 
            // lblDetailedExpenses
            // 
            this.lblDetailedExpenses.AutoSize = true;
            this.lblDetailedExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailedExpenses.Location = new System.Drawing.Point(113, 9);
            this.lblDetailedExpenses.Name = "lblDetailedExpenses";
            this.lblDetailedExpenses.Size = new System.Drawing.Size(95, 18);
            this.lblDetailedExpenses.TabIndex = 31;
            this.lblDetailedExpenses.Text = "Optimization ";
            this.lblDetailedExpenses.Click += new System.EventHandler(this.lblDetailedExpenses_Click);
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Goals_PRG281_project.Properties.Resources._1a__8__generated;
            this.picBackground.Location = new System.Drawing.Point(1, 31);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(901, 476);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackground.TabIndex = 32;
            this.picBackground.TabStop = false;
            this.picBackground.Click += new System.EventHandler(this.picBackground_Click);
            // 
            // frmLinprog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.rtxtDisplay);
            this.Controls.Add(this.lblDetailedExpenses);
            this.Controls.Add(this.llblMainMenu);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.picBackground);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLinprog";
            this.Text = "Linear program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLinprog_FormClosed);
            this.Load += new System.EventHandler(this.frmLp_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLp;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbohydrate;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.RichTextBox rtxtDisplay;
        private System.Windows.Forms.TextBox txtCalorie;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.TextBox txtCarbohydrate;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.LinkLabel llblMainMenu;
        private System.Windows.Forms.Label lblDetailedExpenses;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picBackground;
    }
}