using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        String operation = "";
        Double firstnum, secondnum;
        public frmCalculator()
        {
            InitializeComponent();
        }

        //point and numerics button
        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";
            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        //clear button
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        //clear button
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            String FirstNumber, SecondNumber;
            FirstNumber = Convert.ToString(firstnum);
            SecondNumber = Convert.ToString(secondnum);
            FirstNumber = "";
            SecondNumber = "";
        }

        //operators button
        private void OperationalFunction(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        //backspace button
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        //minus and plus button
        private void btnPM_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        //equal button
        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondnum = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstnum + secondnum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(firstnum / secondnum);
                    break;
                default:
                    break;
            }
        }
    }
}