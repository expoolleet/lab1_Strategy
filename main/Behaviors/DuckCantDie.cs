using System;
using main.Interfaces;

namespace main.Behaviors
{
    internal class DuckCantDie : IDie
    {
        public void Die() => Console.WriteLine("Утка бесмертна");
    }
}
