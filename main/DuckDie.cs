using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class DuckDie : IDie
    {
        public void Die() => Console.WriteLine("Утка умерла"); 
    }
}
