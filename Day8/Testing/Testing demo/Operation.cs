using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_demo
{
    public class Operation
    {

        public  virtual int add (int a, int b)
        {
            return a + b;
        }



        public int substract (int a , int b)
        {
            return a - b;
        }


        public int multiply(int a, int b)
        {
            return a * b;
        }


        public int divide (int a , int b)
        {
            return a / b;
        }


        public virtual bool checkValue()
        {
            return true;
        }
    }
}
