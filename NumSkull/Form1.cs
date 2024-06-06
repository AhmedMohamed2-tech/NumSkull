using NumSkull;
using System;
using System.Windows.Forms;

namespace NumSkull
{
    public partial class Form1 : Form
    {
        private readonly ICalculator calculator;
        private string currentOperation;
        private double firstOperand;
        public bool isSecondOperand;

        public Form1()
        {
            InitializeComponent();
            calculator = new Maths();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                textBoxCurrentInput.AppendText(button.Text);
                TxtOperation.AppendText(button.Text);
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                currentOperation = button.Text;
                TxtOperation.AppendText(" " + currentOperation + " ");
                textBoxCurrentInput.Clear();
                isSecondOperand = true;
            }
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = TxtOperation.Text;
                double result = calculator.EvaluateExpression(expression);
                string operationString = expression + " = " + result;
                textBoxCurrentInput.Text = result.ToString();
                TxtOperation.Text = operationString;
                AddToHistory(operationString);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCurrentInput.Text, out double operand))
            {
                double result = calculator.SquareRoot(operand);
                string operationString = $"√({operand}) = {result}";
                textBoxCurrentInput.Text = result.ToString();
                TxtOperation.Text = result.ToString();
                AddToHistory(operationString);
                RefreshForm();
            }
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            textBoxCurrentInput.Text = Math.PI.ToString();
            TxtOperation.AppendText("π");
        }

        private void ButtonAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedForm advancedForm = new AdvancedForm();
            advancedForm.Show();
            this.Hide();
        }

        private void AddToHistory(string operation)
        {
            dataGridViewHistory.Rows.Add(operation);
        }

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            textBoxCurrentInput.Clear();
            TxtOperation.Clear();
        }

        private void RefreshForm()
        {
            textBoxCurrentInput.Clear();
            TxtOperation.Clear();
            isSecondOperand = false;
            currentOperation = string.Empty;
        }
    }
}
