using System;
using System.Collections.Generic;
using System.Text;

namespace _20114823.PROG.TASK2
{
    class Expense
    {
        // Holds whats common in all payments
        public string Description { get; set; }
        public double Amount { get; set; }
        
        //I believe Income and Tax Deducted should be stored here but I could be wrong.

        public Expense(string description, double amount)
        {
            Description = Description;
            Amount = amount;
        }




    }
}
