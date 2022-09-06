using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Metal : Duck
    {
        public Metal() : base("Металлическая утка", new DuckCantQuak(), new DuckCantFly(), new DuckCantSwim(), new DuckDie()) { }

    }
}
