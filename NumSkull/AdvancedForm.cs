using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumSkull
{

    public partial class AdvancedForm : Form
    {
        private readonly ICalculator calculator;

        public AdvancedForm()
        {
            InitializeComponent();
            calculator = new Maths();
        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double operand))
            {
                double result = Math.Sin(operand);
                string operationString = $"sin({operand}) = {result}";
                textBoxInput.Text = result.ToString();
                textBoxResult.Text = operationString;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double operand))
            {
                double result = Math.Cos(operand);
                string operationString = $"cos({operand}) = {result}";
                textBoxInput.Text = result.ToString();
                textBoxResult.Text = operationString;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void ButtonTan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double operand))
            {
                double result = Math.Tan(operand);
                string operationString = $"tan({operand}) = {result}";
                textBoxInput.Text = result.ToString();
                textBoxResult.Text = operationString;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double operand))
            {
                double result = Math.Log10(operand);
                string operationString = $"log({operand}) = {result}";
                textBoxInput.Text = result.ToString();
                textBoxResult.Text = operationString;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void ButtonLn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double operand))
            {
                double result = Math.Log(operand);
                string operationString = $"ln({operand}) = {result}";
                textBoxInput.Text = result.ToString();
                textBoxResult.Text = operationString;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int operand))
            {
                double result = Factorial(operand);
                string operationString = $"{operand}! = {result}";
                textBoxInput.Text = result.ToString();
                textBoxResult.Text = operationString;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
            }
        }

        private double Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("Factorial is not defined for negative numbers.");
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                textBoxInput.AppendText(button.Text);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxResult.Clear();
        }

        private void ButtonBasic_Click(object sender, EventArgs e)
        {
            Form1 basicForm = new Form1();
            basicForm.Show();
            this.Close();
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                textBoxInput.AppendText(" " + button.Text + " ");
            }
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBoxInput.Text;
                double result = calculator.EvaluateExpression(expression);
                string operationString = expression + " = " + result;
                textBoxInput.Text = result.ToString();
                textBoxResult.Text = operationString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            textBoxInput.AppendText(Math.PI.ToString());
        }
    }
}
