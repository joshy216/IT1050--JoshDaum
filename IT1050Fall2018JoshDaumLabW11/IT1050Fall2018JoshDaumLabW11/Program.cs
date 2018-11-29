using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Fall2018JoshDaumLabW11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.)

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine(names[2]);
            Console.WriteLine(names[4]);




            // 2.) 

            string[] months = new string[12];
                           
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int showMonth = 0; showMonth <= 11; showMonth++)
            {
                Console.WriteLine("Month number " + (showMonth + 1) + " is " + months[showMonth]);
            }





            // 3.) 

            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }




            //4.) 

            int[] randoes = new int[1000];

            Random random = new Random();

            for (int cycleNum = 0; cycleNum < 1000; cycleNum++)
            {
                randoes[cycleNum] = random.Next(0, 100);
            }

            foreach (int oneRandom in randoes)
            {
                Console.WriteLine(oneRandom);
            }


        }
    }
}
