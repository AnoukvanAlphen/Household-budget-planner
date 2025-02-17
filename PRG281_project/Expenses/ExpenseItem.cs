using System;

namespace Goals_PRG281_project
{
    public class ExpenseItem
    {
        // Fields
        private string categoryName;
        private double budgetedAmount;
        private double actualAmount;
        private double remainingAmount;
        private DateTime date;
        private string notes;

        // Properties
        public string CategoryName { get { return categoryName; } set { categoryName = value; } }
        public double BudgetedAmount { get { return budgetedAmount; } set { budgetedAmount = value; } }
        public double ActualAmount { get { return actualAmount; } set { actualAmount = value; } }
        public double RemainingAmount { get { return remainingAmount; } set { remainingAmount = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public string Notes { get { return notes; } set { notes = value; } }

        public ExpenseItem(string categoryName, double budgetedAmount, double actualAmount, double remainingAmount, DateTime date, string notes)
        {
            CategoryName = categoryName;
            BudgetedAmount = budgetedAmount;
            ActualAmount = actualAmount;
            RemainingAmount = remainingAmount;
            Date = date;
            Notes = notes;
        }
    }
}
