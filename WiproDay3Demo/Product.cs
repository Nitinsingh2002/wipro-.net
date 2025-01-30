using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay3Demo
{
    // internal acees modifier example 
    // here class name is ineteral means we can not use this classs in another project (assembly) 
    internal class Product
    {
        public string name;
        public int age;


        public Product(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        // method to display 
        public void display ()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }

        decimal a = Convert.ToDecimal(Console.ReadLine());
    }
}