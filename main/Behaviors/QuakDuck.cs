using System;

namespace main.Behaviors
{
    internal class QuakDuck : IQuak
    {
        public void Quak() => Console.WriteLine("Утка крякнула");
    }
}
