using System;
using System.Collections.Generic;
using System.Text;

namespace _20114823.PROG.TASK2
{
    public abstract class Expense
    {
        // Holds whats common in all Expenses
        public string Description { get; set; }
        public double Amount { get; set; }
        
        

        public Expense(string description, double amount)
        {
            Description = description;
            Amount = amount;
            
        }

        public abstract string Display();


    }
}
