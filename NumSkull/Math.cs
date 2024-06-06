using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSkull
{
    internal class Maths : ICalculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }
        public double SquareRoot(double a) => Math.Sqrt(a);
        public double Power(double a, double b) => Math.Pow(a, b);
        public double Modulus(double a, double b) => a % b;

        public double EvaluateExpression(string expression)
        {
            var tokens = ParseTokens(expression);
            var values = new Stack<double>();
            var operators = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                double value;
                if (double.TryParse(tokens[i], out value))
                {
                    values.Push(value);
                }
                else if (tokens[i] == "π")
                {
                    values.Push(Math.PI);
                }
                else if (tokens[i] == "(")
                {
                    operators.Push('(');
                }
                else if (tokens[i] == ")")
                {
                    while (operators.Peek() != '(')
                    {
                        values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Pop();
                }
                else if (IsOperator(tokens[i]))
                {
                    while (operators.Count > 0 && HasPrecedence(tokens[i][0], operators.Peek()))
                    {
                        values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Push(tokens[i][0]);
                }
            }

            while (operators.Count > 0)
            {
                values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private string[] ParseTokens(string expression)
        {
            var tokens = new List<string>();
            var token = "";

            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]) || expression[i] == '.')
                {
                    token += expression[i];
                }
                else if (expression[i] == 'π')
                {
                    if (token != "")
                    {
                        tokens.Add(token);
                        token = "";
                    }
                    tokens.Add("π");
                }
                else
                {
                    if (token != "")
                    {
                        tokens.Add(token);
                        token = "";
                    }
                    tokens.Add(expression[i].ToString());
                }
            }

            if (token != "")
            {
                tokens.Add(token);
            }

            return tokens.ToArray();
        }

        private bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        private bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            return true;
        }

        private double ApplyOperation(char operation, double b, double a)
        {
            switch (operation)
            {
                case '+': return Add(a, b);
                case '-': return Subtract(a, b);
                case '*': return Multiply(a, b);
                case '/': return Divide(a, b);
                default: throw new NotSupportedException("Unsupported operation");
            }
        }
    }
}
