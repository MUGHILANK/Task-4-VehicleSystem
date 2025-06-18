using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting with button...");
        }
        public override void ShowInfo()
        {
            Console.WriteLine("This is a Motorcycle.");
            base.ShowInfo();
        }
    }

}
