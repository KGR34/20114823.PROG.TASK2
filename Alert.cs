using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _20114823.PROG.TASK2
{
    class Alert
    {
        //Delegate for alerting the user
        public delegate void alertDelegate(Expense e);

        //Event to trigger the delegate and its methods
        public event alertDelegate alert;

        //performs the delegate/event call
        protected virtual void OnAlert(Expense e)
        {   
            //checks if methods are assigned
            if(alert != null)
            {
                alert(e);
            }
        }
        
        //assigns methods to delegate
        public void alertUser(Expense e)
        {   
            //calls delegate/runs event
            alert += tooHigh;
            tooHigh(e);
            OnAlert(e);
        }

        private void tooHigh(Expense e)
        {

            //Calculates total expenses
            double sum = Calculate.expenses.Sum(x => x.Amount);

            //Calculates income less expenses
            double final = income - sum;


            if (sum > income * 3 / 4)
            {
                //Creates the message and the title for the messagbox
                string message = "Your total expenses exceed 75% of your income!";
                string title = "ALERT!";
                MessageBox.Show(message, title);
            }
        }







    }
}
