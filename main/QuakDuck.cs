using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class QuakDuck : IQuak
    {
        public void Quak() => Console.WriteLine("Утка крякнула");
    }
}
