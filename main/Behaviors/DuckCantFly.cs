using System;
using main.Interfaces;

namespace main.Behaviors
{
    internal class DuckCantFly : IFly
    {
        public void Fly() => Console.WriteLine("Утка не умеет летать");
    }
}
