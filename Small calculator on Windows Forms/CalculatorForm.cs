using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;

namespace Small_calculator_on_Windows_Forms
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            InitializeComponent();
        }

        private void equally_Click(object sender, EventArgs e)
        {
            try
            {
                info.Text = string.Empty;
                var result = new DataTable().Compute(output.Text, null).ToString();
                output.Text = result;
            }
            catch
            {
                if(output.Text.Contains(","))
                {
                    info.Text = "Fraction sign: \".\"";
                    output.Text = string.Empty;
                    return;
                }
                output.Text = string.Empty;
                info.Text = "Invalid expression";
            }
        }

        private void eraseEverything_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
        }

        private void eraseLast_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = output.Text.Remove(output.Text.Length - 1);
            }
            catch
            {
                output.Text = string.Empty;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "*";
        }

        private void share_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "/";
        }

        private void eraseFullLastNum_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = output.Text.Length; i <= output.Text.Length; i--)
                {
                    char c = output.Text[i - 1];
                    if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        break;
                    }
                    else
                    {
                        output.Text = output.Text.Remove(output.Text.Length - 1);
                    }
                }
            }
            catch
            {
                output.Text = string.Empty;
            }
        }

        private bool staplesOpen = false;
        private void staples_Click(object sender, EventArgs e)
        {
            if (staplesOpen == false)
            {
                output.Text = output.Text + "(";
                staplesOpen = true;
            }
            else
            {
                output.Text = output.Text + ")";
                staplesOpen = false;
            }
        }

        private void separator_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + ".";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "9";
        }
    }
}
