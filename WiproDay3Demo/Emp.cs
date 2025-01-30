using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay3Demo
{
    //public acees modifier example
    public class Emp
    {
        public string name;
        public int age;

        public Emp(string na, int ag)
        {
            name = na;
            age = ag;

        }

        //display method 
        public void display ()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }
    }
}
