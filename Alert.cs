using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace _20114823.PROG.TASK2
{
    class Alert
    {

        public delegate void alertDelegate(Expense e);

        public event alertDelegate alert;


        protected virtual void OnAlert(Expense e)
        {
            if(alert != null)
            {
                alert(e);
            }
        }

        public void alertUser(Expense e)
        {
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
