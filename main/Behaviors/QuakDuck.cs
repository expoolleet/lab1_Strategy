using System;

namespace main
{
    class QuakDuck : IQuak
    {
        public void Quak() => Console.WriteLine("Утка крякнула");
    }
}
