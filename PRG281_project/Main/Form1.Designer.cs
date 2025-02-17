namespace Goals_PRG281_project
{
    partial class frmLoadingScreen
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
            this.pnpBackGroundLoad = new System.Windows.Forms.Panel();
            this.pnlProgresssBarForground = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBxLoading = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pnpBackGroundLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pnpBackGroundLoad
            // 
            this.pnpBackGroundLoad.Controls.Add(this.pnlProgresssBarForground);
            this.pnpBackGroundLoad.Location = new System.Drawing.Point(0, 553);
            this.pnpBackGroundLoad.Margin = new System.Windows.Forms.Padding(4);
            this.pnpBackGroundLoad.Name = "pnpBackGroundLoad";
            this.pnpBackGroundLoad.Size = new System.Drawing.Size(1017, 25);
            this.pnpBackGroundLoad.TabIndex = 1;
            // 
            // pnlProgresssBarForground
            // 
            this.pnlProgresssBarForground.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlProgresssBarForground.Location = new System.Drawing.Point(0, 0);
            this.pnlProgresssBarForground.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProgresssBarForground.Name = "pnlProgresssBarForground";
            this.pnlProgresssBarForground.Size = new System.Drawing.Size(28, 26);
            this.pnlProgresssBarForground.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBxLoading
            // 
            this.picBxLoading.Image = global::Goals_PRG281_project.Properties.Resources.a_simple_splash_screen_1___Copy;
            this.picBxLoading.InitialImage = global::Goals_PRG281_project.Properties.Resources.a_simple_splash_screen_1___Copy;
            this.picBxLoading.Location = new System.Drawing.Point(0, 0);
            this.picBxLoading.Margin = new System.Windows.Forms.Padding(4);
            this.picBxLoading.Name = "picBxLoading";
            this.picBxLoading.Size = new System.Drawing.Size(1017, 578);
            this.picBxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxLoading.TabIndex = 0;
            this.picBxLoading.TabStop = false;
            this.picBxLoading.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(430, 242);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(166, 39);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading...";
            // 
            // frmLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1016, 578);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pnpBackGroundLoad);
            this.Controls.Add(this.picBxLoading);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Screen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.pnpBackGroundLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxLoading;
        private System.Windows.Forms.Panel pnpBackGroundLoad;
        private System.Windows.Forms.Panel pnlProgresssBarForground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLoading;
    }
}

