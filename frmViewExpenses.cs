using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20114823.PROG.TASK2
{
    public partial class frmViewExpenses : Form
    {
        public frmViewExpenses()
        {
            InitializeComponent();
        }


        private void frmViewExpense_Load(object sender, EventArgs e)
        {
            List<Expense> expense = Calculate.expenses.OrderByDescending(x => x.Amount).ToList();

            foreach (Expense exp in expense)
            {
                lstExpenses.Items.Add(exp.Display());
            }

        }

    }
}
