using System;
using main.Interfaces;

namespace main.Behaviors
{
    internal class FlyDuck : IFly
    {
        public void Fly() => Console.WriteLine("Утка летит");
    }
}
