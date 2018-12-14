using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Fall2018JoshDaumFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Super Bob", "human", "Fly, Super Speed, Jumping");
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want) DONE
                 - Investigate DONE
                 - FightCrime (at least one must win. at least one must not win) DONE
                 - Fly (at least one superhero should be able to fly) DONE
                 - Climb DONE
            */

            myHero.ChargePower();
            myHero.FightCrime("1234 Somestreet Lane");
            myHero.Fly();
            myHero.Climb(20);

            myOtherHero.ChargePower(100);
            myOtherHero.FightCrime("34 Walnut St.");
            myOtherHero.Fly();
            myOtherHero.Climb(120);

            thirdHero.ChargePower(50);
            thirdHero.FightCrime("12 Hopewell Ave.");
            thirdHero.Fly();
            thirdHero.Climb(220);


        }

    }
    
}
