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
	public string operation;
	public string output;

        public MyMath(double operand1, double operand2)
        {
            x = operand1;
            y = operand2;
        }

        public void Multiply()
        {
            result = x * y;
	        operation = "multiply";
        }

        public void Divide()
        {
            result = x / y;
	        operation = "divide";
        }

        public void Add()
        {
            result = x + y;
	        operation = "add";
        }

        public void Subtract()
        {
            result = x - y;
	        operation = "subtract";
        }

        public void GetResult()
        {
	    switch (operation) {
		    case "multiply":
			    output = x + " * " + y + " = " + result;
			    break;
		    case "divide":
			    output = x + " / " + y + " = " + result;
			    break;
		    case "add":
			    output = x + " + " + y + " = " + result;
			    break;
		    case "subtract":
			    output = x + " - " + y + " = " + result;
			    break;
		}

            Console.WriteLine(output);
        }

    }
}
