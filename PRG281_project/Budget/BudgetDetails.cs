namespace Goals_PRG281_project
{
    public class BudgetDetails
    {
        public string Category { get; set; }
        public decimal BudgetedAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        public BudgetDetails(string category, decimal budgetedAmount)
        {
            Category = category;
            BudgetedAmount = budgetedAmount;
            RemainingAmount = budgetedAmount;
        }
    }
}
