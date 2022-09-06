using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class DuckCantDie : IDie
    {
        public void Die() => Console.WriteLine("Утка бесмертна");
    }
}
