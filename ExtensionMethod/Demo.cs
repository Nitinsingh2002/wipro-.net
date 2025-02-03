using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
   public static class Demo
    {
        public static int newMethod(this string str)
        {
            return str.Length;
        }
    }
}
