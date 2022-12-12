using System;

namespace main.Behaviors
{
    internal class FlyDuck : IFly
    {
        public void Fly() => Console.WriteLine("Утка летит");
    }
}
