using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class DuckCantFly : IFly
    {
        public void Fly() => Console.WriteLine("Утка не умеет летать");
    }
}
