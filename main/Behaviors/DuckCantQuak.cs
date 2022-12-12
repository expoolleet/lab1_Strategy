using System;
using main.Interfaces;

namespace main.Behaviors
{
    internal class DuckCantQuak : IQuak
    {
        public void Quak() => Console.WriteLine("Утка не умеет крякать");
    }
}
