using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covarriance
{
    internal class Vehicle
    {
       public Vehicle create()
        {
            Console.WriteLine("Vehicle created");
            return new Vehicle();
        }
    }


    class Car : Vehicle {
    public Car createCar()
        {
            Console.WriteLine("car created");
            return new Car();
        }
    }

}
