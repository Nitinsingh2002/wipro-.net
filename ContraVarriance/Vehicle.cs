using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraVarriance
{
    internal class Vehicle
    {
        public void display ( Vehicle v)
        {
            Console.WriteLine("object in vehicle " +  v);
        }
    }



    class Car : Vehicle
    {
        public void DisplayCar(Car c)
        {
            Console.WriteLine("object in car " + c);
        }
    }
}
