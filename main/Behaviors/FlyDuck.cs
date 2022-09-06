using System;

namespace main
{
    class FlyDuck : IFly
    {
        public void Fly() => Console.WriteLine("Утка летит");
    }
}
