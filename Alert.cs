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
            


        }











    }
}
