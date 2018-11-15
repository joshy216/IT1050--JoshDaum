using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050LabW13OOPJoshDaum
{
    class Car
    {
        private int Speed;
        private string Make;
        private string Model;
        private int Year;

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Speed = 0;
        }

        public Car(string make, string model, int year, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Speed = speed;
            this.Year = year;
        }

        public int SpeedUp()
        {
            this.Speed++;
            return this.Speed;

        }

        public int SlowDown()
        {
            if (this.Speed > 0)
            {
                this.Speed--;
            }
            return this.Speed;
        }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }

    }
}
