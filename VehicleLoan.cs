using System;
using System.Collections.Generic;
using System.Text;

namespace _20114823.PROG.TASK2
{
    class VehicleLoan : Expense
    {
        //Holds whats unique to Vehicle Loans
        public double CarPrice { get; set; }
        public double CarDeposit { get; set; }
        public double CarInterest { get; set; }
        public double CarMonths { get; set; }
        public double Insurance { get; set; }
        public string CarName { get; set; }


        public VehicleLoan(double carPrice, double carDeposit, double carInterest, double carMonths, double insurance, string carName, //child fields
            string description, double amount // parent fields
            ) : base(description, amount)
        {
            CarPrice = carPrice;
            CarDeposit = carDeposit;
            CarInterest = carInterest;
            CarMonths = carMonths;
            Insurance = insurance;
            CarName = carName;
        }

        public override string Display()
        {
            return  base.Description + "\tAmount R: " + base.Amount;
        }

    }
}
