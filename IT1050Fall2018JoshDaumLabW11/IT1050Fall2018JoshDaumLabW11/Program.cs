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

            //string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[4]);




            // 2.) 

            //    string[] months = new string[12];

            //    for (int setMonth = 0; setMonth <= 11; setMonth++)
            //    {
            //        switch (setMonth)
            //        {
            //            case 0:
            //                months[setMonth] = "January";
            //                break;
            //            case 1:
            //                months[setMonth] = "February";
            //                break;
            //            case 2:
            //                months[setMonth] = "March";
            //                break;
            //            case 3:
            //                months[setMonth] = "April";
            //                break;
            //            case 4:
            //                months[setMonth] = "May";
            //                break;
            //            case 5:
            //                months[setMonth] = "June";
            //                break;
            //            case 6:
            //                months[setMonth] = "July";
            //                break;
            //            case 7:
            //                months[setMonth] = "August";
            //                break;
            //            case 8:
            //                months[setMonth] = "September";
            //                break;
            //            case 9:
            //                months[setMonth] = "October";
            //                break;
            //            case 10:
            //                months[setMonth] = "November";
            //                break;
            //            case 11:
            //                months[setMonth] = "December";
            //                break;
            //        }
            //    }

            //    for (int showMonth = 0; showMonth <= 11; showMonth++)
            //    {
            //        Console.WriteLine("Month number " + (showMonth + 1) + " is " + months[showMonth]);
            //    }





            // 3.) 

            //string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
            //foreach (string season in seasons) {
            //    Console.WriteLine(season);
            //}




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
