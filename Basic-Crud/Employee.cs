using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Crud
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }    
        public string dept {  get; set; }   
        public decimal salary { get; set; }

        public Employee(int id, string name, string dept ,decimal salary)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.salary = salary;
        }


        public Employee()
        {

        }


        public void displayEmployee()
        {
            Console.WriteLine("EmployeeDetails:");
            Console.WriteLine($"EmployeeID:{id} EmployeeName:{name} Department:{dept} Salary:{salary}");

        }

    }
}
