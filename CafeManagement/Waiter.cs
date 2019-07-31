using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AromatBar
{
    public partial class Waiter : Form
    {
        public string name;
        Form1 form = new Form1();
        
       
        public Waiter()
        {
            InitializeComponent();
            BtnClose.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
           
        }
        

        private void BtnClose_Click(object sender, EventArgs e)
        {
                
                if (lbWaiterName.Text == "Your Name")
                {
                    MessageBox.Show("You should fill the blank");
                }
                else
                {
                    Form1.persons = lbWaiterName.Text;
                    this.Close();   
                }
                    
        }



        private void lbWaiterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               BtnClose.PerformClick();
            }
        }
   
    }
}
