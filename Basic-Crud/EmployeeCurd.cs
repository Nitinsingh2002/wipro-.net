using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Crud
{
    internal class EmployeeCurd
    {
        private const int size = 5;
        Employee[] emp = new Employee[size];
        int emp_count = 0;

       


        //method to add employee
        public void addEmployee (int id, string name,string dept ,decimal salary)
        {
            Employee em = new Employee(id,name,dept,salary);
            emp[emp_count] = em;
            emp_count++;
            Console.WriteLine("Employee added");
        }


        // method to view employee
        public void display()
        {
            foreach(Employee e in emp)
            {
                e.displayEmployee();
            }
        }


        //methd to update employee


        //method to delete employee

    }
}
