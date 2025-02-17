using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Goals_PRG281_project
{
    public partial class frmBudgetSetup : Form
    {
        public static List<BudgetDetails> BudgetDetails { get; private set; } = new List<BudgetDetails>();
        Navigation navigation = new Navigation();
        public static double monthlyIncome { get; private set; }

        public frmBudgetSetup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmBudgetSetup_Load(object sender, EventArgs e)
        {
            
        }

        private void AddExpenses()
        {
            // Validate and parse monthly income
            double parsedIncome;
            if (!double.TryParse(txtIncome.Text.Replace("R", "").Trim(), out parsedIncome) || parsedIncome <= 0)
            {
                MessageBox.Show("Please enter a valid monthly income (eg. greater than zero)", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If parsing is successful, assign the parsed value to the static property
            monthlyIncome = parsedIncome;

            // Check each category and create BudgetDetails objects
            if (chkRent.Checked && double.TryParse(txtRentBudget.Text.Trim(), out double rentBudget) && rentBudget > 0)
            {
                AddExpense("Rent", (decimal)rentBudget);
            }
            else if (chkRent.Checked)
            {
                MessageBox.Show("Please enter a valid rent budget amount (eg. greater than zero)", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkGroceries.Checked && double.TryParse(txtGroceriesBudget.Text.Trim(), out double groceriesBudget) && groceriesBudget > 0)
            {
                AddExpense("Groceries", (decimal)groceriesBudget);
            }
            else if (chkGroceries.Checked)
            {
                MessageBox.Show("Please enter a valid groceries budget amount (eg. greater than zero)", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkEntertainment.Checked && double.TryParse(txtEntertainmentBudget.Text.Trim(), out double entertainmentBudget) && entertainmentBudget > 0)
            {
                AddExpense("Entertainment", (decimal)entertainmentBudget);
            }
            else if (chkEntertainment.Checked)
            {
                MessageBox.Show("Please enter a valid entertainment budget amount (eg. greater than zero)", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkMedical.Checked && double.TryParse(txtMedicalBudget.Text.Trim(), out double medicalBudget) && medicalBudget > 0)
            {
                AddExpense("Medical", (decimal)medicalBudget);
            }
            else if (chkMedical.Checked)
            {
                MessageBox.Show("Please enter a valid medical budget budget amount (eg. greater than zero)", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkOther.Checked && double.TryParse(txtOtherBudget.Text.Trim(), out double otherBudget) && otherBudget > 0)
            {
                AddExpense("Other", (decimal)otherBudget);
            }
            else if (chkOther.Checked)
            {
                MessageBox.Show("Please enter a valid other expenses budget amount (eg. greater than zero)", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Budget setup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddExpense(string category, decimal budgetedAmount)
        {
            // Check if the category already exists
            var existingExpense = BudgetDetails.FirstOrDefault(b => b.Category == category);

            if (existingExpense != null)
            {
                // Update the existing entry
                existingExpense.BudgetedAmount = budgetedAmount;
                existingExpense.RemainingAmount = budgetedAmount; // Update the remaining amount as well
            }
            else
            {
                // Add a new entry
                BudgetDetails expense = new BudgetDetails(category, budgetedAmount);
                BudgetDetails.Add(expense);
            }
        }


        private void txtIncome_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtIncome_Validated(object sender, EventArgs e)
        {
            string input = txtIncome.Text.Trim();

            if (input.StartsWith("R"))
            {
                string temp = input.Replace("R", "").Trim();
                string specifier = "C";
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-ZA");
                txtIncome.Text = decimal.Parse(temp).ToString(specifier, culture);
            }
        }

        private void btnBudgetView_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GotoExistingBudget();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
            }
        }

        private void lblkMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // Allow income textbox to only be in currency format
            string value = txtIncome.Text;
            NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-ZA");
            decimal currency;

            if (!decimal.TryParse(value, style, culture, out currency))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtIncome.Clear();
                return; //Exit the method if the input is invalid
            }
            
            AddExpenses();
        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmBudgetSetup_FormClosed(object sender, FormClosedEventArgs e)
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

