using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class DuckCantQuak : IQuak
    {
        public void Quak() => Console.WriteLine("Утка не умеет крякать");
    }
}
