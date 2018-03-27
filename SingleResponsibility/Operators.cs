using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
    public class Operator
    {
        private readonly char OpChar;

        private Operator(char opChar)
        {
            OpChar = opChar;
        }

        public static bool operator ==(Operator op1, Operator op2)
        {
            return (op1.OpChar == op2.OpChar);
        }

        public static bool operator !=(Operator op1, Operator op2)
        {
            return (op1.OpChar != op2.OpChar);
        }

        public static bool operator ==(Operator op1, char op2)
        {
            return (op1.OpChar == op2);
        }

        public static bool operator !=(Operator op1, char op2)
        {
            return (op1.OpChar != op2);
        }

        public override bool Equals(object obj)
        {
            var op2 = obj as Operator;

            if (op2 == null)
            {
                return false;
            }

            return op2 == this;
        }

        public override int GetHashCode()
        {
            return OpChar.GetHashCode();
        }

        public override string ToString()
        {
            return OpChar.ToString();
        }

        public static Operator Add => new Operator('+');

        public static Operator Subtract => new Operator('-');

        public static Operator Multiply => new Operator('*');

        public static Operator Divide => new Operator('/');

        public static IEnumerable<Operator> AllOperators
        {
            get
            {
                yield return Add;
                yield return Subtract;
                yield return Multiply;
                yield return Divide;
            }
        }
    }
}
