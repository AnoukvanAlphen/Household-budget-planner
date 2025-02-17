using System;

namespace Goals_PRG281_project
{
    public class Expense
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }//Actual amount
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
