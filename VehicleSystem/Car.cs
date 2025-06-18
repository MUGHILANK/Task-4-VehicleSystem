using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with key...");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("This is a Car.");
            base.ShowInfo();
        }
    }

}
