using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Fall2018JoshDaumFinalProject
{
    class Hero
    {        
            private string Alterego;
            private string Weakness;
            private bool Antihero;
            private string Gender;
            private string Race;

            public string Power;
            public int PowerLevel;
            public double Health;
            public string Weapons;
            public int Age;
            public string Name;
            public string nemesis;

            public Hero()
            {
            }

            public Hero(string name, string nemesis, string race, string power)
            {
                this.Name = name;
                this.nemesis = nemesis;
                this.Race = race;
                this.Power = power;
            }

            public Hero(string name, string nemesis, string race, string power, bool antihero)
            {
                this.Name = name;
                this.nemesis = nemesis;
                this.Race = race;
                this.Power = power;
                this.Antihero = antihero;
            }

        public Hero(string name, string race, string power)
            {
                this.Name = name;
                this.Race = race;
                this.Power = power;
            }

            //DONE TODO: Problem 1 - add a constructor method with a different number and/or types of parameters DONE

            public void FightCrime(string address)
            {
                if (PowerLevel > 49)
                {
                    this.Investigate();
                    Console.WriteLine("Successfully fought crime at " + address);
                }
                else
                {
                    this.Investigate();
                    Console.WriteLine(this.Name + " has failed -- level up and try again!");
                }
                // DONE TODO: Problem 2 - Output "Successfully fought crime at address" if PowerLevel > 49  DONE
            }

            private bool Investigate()
            {
                // DONE TODO: Problem 3 - output "Investigated Crime" and return true DONE
                bool returnValue = true;
                Console.WriteLine(this.Name + " investigated Crime.");
                return returnValue;
            }

            public void Fly()
            {
                // DONE TODO: Problem 4 - if Power contains Fly, then output "Name is Flying!" else output "Name can't fly!"  DONE
                if (this.Power.Contains("Fly"))
                {
                    Console.WriteLine(this.Name + " is flying!");
                }
                else
                {
                    Console.WriteLine(this.Name + " can't fly!");
                }
            }

            public void Craft(string material, int numMaterials)
            {
                Console.WriteLine("Crafting with " + material);
            }

            public void Climb(int height)
            {
                Console.WriteLine(this.Name + " is climbing.");
            }

            public int ChargePower()
            {
            // DONE TODO: Problem 5 - increase this.PowerLevel by 1 DONE
                this.PowerLevel++;
                return PowerLevel;
            }

            // DONE TODO: Problem 6 - Add an overloaded method ChargePower that has a parameter for increaseAmount.  Add increaseAmount to this.PowerLevel and return the new value 
            //for this.PowerLevel (try to use a loop calling the other ChargePower) DONE
            public int ChargePower(int amount)
            {
                for (int cPower = 0; cPower < amount; cPower++)
                {
                    ChargePower();
                }
                return PowerLevel;
            }
    }
}
