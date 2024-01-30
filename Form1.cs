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
    public partial class Calculator : Form
    {
        double enterFirstValue,enterSecondValue;
        String op;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Width = 428; //Original is 890
            txtResult.Width = 398;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1,1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }
        private void EnterNumbers(object sender, EventArgs e)
        {
            if (sender is Button num)
            {
                if (txtResult.Text == "0")
                    txtResult.Text = "";

                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                    {
                        txtResult.Text = txtResult.Text + num.Text;
                    }
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }


        private void numberOperator(object sender, EventArgs e)
        {
            Button num = ( Button )sender;
            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void buttonClear(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClick_Clear_Entry(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            enterFirstValue = 0;
            enterSecondValue = 0;
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void standardCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 428; //Original is 890
            CloseButton.Location = new System.Drawing.Point(393, -1);
            txtResult.Width = 398;
        }

        private void scientificCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 738;
            CloseButton.Location = new System.Drawing.Point(701, -1);
            txtResult.Width = 707;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.PI.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Log10(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Sqrt(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Sin(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Sinh(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Pow(answer, 2);
            txtResult.Text = answer.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Cos(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Cosh(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Tan(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnTangh_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Tanh(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double answer = Convert.ToDouble(txtResult.Text);
            answer = Math.Log(answer);
            txtResult.Text = answer.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtResult.Text = Math.E.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            try
            {
                switch (op)
                {
                    case "+":
                        txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                        break;
                    case "-":
                        txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                        break;
                    case "*":
                        txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                        break;
                    case "/":
                        if (enterSecondValue != 0)
                        {
                            txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                        }
                        else
                        {
                            txtResult.Text = "Error";
                        }
                        break;
                    case "Mod":
                        txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                        break;
                    case "‎xⁿ":
                        txtResult.Text = (Math.Pow(enterFirstValue, enterSecondValue)).ToString();
                        break;

                    case "%":
                        txtResult.Text = (enterFirstValue * (enterSecondValue/100)).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                txtResult.Text = "Error";
                
                Console.WriteLine(ex.Message);
            }
        }
    }
}
