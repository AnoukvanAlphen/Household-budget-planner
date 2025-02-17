using System;
using System.Windows.Forms;

namespace Goals_PRG281_project
{
    public partial class frmGoal_setting : Form
    {
        private GoalManager _goalManager;
        Navigation navigation = new Navigation();
        public frmGoal_setting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _goalManager = new GoalManager(); // Initialize it here
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
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

        private void btnViewGoals_Click(object sender, EventArgs e)
        {
            // Check if there are no goals in the list
            if (GoalManager.GoalList.Count == 0)
            {
                MessageBox.Show("No goals have been added yet.", "No Goals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method without navigating
            }
            try
            {
                this.Hide();
                navigation.GotoCurrentGoals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the current goals: " + ex.Message);
            }
        }

        private void llblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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

        private void btnSaveGoal_Click(object sender, EventArgs e)
        {
            try
            {
                string goalName = txtGoalName.Text;

                if (string.IsNullOrWhiteSpace(goalName))
                {
                    throw new ArgumentException("Goal name cannot be empty.");
                }

                if (!decimal.TryParse(txtTargetAmount.Text, out decimal targetAmount))
                {
                    throw new FormatException("Invalid target amount. Please enter a valid decimal number.");
                }

                int currentProgress = 0;
                DateTime deadline = dtDeadline.Value;

                if (deadline <= DateTime.Now)
                {
                    throw new ArgumentException("Deadline must be in the future.");
                }

                Goal newGoal = new Goal(goalName, targetAmount, currentProgress, deadline);
                GoalManager.GoalList.Add(newGoal);
                ClearForm();
                MessageBox.Show("Goal saved successfully!");
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Input error: " + argEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Formatting error: " + formatEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ClearForm()
        {
            txtGoalName.Text = "";
            txtTargetAmount.Text = "";
            dtDeadline.Value = DateTime.Now;
        }

      

        private void frmGoal_setting_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Any initialization code can go here
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during form load: " + ex.Message);
            }
        }

        private void lblGoalName_Click(object sender, EventArgs e)
        {

        }

        private void Deadline_Click(object sender, EventArgs e)
        {

        }

        private void frmGoal_setting_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        private void llblGotoBudget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            navigation.GoToBudget();
            this.Hide();
            this.Close();
        }
    }
}
