using System;
using main.Interfaces;

namespace main.Behaviors
{
    internal class DuckCantSwim : ISwim
    {
        public void Swim() => Console.WriteLine("Утка не умеет плавать");
    }
}
