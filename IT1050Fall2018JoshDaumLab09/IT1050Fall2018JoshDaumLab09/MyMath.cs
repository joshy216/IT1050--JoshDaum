using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Fall2018JoshDaumLab09
{
    public class MyMath
    {
        public double x;
        public double y;
        public double result;

        public MyMath(double operand1, double operand2)
        {
            x = operand1;
            y = operand2;
        }

        public void Multiply()
        {
            Console.Write(x + " * " + y);
            result = x * y;
        }

        public void Divide()
        {
            Console.Write(x + " / " + y);
            result = x / y;
        }

        public void Add()
        {
            Console.Write(x + " + " + y);
            result = x + y;
        }

        public void Subtract()
        {
            Console.Write(x + " - " + y);
            result = x - y;
        }

        public void GetResult()
        {
            Console.Write(" = " + result);
            Console.WriteLine();
        }

    }
}
