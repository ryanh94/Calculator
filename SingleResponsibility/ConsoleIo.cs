using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class ConsoleIo
    {
        public double GetNumber()
        {
            double num = 0;
            
            do
            {
                Console.WriteLine("Please enter your first number");
            } while (!double.TryParse(Console.ReadLine(), out num));

            return num;
        }

        public double GetSecondNumber()
        {
            double secondNum = 0;
            do
            {
                Console.WriteLine("Please enter your second number");
            } while (!double.TryParse(Console.ReadLine(), out secondNum));

            return secondNum;
        }

        public void WriteSum(double num)
        {
            Console.WriteLine($"The ansewer is {num}");
        }

        public void WriteOperatorsToChoose()
        {
            Console.WriteLine("Select an operator: " + string.Join(", ", Operator.AllOperators));
        }

        public Operator OperatorSelected()
        {
            ConsoleKeyInfo keyPress;
            do
            {
                keyPress = Console.ReadKey(true);
            } while (Operator.AllOperators.All(o => o != keyPress.KeyChar));

            Console.WriteLine(keyPress.KeyChar);

            return Operator.AllOperators.First(o => o == keyPress.KeyChar);
        }
    }
}
