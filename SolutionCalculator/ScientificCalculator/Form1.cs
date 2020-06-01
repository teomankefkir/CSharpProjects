using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class frmScientificCalculator : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        //convert
        float iCelsius, iFahrenheit, iKelvin;
        char iOperation;

        public frmScientificCalculator()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 258;
            txtDisplay.Width = 218;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 491;
            txtDisplay.Width = 451;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 760;
            txtDisplay.Width = 451;
            txtConvert.Focus();

            /*groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;

            groupBox1.Location = new Point(772, 72);
            groupBox1.Width = 248;
            groupBox1.Height = 384;*/
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 760;
            txtDisplay.Width = 451;
        }

        //point and numerics button
        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if(num.Text==".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + num.Text;
            }
        }

        //clear button
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        //clear button
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        //backspace button
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text=="")
            {
                txtDisplay.Text = txtDisplay.Text = "0";
            }
        }

        //operators button
        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblShowOp.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        //pi button
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        //log button
        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        //sqrt button
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        //sinh button
        private void btnSinh_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);
        }

        //sin button
        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
            qSin = Math.Sin(qSin);
            txtDisplay.Text = System.Convert.ToString(qSin);
        }

        //cosh button
        private void btnCosh_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txtDisplay.Text = System.Convert.ToString(qCosh);
        }

        //cos button
        private void btnCos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
            qCos = Math.Cos(qCos);
            txtDisplay.Text = System.Convert.ToString(qCos);
        }

        //tanh button
        private void btnTanh_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtDisplay.Text = System.Convert.ToString(qTanh);
        }

        //tan button
        private void btnTan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txtDisplay.Text = System.Convert.ToString(qTan);
        }

        //bin button
        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        //hex button
        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        //oct button
        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        //dec button
        private void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //x2 button
        private void btnXTwo_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //x3 button
        private void btnXThree_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //1/x button
        private void btnOneX_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //inx button
        private void btnInX_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        //percent button
        private void btnPercent_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void rbtnCelToFah_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbtnFahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbtnKelvin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        //multipcilation multiply button
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMultiply.Text);
            for (int i = 1; i < 13; i++)
            {
                lstMultiply.Items.Add(i + "x" + a + "=" + a * i);
            }
        }

        //multipcilation reset button
        private void btnResetMultiply_Click(object sender, EventArgs e)
        {
            lstMultiply.Items.Clear();
            txtMultiply.Clear();
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1032;
            txtDisplay.Width = 451;
            txtMultiply.Focus();

            /*groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            groupBox3.Location = new Point(772, 72);
            groupBox3.Width = 248;
            groupBox3.Height = 384;*/
        }

        //temperature convert button
        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch(iOperation)
            {
                case 'C':
                    //Celsius to Fahrenheit
                    iCelsius = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    //Fahrenheit to Celsius
                    iFahrenheit= float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;
                case 'K':
                    //Convert to Kelvin
                    iKelvin = float.Parse(txtConvert.Text);
                    lblConvert.Text = (((((9 * iKelvin) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scientific Calculator v1.0");
        }

        //plus and minus button
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        //temperature reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            rbtnCelToFah.Checked = false;
            rbtnFahToCel.Checked = false;
            rbtnKelvin.Checked = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}