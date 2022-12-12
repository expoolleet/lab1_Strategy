using System;

namespace main.Behaviors
{
    internal class DuckDie : IDie
    {
        public void Die() => Console.WriteLine("Утка умерла"); 
    }
}
