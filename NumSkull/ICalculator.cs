using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSkull
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
        double SquareRoot(double a);
        double Power(double a, double b);
        double Modulus(double a, double b);
        double EvaluateExpression(string expression);
    }
}
