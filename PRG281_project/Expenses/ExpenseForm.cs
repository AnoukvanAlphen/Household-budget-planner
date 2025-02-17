
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
    public partial class frmExpenseForm : Form
    {
        Navigation navigation = new Navigation();
        private List<Expense> expenses;
        public frmExpenseForm(List<Expense> expenseHistory)
        {
            InitializeComponent();
            SetupListView();
            expenses = expenseHistory;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Display all expenses when the form loads
            DisplayExpenses(expenses);
        }
        private void DisplayExpenses(List<Expense> expenseList)
        {
            //Clear the current ListView items
            lvExpenseDetails.Items.Clear();

            //Display each expense in the ListView
            foreach (var expense in expenseList)
            {
                ListViewItem item = new ListViewItem(expense.Date.ToShortDateString());
                item.SubItems.Add(expense.Category);
                item.SubItems.Add("R " + expense.Amount.ToString("F2"));
                item.SubItems.Add(expense.Notes);
                lvExpenseDetails.Items.Add(item);
            }
        }

        private void SetupListView()
        {
            lvExpenseDetails.View = View.Details;
            lvExpenseDetails.Columns.Add("Date", 100);
            lvExpenseDetails.Columns.Add("Category", 100);
            lvExpenseDetails.Columns.Add("Amount", 100);
            lvExpenseDetails.Columns.Add("Notes", 200);
        }



        private void frmExpenseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click_1(object sender, EventArgs e)
        {
            //Clear the current ListView items
            lvExpenseDetails.Items.Clear();

            //Get search query
            string query = txtSearch.Text.ToLower();

            //Filter and display results based on the search query
            var filteredExpenses = expenses
                .Where(exp => (exp.Category != null && exp.Category.ToLower().Contains(query)) ||
                              (exp.Notes != null && exp.Notes.ToLower().Contains(query)))
                .ToList(); // Convert to a list to use for iteration later

            //Display filtered expenses in ListView
            foreach (var expense in filteredExpenses)
            {
                ListViewItem item = new ListViewItem(expense.Date.ToShortDateString());
                item.SubItems.Add(expense.Category);
                item.SubItems.Add("R " + expense.Amount.ToString("F2"));
                item.SubItems.Add(expense.Notes);

                lvExpenseDetails.Items.Add(item);
            }

            //Check if no expenses match the search query
            if (!filteredExpenses.Any())
            {
                MessageBox.Show("No expenses match your search.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void llblExistingBudget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GoToTrackExpenses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the expenses menu: " + ex.Message);
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

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Ensure that an item is selected in the ListView
            if (lvExpenseDetails.SelectedItems.Count > 0)
            {
                //Loop through selected items and remove them from the ListView and the expense list
                foreach (ListViewItem selectedItem in lvExpenseDetails.SelectedItems)
                {
                    //Find the corresponding expense in the expense list and remove it
                    var expenseToRemove = expenses
                        .FirstOrDefault(exp => exp.Date.ToShortDateString() == selectedItem.Text &&
                                               exp.Category == selectedItem.SubItems[1].Text &&
                                               exp.Amount == decimal.Parse(selectedItem.SubItems[2].Text.Substring(2)));

                    if (expenseToRemove != null)
                    {
                        expenses.Remove(expenseToRemove);
                    }

                    //Remove the item from the ListView
                    lvExpenseDetails.Items.Remove(selectedItem);
                }
            }
            else
            {
                //Show a message if no item is selected
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void frmExpenseForm_FormClosed(object sender, FormClosedEventArgs e)
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