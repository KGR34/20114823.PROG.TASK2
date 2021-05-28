
namespace _20114823.PROG.TASK2
{
    partial class frmViewExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstExpenses
            // 
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.ItemHeight = 15;
            this.lstExpenses.Location = new System.Drawing.Point(43, 42);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.Size = new System.Drawing.Size(159, 304);
            this.lstExpenses.TabIndex = 0;
            // 
            // frmViewExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstExpenses);
            this.Name = "frmViewExpenses";
            this.Text = "frmViewExpenses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExpenses;
    }
}