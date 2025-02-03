using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    internal class Demo
    {
        public IEnumerable<int> Display()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
