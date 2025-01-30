using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wipro_day_4_oops
{
    internal class Dept : Employee
    {
        public string dept_name;

        //constructor of dept 
        public Dept(int id, string name,string dept_name):base(id ,name)
        {
            this.dept_name = dept_name;
        }

        public override void  display()
        {
            base.display();
            Console.WriteLine($"department name is {dept_name}");
        }
    }
}
