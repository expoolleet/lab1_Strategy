using System;
using main.Interfaces;

namespace main.Behaviors
{
    internal class DuckDie : IDie
    {
        public void Die() => Console.WriteLine("Утка умерла"); 
    }
}
