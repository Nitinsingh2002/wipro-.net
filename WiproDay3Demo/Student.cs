using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay3Demo
{
    //private acess modifier example 
    public  class Student
    {
        private int age;
        private string name;

        //to set value we use constructor 
        public Student(string name , int age)
        {
            this.name = name;
            this.age = age;
        }

        //public method to display the ans
        public void display()
        {
            Console.WriteLine(age);
            Console.WriteLine(name);
        }
    }
}
