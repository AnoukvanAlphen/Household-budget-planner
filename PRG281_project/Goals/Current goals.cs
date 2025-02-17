using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Goals_PRG281_project
{
    public partial class frmCurrent_goals : Form
    {
        private GoalManager _goalManager;
        public  List<Goal> GoalList = new List<Goal>();
        Navigation navigation = new Navigation();
        public frmCurrent_goals(GoalManager goalManager)
        {
            InitializeComponent();
            _goalManager = goalManager; // Assign the passed GoalManager to the form's field
            LoadGoals();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void LoadGoals()
        {
            // Access the static GoalList directly via the GoalManager class name
            foreach (Goal item in GoalManager.GoalList)
            {
                AddGoal(item);
            }

        }

        public void AddGoal(Goal goal)
        {
            Panel goalPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(300, 150)
            };

            Label lblGoalName = new Label
            {
                Text = "Goal: " + goal.Name,
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblTargetAmount = new Label
            {
                Text = "Target: " + goal.TargetAmount.ToString("C2"),
                Location = new Point(10, 40),
                AutoSize = true
            };

            Label lblProgress = new Label
            {
                Text = "Progress: " + goal.CurrentProgress.ToString("C2"),
                Location = new Point(10, 70),
                AutoSize = true
            };

            Label lblDeadline = new Label
            {
                Text = "Deadline: " + goal.Deadline.ToShortDateString(),
                Location = new Point(10, 100),
                AutoSize = true
            };

            goalPanel.Controls.Add(lblGoalName);
            goalPanel.Controls.Add(lblTargetAmount);
            goalPanel.Controls.Add(lblProgress);
            goalPanel.Controls.Add(lblDeadline);

            Button btnEdit = new Button
            {
                Text = "Edit",
                Location = new Point(200, 10)
            };
            btnEdit.Click += (sender, e) => { EditGoal(goal); };

            Button btnDelete = new Button
            {
                Text = "Delete",
                Location = new Point(200, 50)
            };
            btnDelete.Click += (sender, e) => { DeleteGoal(goal, goalPanel); };

            goalPanel.Controls.Add(btnEdit);
            goalPanel.Controls.Add(btnDelete);

            flowLayoutPanel1.Controls.Add(goalPanel);
            GoalList.Add(goal);
        }

        private void EditGoal(Goal goal)
        {
            using (Form editForm = new Form())
            {
                editForm.Text = "Edit Goal";
                editForm.Size = new Size(300, 250);
                editForm.StartPosition = FormStartPosition.CenterScreen;

                Label lblName = new Label
                {
                    Text = "Goal Name:",
                    Location = new Point(10, 20),
                    AutoSize = true
                };
                TextBox txtName = new TextBox
                {
                    Text = goal.Name,
                    Location = new Point(100, 20),
                    Width = 150
                };

                Label lblTarget = new Label
                {
                    Text = "Target Amount:",
                    Location = new Point(10, 60),
                    AutoSize = true
                };
                TextBox txtTarget = new TextBox
                {
                    Text = goal.TargetAmount.ToString(),
                    Location = new Point(100, 60),
                    Width = 150
                };

                Label lblDeadline = new Label
                {
                    Text = "Deadline:",
                    Location = new Point(10, 100),
                    AutoSize = true
                };
                DateTimePicker dtDeadline = new DateTimePicker
                {
                    Value = goal.Deadline,
                    Location = new Point(100, 100),
                    Width = 150
                };

                Button btnSave = new Button
                {
                    Text = "Save",
                    Location = new Point(100, 150)
                };

                btnSave.Click += (sender, e) =>
                {
                    // Input Validation with error handling
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        MessageBox.Show("Goal name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(txtTarget.Text, out decimal targetAmount) || targetAmount <= 0)
                    {
                        MessageBox.Show("Please enter a valid positive number for the target amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dtDeadline.Value < DateTime.Now)
                    {
                        MessageBox.Show("The deadline must be a future date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update goal
                    goal.Name = txtName.Text;
                    goal.TargetAmount = targetAmount;
                    goal.Deadline = dtDeadline.Value;

                    MessageBox.Show("Goal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the form after successful update
                    editForm.Close();

                    // Reload the goals to reflect the changes
                    ReloadGoals();
                };

                editForm.Controls.Add(lblName);
                editForm.Controls.Add(txtName);
                editForm.Controls.Add(lblTarget);
                editForm.Controls.Add(txtTarget);
                editForm.Controls.Add(lblDeadline);
                editForm.Controls.Add(dtDeadline);
                editForm.Controls.Add(btnSave);

                editForm.ShowDialog();
            }
        }
        private void ReloadGoals()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Goal goal in GoalManager.GoalList)
            {
                AddGoal(goal);
            }
        }
        private void DeleteGoal(Goal goal, Panel goalPanel)
        {
            // Accessing the static GoalList correctly using the class name
            GoalManager.GoalList.Remove(goal);
            flowLayoutPanel1.Controls.Remove(goalPanel);
            MessageBox.Show("Deleted " + goal.Name);

        }

        private void btnGoalSetting_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();
            navigation.GotoGoalSettings();
            this.Hide();
            this.Close();
        }

        private void llblGoalSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigation navigation = new Navigation();
            navigation.GotoGoalSettings();
            this.Hide();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void frmCurrent_goals_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void llblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblNoGoalsyet_Click(object sender, EventArgs e)
        {

        }

        private void picBackground_Click(object sender, EventArgs e)
        {

        }

        private void frmCurrent_goals_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
