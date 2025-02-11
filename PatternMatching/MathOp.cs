using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    internal class MathOp
    {
        public int add (int a, int b)
        {
            return a + b;
        }

        public int substract (int a, int b)
        {
            return a - b;
        }


        public int multiply (int a,int b)
        {
            return a * b;
        }


        public int divide (int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
