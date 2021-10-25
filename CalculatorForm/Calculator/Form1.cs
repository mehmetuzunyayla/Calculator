using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string Operation;
        double FNumber;
        public Form1()
        {

            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text== "0" && txtEnter.Text!=null)
            {
                txtEnter.Text = "1";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "2";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "3";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "4";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "5";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "6";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "7";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "8";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "9";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "0" && txtEnter.Text != null)
            {
                txtEnter.Text = "0";
            }
            else
            {
                txtEnter.Text = txtEnter.Text + "0";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FNumber = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            Operation = "÷";
            
            
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            FNumber = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            Operation = "*";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FNumber = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            Operation = "-";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            FNumber = Convert.ToDouble(txtEnter.Text);
            txtEnter.Clear();
            Operation = "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SNumber = Convert.ToDouble(txtEnter.Text);
            if (Operation=="+")
            {
                txtEnter.Text = Convert.ToString(FNumber + SNumber);
                FNumber= (FNumber + SNumber);
            }
            else if (Operation=="-")
            {
                txtEnter.Text = Convert.ToString(FNumber - SNumber);
                FNumber= (FNumber - SNumber);
            }
            else if (Operation=="*")
            {
                txtEnter.Text = Convert.ToString(FNumber * SNumber);
                FNumber = (FNumber * SNumber);

            }
            else if (Operation=="÷")
            {
                txtEnter.Text = Convert.ToString(FNumber / SNumber);
                FNumber= (FNumber / SNumber);
            }
            else
            {
                txtEnter.Text = null;
            }
        }
    }
}
