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
    {   //creates fields for delegate to use
        public double Sum { get; }
        public double Income { get; }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(double sum, double income)
        {
            Sum = sum;
            Income = income;
        }


        //Runs the following code when the "SUBMIT" button is clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try { 

            //Inputs for General Expenses
            double income = Convert.ToInt32(txbIncome.Text);
            string description = "General Expenses";
            double tax = Convert.ToInt32(txbTax.Text);
            double amount = 0;
            double groceries = Convert.ToInt32(txbGroceries.Text);
            double waterLights = Convert.ToInt32(txbWaterLights.Text);
            double travel = Convert.ToInt32(txbTravel.Text);
            double cellPhone = Convert.ToInt32(txbCellphone.Text);
            double other = Convert.ToInt32(txbOther.Text);

            //Calculates the sum of all general expenses to store as a singular value
            amount = tax + groceries + waterLights + travel + cellPhone + other;

            //Creates an object general expenses
            GeneralExpense genEx = new GeneralExpense(groceries, waterLights, cellPhone, travel, other, tax, description, amount);

            //stores object in Calculate class list
            Calculate.expenses.Add(genEx);



            //Checking whats selected, and creating an object depending on that
            if (cxbRent.Checked) 
            {
                double rent = Convert.ToInt32(txbRent.Text);

                amount = rent;
                description = "Rent";
                Rental itsRent = new Rental(rent, description, amount);

                //stores object in Calculate class list
                Calculate.expenses.Add(itsRent);

                
            }
            if (cxbHomeLoan.Checked)
            {
                string type = description;
                string type2 = description;
                description = "Home Repayment"; 
                double homePrice = Convert.ToInt32(txbHomePrice.Text);
                double homeDeposit = Convert.ToInt32(txbHomeDeposit.Text);
                double homeInterest = Convert.ToInt32(txbHomeInterest.Text);
                double homeMonths = Convert.ToInt32(txbMonths.Text);

                //Calculates montly home loan repayments
                double P = homePrice - homeDeposit;
                double I = homeInterest / 100;
                double N = homeMonths / 12;

                amount = P*(1 + I * N)/homeMonths;

                //if statement to check if home loan repayment is greater than a thrid of the users gross income
                if (amount > income/3)
                {
                    //outputs message if the home loan repayment is greater than a thrid of the users gross income
                    MessageBox.Show("Your Loan Repayment is Greater than 1 third of your Gross Income! \n Loan Approval is Unlikely!");
                }

                //outputs montly home loan repayments in a message box
                MessageBox.Show("Home Repayment: \n " + "R" + amount);
                
                //Creates an object Home Loan
                HomeLoan aHomeLoan = new HomeLoan(homePrice, homeDeposit, homeInterest, homeMonths, description, amount);
                
                //stores object in Calculate class list
                Calculate.expenses.Add(aHomeLoan);
            }
            if (cxbVehicleLoan.Checked)
            {
                String carName = "Vehicle Loan : " + txbMakeModel.Text;
                double carPrice = Convert.ToInt32(txbCarPrice.Text);
                double carDeposit = Convert.ToInt32(txbCarDeposit.Text);
                double carInterest = Convert.ToInt32(txbCarInterest.Text);
                double carMonths = 60;
                double insurance = Convert.ToInt32(txbCarInsurance.Text);

                //Calcuates montly vehicle loan repayments
                double P = carPrice - carDeposit;
                double I = carInterest / 100;
                double N = carMonths / 12;

                double carAmount = P * (1 + I * N) / carMonths;

                amount = carAmount + insurance;

                description = carName;

                //outputs monthly vehicle loan repayments in a message box
                MessageBox.Show("Vehicle Repayment: \n " + "R" + amount);

                //Creates an object Vehicle Loan
                VehicleLoan aVehicleLoan = new VehicleLoan(carPrice, carDeposit, carInterest, carMonths, insurance, carName, description, amount);

                //stores object in Calculate class list
                Calculate.expenses.Add(aVehicleLoan);

                
            }

            //Calculates total expenses
            double sum = Calculate.expenses.Sum(x => x.Amount);
            
            //Outputs total expenses in a message box
            MessageBox.Show("Total Expenses :" + "R" + sum.ToString());

            //Calculates income less expenses
            double final = income - sum;
            
            //Outputs income less expenses in  a message box
            MessageBox.Show("Income less expenses :" + "R" + final);

            //creates object 
            Form1 alertDetails = new Form1(sum, income);
            
            //instance of the alert(delegate) service
            Alert alertProcessor = new Alert();

            alertProcessor.alertUser(alertDetails);

                //if statement to check if total expenses exceed 75% of income
                if (sum > income*3/4)
                {
                    MessageBox.Show("Your total expenses exceed 75% of your income!");
                }


            }

            //CATCH TO WARN USER OF INCORRECT INPUT
            catch (Exception )
            {
                Console.WriteLine("\nYOU DID NOT ENTER A NUMBER PLEASE START AGAIN AND ENTER A VALID NUMBER.");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cxbHomeLoan_CheckedChanged(object sender, EventArgs e)
        {   
            //hides rent input and shows home loan inputs if home loan is checked
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
            //hides home loan inputs and shows rent inout if rent is checked
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
            //shows and hides vehicle loan inputs depending on weather the vehicle loan option is checked
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
            //Accesses List of expenses and orders them in Descending order
            List<Expense> expense = Calculate.expenses.OrderByDescending(x => x.Amount).ToList();
            
            //for each expense and description stored in the expense list an item will be added to the list box
            foreach (Expense exp in expense)
            {
                listBox1.Items.Add(exp.Display());
            }


        }
    }
}
