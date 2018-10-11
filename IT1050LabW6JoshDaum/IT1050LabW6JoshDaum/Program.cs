using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050LabW6JoshDaum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Compare and contrast the if single-selection statement and the while repetition statement.  
            How are these two statements similar?  How are they different? (2 Points).

            They are similar in that both are entered in the format:

                Keyword (condition)
                {
                    Code to execute if condition is met
                }
            
            They differ in that the while statement loops the code within the braces until a condition is met, but the if statement only executes
            the code in the braces if a condition is met.


            2.	Declare two int variables: 1) speedLimit and 2) speed.  Assign values speedLimit=35 and speed=42.  Write an if statement 
            that displays “SLOW NOW” if speed is greater than speedLimit. (2 points) 
            */
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW\n");
            }

            /* 
            3.	if-else statement - Write a program that declares and assigns a value to a Boolean variable called isTrue.  
            Use a condition to output “It is True!” or “It is False!” based on the assigned value.  Paste your code and screenshots of your 
            program running with both true and false values (3 points).

                Example:    bool isTrue = true;
	                        bool isTrue = false;
            */
            bool isTrue = false;

            if (isTrue)
            {
                Console.WriteLine("It is True!\n");
            }
            else
            {
                Console.WriteLine("It is False!\n");
            }

            /*
            4.	if statement - Write a program that converts a Fahrenheit temperature to Celsius.  The user should be able to input the 
            temperature at the Command prompt and it should output the temperature.  In addition, you should output “It is cold” if the Fahrenheit 
            value is less that 40 or it should output “It is hot” if the temperature is over 90 (4 points).  
            Code to read a value: double fahrenheit = Convert.ToDouble(Console.ReadLine()); Code to convert: celsius  = (fahrenheit - 32d) * 5d / 9d;
            */
            Console.Write("Enter a temperature in degrees Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = ((fahrenheit - 32d) * (5d / 9d));
            Console.WriteLine("{0} degrees Fahrenheit is equal to {1} degrees Celsius.", fahrenheit, celsius);
            if (fahrenheit < 40)
            {
                Console.WriteLine("It is cold.\n");
            }
            if (fahrenheit > 90)
            {
                Console.WriteLine("It is hot.\n");
            }


            /*
            5.	Write a while loop that outputs values 1-10.  Increment by 1 (3 points).
            */
            int counter = 1;
            Console.WriteLine("And now: 1 through 10!");
            while (counter < 11)
            {
                Console.WriteLine(counter);
                counter++;
            }

            //6.	Write a while loop that outputs values 60 to 20.  Decrement by 1 (3 points)

            int counter2 = 60;
            Console.WriteLine("\nAnd now: 60 through 20!");
            while (counter2 > 19)

            {
                Console.WriteLine(counter2);
                counter2--;
            }


            //7.	Create a while that outputs values 10-20 (3 points).

            int counter3 = 10;
            Console.WriteLine("\nAnd now: 10 through 20!");
            while (counter3 < 21)
            {
                Console.WriteLine(counter3);
                counter3++;

            }
        }
    }
}
