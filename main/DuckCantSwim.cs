using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class DuckCantSwim : ISwim
    {
        public void Swim() => Console.WriteLine("Утка не умеет плавать");
    }
}
