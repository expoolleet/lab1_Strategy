using System;

namespace main.Behaviors
{
    internal class DuckCantDie : IDie
    {
        public void Die() => Console.WriteLine("Утка бесмертна");
    }
}
