using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goals_PRG281_project
{
    public partial class frmLoadingScreen : Form
    {
        Navigation navigation = new Navigation();
        public frmLoadingScreen()
        {
            InitializeComponent();
  
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progrBarSS_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlProgresssBarForground.Width += 2;
            Thread.Sleep(2);
            pnlProgresssBarForground.Width += 2;

            timer1.Start();

            if(pnlProgresssBarForground.Width >= 763)
            {
                timer1.Stop();
                //form swith here
                try
                {
                    this.Hide();
                    navigation.GotoMainMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
                }
            }


        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }


}
