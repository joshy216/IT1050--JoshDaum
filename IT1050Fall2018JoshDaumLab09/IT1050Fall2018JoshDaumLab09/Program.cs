using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Fall2018JoshDaumLab09
{
    class Program
    {
        static void Main(string[] args)
        {
            double op1;
            double op2;

            Console.Write("Enter operand 1: ");
            op1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operand 2: ");
            op2 = Convert.ToDouble(Console.ReadLine());

            var myOutput = new MyMath(op1, op2);
            myOutput.Subtract();
            myOutput.GetResult();

            myOutput.Add();
            myOutput.GetResult();

            myOutput.Divide();
            myOutput.GetResult();

            myOutput.Multiply();
            myOutput.GetResult();

        }
    }
}
