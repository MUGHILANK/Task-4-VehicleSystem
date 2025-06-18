using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    abstract class Vehicle
        {
            
            private string brand;

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public abstract void Start();
            public virtual void ShowInfo()
            {
                Console.WriteLine("Vehicle Brand: " + Brand);
            }
    }
}
