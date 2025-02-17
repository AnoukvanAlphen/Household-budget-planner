
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Goals_PRG281_project
{
    interface INavigator
    {
        void GotoMainMenu();
        void GotoCurrentGoals();

        void GotoGoalSettings();


    }
    public partial class frmMainMenu : Form
    {

        Navigation navigation = new Navigation();

        public frmMainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void btnSetGoals_Click(object sender, EventArgs e)
        {
            frmGoal_setting frmGoal_Setting = new frmGoal_setting();
            frmGoal_Setting.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlExit.BorderStyle = BorderStyle.FixedSingle;
            pnlExit.Visible = true;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlExit.Visible = false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateNewBudget_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GoToBudget();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
            }
        }

        private void btnViewExistingBudget_Click(object sender, EventArgs e)
        {
            this.Hide();
            navigation.GotoExistingBudget();

        }

        private void btnOptimizeMeal_Click(object sender, EventArgs e)
        {
            this.Hide();
            navigation.GotonOptimizeMeal(); // Open the new form here
            
            // Then close the current form
        }

        private void btnTrackExpenses_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GoToTrackExpenses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
            }

        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
         
                // Prevent the form from closing
                e.Cancel = true;

                // Display the exit panel
                pnlExit.BorderStyle = BorderStyle.FixedSingle;
                pnlExit.Visible = true;
            
        }
    }
}