using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wipro_day_4_abstraction
{
    internal interface Animals
    {
        void speek();

        void sleep()
        {
            Console.WriteLine("ZZZ");
        }
    }

    interface Shape
    {
        void area();
    }
    class Doga : Animals,Shape
    {
        public  void speek ()
        {
            Console.WriteLine("barking");
        }

        public void area()
        {
            Console.WriteLine("area");
        }
    }



}
