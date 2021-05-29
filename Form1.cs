using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20114823.PROG.TASK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            double income = Convert.ToInt32(txbIncome.Text);
            //Calculate calc = new Calculate(income);


            string description = "General Expenses";
            double tax = Convert.ToInt32(txbTax.Text);
            double amount = 0;
            double groceries = Convert.ToInt32(txbGroceries.Text);
            double waterLights = Convert.ToInt32(txbWaterLights.Text);
            double travel = Convert.ToInt32(txbTravel.Text);
            double cellPhone = Convert.ToInt32(txbCellphone.Text);
            double other = Convert.ToInt32(txbOther.Text);

            amount = tax + groceries + waterLights + travel + cellPhone + other;

            GeneralExpense genEx = new GeneralExpense(groceries, waterLights, cellPhone, travel, other, tax, description, amount);

            Calculate.expenses.Add(genEx);

            


            if (cxbRent.Checked) 
            {
                double rent = Convert.ToInt32(txbRent.Text);

                amount = rent;
                description = "Rent";
                Rental itsRent = new Rental(rent, description, amount);

                Calculate.expenses.Add(itsRent);

                
            }
            if (cxbHomeLoan.Checked)
            {
                description = "Home Repayment"; 
                double homePrice = Convert.ToInt32(txbHomePrice.Text);
                double homeDeposit = Convert.ToInt32(txbHomeDeposit.Text);
                double homeInterest = Convert.ToInt32(txbHomeInterest.Text);
                double homeMonths = Convert.ToInt32(txbMonths.Text);

                double P = homePrice - homeDeposit;
                double I = homeInterest / 100;
                double N = homeMonths / 12;

                amount = P*(1 + I * N)/homeMonths;


                if (amount > income/3)
                {
                    MessageBox.Show("Your Loan Repayment is Greater than 1 third of \n your Gross Income! \n Loan Approval is Unlikely!");
                }




                MessageBox.Show("home \n " + amount);

                HomeLoan aHomeLoan = new HomeLoan(homePrice, homeDeposit, homeInterest, homeMonths, description, amount);

                Calculate.expenses.Add(aHomeLoan);
            }
            if (cxbVehicleLoan.Checked)
            {
                description = txbMakeModel.Text;
                double carPrice = Convert.ToInt32(txbCarPrice.Text);
                double carDeposit = Convert.ToInt32(txbCarDeposit.Text);
                double carInterest = Convert.ToInt32(txbCarInterest.Text);
                double carMonths = 60;
                double insurance = Convert.ToInt32(txbCarInsurance.Text);

                double P = carPrice - carDeposit;
                double I = carInterest / 100;
                double N = carMonths / 12;

                double carAmount = P * (1 + I * N) / carMonths;

                amount = carAmount + insurance;

                MessageBox.Show("car \n " + amount);

                VehicleLoan aVehicleLoan = new VehicleLoan(carPrice, carDeposit, carInterest, carMonths, insurance, description, amount);

                Calculate.expenses.Add(aVehicleLoan);

                

            }

            double sum = Calculate.expenses.Sum(x => x.Amount);
            //double final = ("");
            MessageBox.Show("Total Expenses :" + sum.ToString());

            double final = income - sum;
            
            MessageBox.Show("income less expenses = \n " + final);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cxbHomeLoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cxbHomeLoan.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else 
            {
                panel1.Visible = true;
            }
        }

        private void cxbRent_CheckedChanged(object sender, EventArgs e)
        {
            if (cxbRent.Checked)
            {
                panel2.Visible = false;
                panel1.Visible = true;

            }
            else
            {
                panel2.Visible = true;

            }
        }

        private void cxbVehicleLoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cxbVehicleLoan.Checked)
            {
                panel3.Visible = false;

            }
            else
            {
                panel3.Visible = true;

            }
        }

        private void btnViewExpenses_Click(object sender, EventArgs e)
        {
            //frmViewExpenses frmView = new frmViewExpenses();
            //frmView.Show();

            List<Expense> expense = Calculate.expenses.OrderByDescending(x => x.Amount).ToList();

            foreach (Expense exp in expense)
            {
                listBox1.Items.Add(exp.Display());
            }


        }
    }
}
