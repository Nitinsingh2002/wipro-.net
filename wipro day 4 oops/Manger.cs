using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wipro_day_4_oops
{
    internal class Manger : Dept
    {
        public string post_name;

        public Manger(int id,string emp_name, string dept_name, string post_name):base(id,emp_name,dept_name)
        {
            this.post_name = post_name;
        }

        public override void display ()
        {
            base.display();
            Console.WriteLine($"post name is {post_name}");
        }
    }
}
