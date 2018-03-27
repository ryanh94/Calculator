using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleIo console = new ConsoleIo();

            double num = console.GetNumber();
            console.WriteOperatorsToChoose();
          
            Operator op = console.OperatorSelected();
            double secondNum = console.GetSecondNumber();

            WorkingOut rev = new WorkingOut(num, secondNum);

            console.WriteSum(rev.ReturnOperatorChosen(num, secondNum, op));

            Console.ReadLine();
        }
    }
}
