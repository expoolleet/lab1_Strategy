using System;

namespace main
{
    class DuckCantQuak : IQuak
    {
        public void Quak() => Console.WriteLine("Утка не умеет крякать");
    }
}
