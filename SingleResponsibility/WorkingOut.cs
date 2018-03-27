using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class WorkingOut
    {
        private readonly double _num;
        private readonly double _secondNum;
        public WorkingOut(double num, double secondNum)
        {       
            _num = num;
            _secondNum = secondNum;
        }
        public double SimpleMultiplication()
        {
            double sum = _num * _secondNum;

            return sum;
        }
        public double SimpleDivision()
        {
            double sum = _num / _secondNum;

            return sum;
        }
        public double SimpleAddition()
        {
            double sum = _num + _secondNum;

            return sum;
        }
        public double SimpleSubtraction()
        {
            double sum = _num - _secondNum;

            return sum;
        }
        public double ReturnOperatorChosen(double num1, double num2, Operator op)
        {
            if (op == Operator.Subtract)
            {
                return SimpleSubtraction();
            }
            else if (op == Operator.Add)
            {
                return SimpleAddition();
            }
            else if (op == Operator.Divide)
            {
                return SimpleDivision();
            }
            else if (op == Operator.Multiply)
            {
                return SimpleMultiplication();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(op));
            }
        }
    }
}
