using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW4_JoshDaum
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberOne;
            decimal numberTwo;
            decimal dSum;
            decimal x;
            decimal y;
            decimal z;
            decimal dSumTwo;

            Console.WriteLine("Enter a number: ");
            numberOne = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            numberTwo = decimal.Parse(Console.ReadLine());

            dSum = numberOne + numberTwo;

            Console.WriteLine("The result of {0} + {1} is {2}", numberOne, numberTwo, dSum);



            Console.WriteLine("Great. That was fun. Now, enter a number: ");
            x = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Awesome--you're doing great! Enter another number: ");
            y = decimal.Parse(Console.ReadLine());

            Console.WriteLine("One more, if you don't mind: ");
            z = decimal.Parse(Console.ReadLine());

            dSumTwo = (x + y) * (z + 10);

            Console.WriteLine("Thanks! ({0} + {1}) * ({2} + 10) equals {3}. In case you were wondering.", x, y, z, dSumTwo);


            Console.WriteLine("Hello \t World!");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");
        }
    }
}
