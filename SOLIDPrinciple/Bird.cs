using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    internal class Bird
    {
        public int legs { get; set; }
        public virtual void speek()
        {

        }

    }


    class Parrot : Bird {
        public override void speek()
        {
            Console.WriteLine("parrot speek");
        }
    }

}

