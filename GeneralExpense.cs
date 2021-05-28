using System;
using System.Collections.Generic;
using System.Text;

namespace _20114823.PROG.TASK2
{
    class GeneralExpense : Expense
    {
        public double Groceries { get; set; }
        public double WaterLights { get; set; }
        public double CellPhone { get; set; }
        public double Travel { get; set; }
        public double Other { get; set; }
        public double Tax { get; set; }

        public GeneralExpense(double groceries, double waterLights, double cellPhone, double travel, double other, double tax, //child fields
            string description, double amount // parent fields
            ) : base(description, amount)
        {
            Groceries = groceries;
            WaterLights = waterLights;
            CellPhone = cellPhone;
            Travel = travel;
            Other = other;
            Tax = tax;
        }

        public override string Display()
        {
            return "Card Payment\t Order ID - " + base.Description + "\tAmount R: " + base.Amount;
        }

    }
}
