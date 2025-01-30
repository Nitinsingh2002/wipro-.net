using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wipro_day_4_oops
{
    internal class Employee
    {
        public int emp_id;
        public string emp_name;

        //creating constructor of employee
        public Employee(int emp_id ,string emp_name)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
        }
       
        public virtual void display()
        {
            Console.WriteLine($"employee name is {emp_name} empolyee id is {emp_id}");
        }
    }
}
