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
    public partial class frmViewDetailedExpenses : Form
    {
        Navigation navigation = new Navigation();

        private static List<Expense> expenseHistory = frmExpenseTracker.expenseHistory;
        private static List<BudgetDetails> budgetDetails = frmBudgetSetup.BudgetDetails;
        public frmViewDetailedExpenses()
        {
            //InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
            //LoadExpenses();
            //InitializeTabs();
            InitializeComponent();
            InitializeTabs();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tbEntert_Click(object sender, EventArgs e)
        {

        }

        private void LoadExpenses()
        {
            
        }

        private void InitializeTabs()
        {
            

            //Dictionary to hold percentages and amounts for each category
            var categoryPercentages = new Dictionary<string, decimal>();
            var categoryBudgetedAmounts = new Dictionary<string, decimal>();
            var categoryRemainingAmounts = new Dictionary<string, decimal>();

            //Iterate through each budget category
            foreach (var budget in budgetDetails)
            {
                var category = budget.Category;
                TabPage tabPage = new TabPage(category);
                DataGridView dataGridView = new DataGridView { Dock = DockStyle.Fill };

                //Get expenses related to the current category
                var categoryExpenses = expenseHistory.Where(e => e.Category == category).ToList();
                decimal totalBudget = budget.BudgetedAmount;  //Get the budgeted amount from the budgetDetails list
                decimal totalSpent = categoryExpenses.Sum(e => e.Amount);
                decimal percentage = totalSpent / totalBudget * 100;
                decimal remainingAmount = totalBudget - totalSpent;

                //Store percentage and amounts in the dictionaries
                categoryPercentages[category] = percentage;
                categoryBudgetedAmounts[category] = totalBudget;
                categoryRemainingAmounts[category] = remainingAmount;

                //Set up the DataGridView
                dataGridView.DataSource = categoryExpenses.Select(e => new
                {
                    Date = e.Date,
                    Description = e.Notes,
                    ActualAmount = e.Amount
                }).ToList();

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (percentage > 100)
                {
                    dataGridView.DefaultCellStyle.ForeColor = Color.Red;
                }

                tabPage.Controls.Add(dataGridView);
                tbCntrl1.TabPages.Add(tabPage);
            }

            //Display the percentage for the first category (assuming "Entertainment" exists)
            if (categoryPercentages.ContainsKey("Entertainment"))
            {
                txtCategoryPercentage.Text = $"{categoryPercentages["Entertainment"]:0.00}%";
                lblBudgetedAmount.Text = $"{categoryBudgetedAmounts["Entertainment"]:C}";
                lblRemainingAmount.Text = $"{categoryRemainingAmounts["Entertainment"]:C}";
            }

            //Removing the placeholder tab.
            tbCntrl1.TabPages.Remove(tbPg1);

            //Make sure it displays the first time
            if (tbCntrl1.TabPages.Count > 0)
            {
                string selectedCategory = tbCntrl1.SelectedTab.Text;
                decimal selectedPercentage = categoryPercentages[selectedCategory];
                decimal budgetedAmount = categoryBudgetedAmounts[selectedCategory];
                decimal remainingAmount = categoryRemainingAmounts[selectedCategory];

                txtCategoryPercentage.Text = $"{selectedPercentage:0.00}%";
                lblBudgetedAmount.Text = $"{budgetedAmount:C}";
                lblRemainingAmount.Text = $"{remainingAmount:C}";
            }

            //Handle the SelectedIndexChanged event to update the TextBoxes
            tbCntrl1.SelectedIndexChanged += (sender, e) =>
            {
                if (tbCntrl1.SelectedTab != null)
                {
                    string selectedCategory = tbCntrl1.SelectedTab.Text;

                    if (categoryPercentages.ContainsKey(selectedCategory))
                    {
                        decimal selectedPercentage = categoryPercentages[selectedCategory];
                        decimal budgetedAmount = categoryBudgetedAmounts[selectedCategory];
                        decimal remainingAmount = categoryRemainingAmounts[selectedCategory];

                        txtCategoryPercentage.Text = $"{selectedPercentage:0.00}%";
                        lblBudgetedAmount.Text = $"{budgetedAmount:C}";
                        lblRemainingAmount.Text = $"{remainingAmount:C}";
                    }
                    else
                    {
                        txtCategoryPercentage.Text = "N/A";
                        lblBudgetedAmount.Text = "N/A";
                        lblRemainingAmount.Text = "N/A";
                    }
                }
            };
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmViewDetailedExpenses_Load(object sender, EventArgs e)
        {

        }

        private void txtCategoryPercentage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPerSpent_Click(object sender, EventArgs e)
        {

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

        }

        private void llblExistingBudget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void llblExistingBudget_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmViewDetailedExpenses_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void txtCategoryPercentage_Click_1(object sender, EventArgs e)
        {

        }

        private void tbPg1_Click(object sender, EventArgs e)
        {

        }

        private void picBackground_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmViewDetailedExpenses_FormClosed(object sender, FormClosedEventArgs e)
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

        private void llblBudgetsetup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GoToBudget();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to budget " + ex.Message);
            }
        }
    }


}