using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050LabW8JoshDaum
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = 1;
            int counter = 1;

            while (control < 10)
            {
                Console.WriteLine("control is equal to " + control);
                Console.WriteLine("counter is equal to " + counter + "\n");
                control += 2;
                counter += 1;

            }

            for (int j = 30; j <= 45; j++)
            {
                Console.WriteLine(j);
                if ((j % 2 == 0))
                {
                    Console.WriteLine("It's even.");
                }
            }

            Console.Write("Enter an integer value for the hour in military time: ");
            int milTime = Convert.ToInt16(Console.ReadLine());

            if (milTime < 12)
            {
                Console.WriteLine("Good morning.");
            }
            else if (milTime < 17)
            {
                Console.WriteLine("Good afternoon.");
            }
            else if (milTime < 25)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Since you must be on a planet other than earth, " +
                    "I have no idea what time of day it is where you are." +
                    "I'll simply wish you a good day.");
            }

            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                //added incrementation for control variable
                i++;
            }

            for (int k = 0; k < 101; k++)
            // added braces for looped code
            {
                Console.WriteLine(k);
                Console.WriteLine("********");
            }

            for (int rowCount1 = 1; rowCount1 <= 10; rowCount1++)
            {
                for (int columnCount1 = 1; columnCount1 <= rowCount1; columnCount1++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            for (int rowCount2 = 10; rowCount2 >= 1; rowCount2--)
            {
                for (int columnCount2 = 1; columnCount2 <= rowCount2; columnCount2++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine(); 
            int blankies1;

            for (int rowCount4 = 10; rowCount4 >= 1; rowCount4--)
            {
                for (blankies1 = 1; blankies1 <= 10 - rowCount4; blankies1++)
                {
                    
                    Console.Write(' ');
                }

                for (int columnCount4 = 1; columnCount4 <= rowCount4; columnCount4++)
                {
                    Console.Write('*');
                }                    
                Console.WriteLine();
            }

            Console.WriteLine();
            int blankies2;

            for (int rowCount3 = 1; rowCount3 <= 10; rowCount3++)
            {
                for (blankies2 = 1; blankies2 <= 10 - rowCount3; blankies2++)
                {

                    Console.Write(' ');
                }

                for (int columnCount3 = 1; columnCount3 <= rowCount3; columnCount3++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
