using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace wipro_day_4_abstraction
{
    abstract class Animal
    {
        public abstract void speek();
        public void sleep()
        {
            Console.WriteLine("ZZZZ");
        }
    }


    class Dog : Animal { 
        public override void speek()
        {
            Console.WriteLine("barking");
        }
    }

}
