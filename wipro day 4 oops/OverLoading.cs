using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wipro_day_4_oops
{
    internal class OverLoading
    {

          public int add(int x, int y)
        {
            return x+y;
        }

        public int add(int x, int y, int z)
        {
            return x + y +z;
        }

        public string add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
