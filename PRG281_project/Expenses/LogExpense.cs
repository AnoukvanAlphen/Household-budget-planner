using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
namespace Goals_PRG281_project
{
    public partial class frmExpenseTracker : Form
    {
        public static List<Expense> expenseHistory { get; private set; } = new List<Expense>(); 
        private static List<BudgetDetails> budgetDetails = frmBudgetSetup.BudgetDetails;
        Navigation navigation = new Navigation();

        public frmExpenseTracker()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Method to clear form fields after logging an expense
        private void ClearForm()
        {
            cbExpenseCategory.SelectedIndex = -1;
            txtExpenseAmount.Text = "";
            txtNotes.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        private void btnViewHistory_Click_1(object sender, EventArgs e)
        {
            if (expenseHistory.Count == 0)
            {
                MessageBox.Show("No expenses logged yet.");
                return;
            }
            this.Hide();
            frmExpenseForm mainForm = new frmExpenseForm(expenseHistory);
            mainForm.ShowDialog();
        }

        private void btnLogExpense_Click_1(object sender, EventArgs e)
        {
            // Validate category selection
            if (cbExpenseCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select an expense category.");
                return;
            }

            // Validate expense amount
            if (string.IsNullOrWhiteSpace(txtExpenseAmount.Text) || !decimal.TryParse(txtExpenseAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid expense amount (greater than 0).");
                return;
            }

            // Validate date (ensure it's not a future date)
            DateTime date = dtpDate.Value;
            if (date > DateTime.Now)
            {
                MessageBox.Show("Please select a valid date (today or earlier).");
                return;
            }

            // Get values from the form
            string category = cbExpenseCategory.SelectedItem.ToString();
            string notes = txtNotes.Text;

            

            // Subtract the amount from the remaining budget
            var budget = budgetDetails.FirstOrDefault(b => b.Category == category);
            if (budget != null)
            {
                budget.RemainingAmount -= amount;
            }
            else
            {
                MessageBox.Show("Category not found in budget details.");
                return;
            }
            // Log the expense
            Expense newExpense = new Expense
            {
                Category = category,
                Amount = amount,
                Date = date,
                Notes = notes
            };
            expenseHistory.Add(newExpense);
            // Show a confirmation message
            MessageBox.Show("Expense logged and budget updated successfully!");

            // Clear the form fields
            ClearForm();
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

        private void frmExpenseTracker_Load(object sender, EventArgs e)
        {

        }

        private void llblMainMenu_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void pnlBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWxspenseamount_Click(object sender, EventArgs e)
        {

        }

        private void frmExpenseTracker_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void frmExpenseTracker_FormClosed(object sender, FormClosedEventArgs e)
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
