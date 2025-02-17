using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goals_PRG281_project
{
 
    public partial class frmExistingBudgetScreen1 : Form
    {
        Navigation navigation = new Navigation();
        private static List<Expense> expenseHistory = frmExpenseTracker.expenseHistory;
        private static List<BudgetDetails> budgetDetails = frmBudgetSetup.BudgetDetails;


        public frmExistingBudgetScreen1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void lblTotIncAmount_Click(object sender, EventArgs e)
        {

        }

        private void ViewExistingBudgetScreen1_Load(object sender, EventArgs e)
        {
            // Check if there are any budget details to display
            if (budgetDetails == null || !budgetDetails.Any())
            {
                MessageBox.Show("No budget details found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                navigation.GotoMainMenu();
                return; // Exit the method
            }
            //gets the total income from Budget setup form
            lblTotIncAmount.Text = frmBudgetSetup.monthlyIncome.ToString();

            //Create a list to store the data to be displayed in the DataGridView
            var displayData = new List<dynamic>();

            foreach (var budget in budgetDetails)
            {
                //Calculate the total actual amount spent for this category
                decimal actualAmount = expenseHistory.Where(expense => expense.Category == budget.Category).Sum(expense => expense.Amount);

                //Calculate the remaining budget
                decimal remainingAmount = budget.BudgetedAmount - actualAmount;

                //Add the data to the list
                displayData.Add(new
                {
                    Category = budget.Category,
                    BudgetedAmount = budget.BudgetedAmount,
                    ActualAmount = actualAmount,
                    RemainingAmount = remainingAmount
                });
            }

            //Bind the data to the DataGridView
            dgvExistingBudget.DataSource = displayData;

            //Auto-size the columns
            dgvExistingBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailedExpenses_Click(object sender, EventArgs e)
        {
            // Check if there is data in budgetDetails and expenseHistory
            if (budgetDetails == null || !budgetDetails.Any())
            {
                MessageBox.Show("No budget details found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (expenseHistory == null || !expenseHistory.Any())
            {
                MessageBox.Show("No expense history found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                this.Hide();
                navigation.GoToDetailedExpenses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
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

        private void llblBudgetsetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void dgvExistingBudget_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picBackground_Click(object sender, EventArgs e)
        {

        }

        private void frmExistingBudgetScreen1_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmExistingBudgetScreen1_FormClosing(object sender, FormClosingEventArgs e)
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
