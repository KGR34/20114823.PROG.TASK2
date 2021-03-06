using System;
using System.Collections.Generic;
using System.Text;

namespace _20114823.PROG.TASK2
{
    class Rental : Expense
    {   
        //Holds what is unique to Rental
        public double Rent { get; set; }


        public Rental(double rent, //child fields
            string description, double amount // parent fields
            ) : base(description, amount)
        {
            Rent = rent;
        }

        public override string Display()
        {
            return base.Description + ".        \tAmount R: " + base.Amount;
        }

    }
}
