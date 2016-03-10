using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Model
    {
        public string Input(string operation, double operand1, double operand2)
        {
            switch (operation)
            {
                case "/":
                    return Division(operand1, operand2).ToString();
                    break;
                case "*":
                    return Multiplication(operand1, operand2).ToString();
                    break;
                case "-":
                    return Substraction(operand1, operand2).ToString();
                    break;
                case "+":
                    return Addition(operand1, operand2).ToString();
                    break;
                default:
                    return "Something bad";
                    break;
            }
        }
        public double Addition (double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public double Substraction(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        public double Multiplication(double operand1, double operand2)
        {
            return operand1*operand2;
        }

        public double Division(double operand1, double operand2)
        {
            return operand1/operand2;
        }
    }
}
