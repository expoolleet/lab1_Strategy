using System;

namespace main
{
    class DuckDie : IDie
    {
        public void Die() => Console.WriteLine("Утка умерла"); 
    }
}
