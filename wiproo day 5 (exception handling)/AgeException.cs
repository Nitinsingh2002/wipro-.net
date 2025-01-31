using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiproo_day_5__exception_handling_
{
    internal class AgeException :Exception
    {
        public AgeException(string error_Message) : base(error_Message) { }
    }
}
