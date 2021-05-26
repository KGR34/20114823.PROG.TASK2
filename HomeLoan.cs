using System;
using System.Collections.Generic;
using System.Text;

namespace _20114823.PROG.TASK2
{
    class HomeLoan : Expense
    {
        public double HomePrice { get; set; }
        public double HomeDeposit { get; set; }
        public double HomeInterest { get; set; }
        public double HomeMonths { get; set; }


        public HomeLoan(double homePrice, double homeDeposit, double homeInterest, double homeMonths, //child fields
            string description, double amount // parent fields
            ) : base(description, amount)
        {
            HomePrice = homePrice;
            HomeDeposit = homeDeposit;
            HomeInterest = homeInterest;
            HomeMonths = homeMonths;
        }
    }
}

